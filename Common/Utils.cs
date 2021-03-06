﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Utils
    {
        public static String GetMD5Hash(String input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string password = s.ToString();
            return password;
        }

        public static bool MakeTests(String pathToProgramm, User user, Task task)
        {
            using (var db = new DatabaseEntities())
            {
                bool passed = true;
                foreach (var item in db.Tests.Where(t => t.TaskId == task.Id).ToList())
                {
                    if (!PassTest(pathToProgramm, item)) 
                    {
                        passed = false;
                        break;
                    }
                }
                Result result = new Result()
                    {
                        PassingTime = DateTime.Now,
                        TaskId = task.Id,
                        UserId = user.Id,
                        IsPassed = Convert.ToInt32(passed)
                    };
                db.Results.Add(result);
                db.SaveChanges();
                return passed;
            }
        }

        public static bool PassTest(String pathToProgramm, Test test)
        {
            Process process = new Process();
            process.StartInfo.FileName = pathToProgramm;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            StreamWriter sw = process.StandardInput;
            StreamReader sr = process.StandardOutput;
            sw.Write(test.InputData);
            String result = sr.ReadToEnd().Trim();
            sr.Close();
            sw.Close();
            return result == test.OutputData;
        }

        public static T Clone<T>(T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            // Don't serialize a null object, simply return the default for that object
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }

    }
}
