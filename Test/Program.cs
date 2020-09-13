using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = new List<dynamic>();

            Assembly Assemblies = Assembly.Load("BalanceGlobal"); //.Where(x => x.FullName.Contains( "Repository") || x.FullName.Contains("Service") ))
            foreach (Type type in Assemblies.GetTypes().Where(x => x.Namespace == "BalanceGlobal.Repository" || x.Namespace == "BalanceGlobal.Service" ))
            {
                //Type.GetType($"{type.Namespace}.I{type.Name},{type.Assembly.FullName}"), Type.GetType($"{type.FullName},{type.Assembly.FullName}");

                //Console.WriteLine($"{type.Namespace}.I{type.Name},{type.Assembly.FullName}");
                var a = Type.GetType($"{type.FullName}, {type.Assembly.FullName}");
                var b = Type.GetType($"{type.Namespace}.I{type.Name},{type.Assembly.FullName}");
                var c = 1;
            }
            //DirectoryInfo d = new DirectoryInfo(@"C:\Users\Gerardo\source\repos\BalanceGlobalApi\BalanceGlobal\Entities");
            //FileInfo[] infos = d.GetFiles();
            //foreach (FileInfo f in infos)
            //{
            //   //Console.WriteLine(f.FullName);
            //    File.Move(f.FullName, f.FullName.Replace(".cs", "Entity.cs"));
            //}

            Console.ReadLine();
        }
    }
}
