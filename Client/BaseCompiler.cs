using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public abstract class BaseCompiler
    {
        public String CompilatorPath { get; set; }

        public String CompiledProgramPath;

        public abstract Boolean Compile(String fileName, String destination);

    }
}
