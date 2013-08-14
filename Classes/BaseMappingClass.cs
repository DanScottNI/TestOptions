using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOptions.Classes
{
    class BaseMappingClass
    {
        private Type MappedType;


        public BaseMappingClass(Type type)
        {
            this.MappedType = type;
        }

        public List<string> GetVariables(IList<int> ids)
        {
            if (this.MappedType == typeof(TestObject))
            {
                DansGenericClass<TestObject, TestManagerClass> m = new DansGenericClass<TestObject, TestManagerClass>(
                    r =>
                    {
                        return r.GetAllObjects();
                    }
                );

                TestManagerClass cls = new TestManagerClass();

                var list = m.DoStuff(cls);

                return list.Where(l => ids.Contains(l.Id)).Select(l => l.Name).ToList();
            }

            return new List<string>();
        }
    }

    class DansGenericClass<T, T1>
    {
        public DansGenericClass(Func<T1, Collection<T>> act)
        {
            this.DoStuff = act;
        }

        public Func<T1, Collection<T>> DoStuff { get; set; }
    }
}
