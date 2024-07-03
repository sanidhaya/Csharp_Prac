using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class CustomAttribute : Attribute
    {
        public string Description { get; set; }

        public CustomAttribute(string description)
        {
            Description = description;
        }
    }

    [CustomAttribute("this is a custom attribute")]
    public class  NewClass
    {
        [CustomAttribute("This is a method with custom attribute")]
        public void NewMethod()
        {
            Console.WriteLine("blah blah blah");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(NewClass);
            var classAttributes = type.GetCustomAttributes(true);

            foreach(var attr in classAttributes)
            {
                if (attr is CustomAttribute myAttr)
                {
                    Console.WriteLine($"Class attribute description : {myAttr.Description}");
                }
            }

            var method = type.GetMethod("NewMethod");
            var methodAttributes = method.GetCustomAttributes(true);

            foreach(var attr in methodAttributes)
            {
                if (attr is CustomAttribute myAttr)
                {
                    Console.WriteLine($"method attribute description : {myAttr.Description}");
                }
            }
        }
    }
}
