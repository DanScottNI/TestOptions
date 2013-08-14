using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOptions.Classes
{
    public class TestManagerClass
    {
        public TestManagerClass()
        {
        }

        public Collection<TestObject> GetAllObjects()
        {
            return new Collection<TestObject>()
            {
                new TestObject() { Id =1, Name = "Dan1" },
                new TestObject() { Id =2, Name = "Dan2" },
                new TestObject() { Id =3, Name = "Dan3" },
                new TestObject() { Id =4, Name = "Dan4" },
                new TestObject() { Id =5, Name = "Dan5" },
                new TestObject() { Id =6, Name = "Dan6" },
                new TestObject() { Id =7, Name = "Dan7" },
            };
        }
    }
}
