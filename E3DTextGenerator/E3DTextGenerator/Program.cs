using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DTextGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                E3DTextGeneratorForm e3DTextGeneratorForm = new E3DTextGeneratorForm();
                var result = e3DTextGeneratorForm.ShowDialog();
            }
        }
    }
}
