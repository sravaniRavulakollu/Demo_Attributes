using System;
using System.Text;

namespace Demo_UserDefined_Attribute
{
    [Author_Attribute("Dr.Ravi kumar")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo user Defined Attribute...");
            Author_Attribute A1 = new Author_Attribute("Dr.kiran");

            Console.WriteLine("By Default Version of the Author is: \t {0}",A1.Version_name);
        }
    }
    [System.AttributeUsage(System.AttributeTargets.Class|System.AttributeTargets.Method)]
    public class Author_Attribute:System.Attribute
    {
        private string AuthorName;
        public Double Version_name;

        public Author_Attribute(string name)
        {
            this.AuthorName = name;
            this.Version_name = 2.0;
            Console.WriteLine("Name of the Author is {0}", AuthorName);
        }
    }
}
