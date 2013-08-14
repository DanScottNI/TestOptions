using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestOptions.Classes;

namespace TestOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Options opt = new Options();
            opt.Something = "Some Crap";
            opt.TestId = 1;
            opt.TestIds = new Collection<int>() { 1, 2, 3, 4 };

            Type t = typeof(Options);
            PropertyInfo[] propList = t.GetProperties();

            foreach (var p in propList)
            {
                Console.Write(p.Name + "\t");

                var att = p.GetCustomAttribute<DescriptionAttribute>();
                var mapAtt = p.GetCustomAttribute<MappingAttribute>();

                BaseMappingClass cls = null;

                if (mapAtt != null)
                {
                    cls = new BaseMappingClass(mapAtt.MappingType);
                }

                object value = p.GetValue(opt, null);

                if (value != null)
                {
                    if (value as IList != null)
                    {
                        if (cls != null)
                        {
                            Console.WriteLine(string.Join(",", cls.GetVariables(opt.TestIds).ToArray()));
                        }
                        else
                        {
                            Console.Write(string.Join(",", opt.TestIds.Select(i => i.ToString()).ToArray()));
                        }
                    }
                    else
                    {
                        Console.Write(value.ToString());
                    }
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
