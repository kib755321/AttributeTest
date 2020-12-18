using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTest
{
    public interface ITest
    {
        string Name { get; set; }
    }

    public class TestA : ITest
    {
        [Some("A")]
        public string Name { get; set; }
    }

    public class TestB : ITest
    {
        [Some("B")]
        public string Name { get; set; }
    }

    public class SomeAttribute : Attribute
    {
        public SomeAttribute(string value)
        {
            this.Value = value;
        }

        public string Value { get; set; }
    }
}
