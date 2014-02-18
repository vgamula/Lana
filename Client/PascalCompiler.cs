using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class PascalCompiler : BaseCompiler
    {
        public PascalCompiler()
        {
            this.CompilatorPath = @"Compilers\Pascal\bin\i386-win32\ppcrossx64.exe";
        }

        public override bool Compile(string fileName, String destination)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"..\..\"+this.CompilatorPath, String.Format("-FE\"{0}\" -o\"main.exe\" {1}", destination, fileName));
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.WaitForExit();
            return File.Exists(destination + "/main.exe");
        }
    }
}
