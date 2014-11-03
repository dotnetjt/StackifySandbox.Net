using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloStackify.Web.Models
{
    public class TestModels
    {

        public string TestString { get; set; }
        public int TestInt { get; set; }
        public bool TestBool { get; set; }
    }


    public class Foo
    {
        public int ID { get; set; }

        public int RequiredInt { get; set; }
        public string FooString { get; set; }

        public string FooString2 { get; set; }

        public bool? FooBool { get; set; }
    }
}