using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TestOptions.Classes
{
    public class Options
    {
        [Description("Testing ID")]
        public int? TestId { get; set; }

        //[Description("Some Random Text")]
        public string Something { get; set; }

        [Description("Test IDs")]
        [Mapping(MappingType = typeof(TestObject))]
        public Collection<int> TestIds { get; set; }
    }
}
