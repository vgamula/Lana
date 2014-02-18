using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class CompilersFactory
    {
        public static BaseCompiler GetCompiler(String name)
        {
            BaseCompiler compiler = (BaseCompiler)Activator.CreateInstance(Type.GetType(String.Format("Client.{0}Compiler", name)));
            return compiler;
        }
    }
}
