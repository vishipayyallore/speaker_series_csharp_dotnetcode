using MethodChainingAndExtensions.ChainingDemo;
using System.Text;

namespace MethodChainingAndExtensions.ExtensionMethodsDemo
{

    public static class ExtensionMethods
    {
        public static (int value, bool parsed) ParseToInteger(this string input)
        {
            var returnValue = (value: 0, parsed: false);

            returnValue.parsed = int.TryParse(input, out returnValue.value);

            return returnValue;
        }


        public static string GetSoftwareDeveloper(this SoftwareDeveloper softwareDeveloper)
        {
            var stringBuilder = new StringBuilder(1024);
            var personDetails = stringBuilder
                                    .Append("Name: Shiva")
                                    .Append("\nAge: 25")
                                    .Append("\nSalary: 1234.56");

            return personDetails.ToString();
        }
    }


}
