using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestOptions.Classes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    sealed class MappingAttribute : Attribute
    {
        // This is a positional argument
        public MappingAttribute()
        {
            // TODO: Implement code here
        }

        // This is a named argument
        public Type MappingType { get; set; }
    }
}
