using System;
using System.Reflection;
using System.Text;

namespace Custom.Rename
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSecretMessage();
            WriteSecretMessage2();
        }

        /// <summary>
        /// Custom Rename Attribute Example
        /// Replace 'RelaceMe' With New Method Name
        /// </summary>
        /// <remarks></remarks>
        [Obfuscation(Feature = "rename=RelaceMe", Exclude = false)]
        public static void WriteSecretMessage()
        {
            Console.WriteLine(Encoding.ASCII.GetString(Convert.FromBase64String("SGVsbG8gV29ybGQ=")));
        }

        /// <summary>
        ///  Custom Rename Attribute Example 2
        ///  New Method Name '44BDBFBFD'
        ///  </summary>
        /// <remarks></remarks>
        [Obfuscation(Feature = "rename=44BDBFBFD", Exclude = false)]
        public static void WriteSecretMessage2()
        {
            Console.WriteLine(Encoding.ASCII.GetString(Convert.FromBase64String("SGVsbG8gV29ybGQ=")));
        }
    }
}
