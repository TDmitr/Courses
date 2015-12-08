using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("input.txt"); 
            string str = ""; 

            while (!streamReader.EndOfStream) 
            {
                str += streamReader.ReadLine(); 
            }

            string[] newstr = str.Split('1');

            StreamWriter write_text;
            FileInfo file = new FileInfo("output.txt");
            write_text = file.AppendText(); 
            write_text.WriteLine(newstr.Length-1); 
            write_text.Close(); 
        }
    }
}
