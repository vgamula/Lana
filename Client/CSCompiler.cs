using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class CSCompiler : BaseCompiler
    {
        public CSCompiler()
        {
            this.CompilatorPath = @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe";
        }

        public override bool Compile(string fileName, String destination)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(this.CompilatorPath, String.Format("/out:\"{0}\" {1}", destination+"main.exe", fileName));
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.WaitForExit();
            return File.Exists(destination + "/main.exe");
        }
    }
}
