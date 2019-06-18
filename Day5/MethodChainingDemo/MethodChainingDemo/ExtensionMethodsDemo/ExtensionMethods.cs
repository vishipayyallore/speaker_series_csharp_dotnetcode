namespace MethodChainingDemo.ExtensionMethodsDemo
{
    public static class ExtensionMethods
    {

        public static (int value, bool parsed) ParseToInteger(this string input)
        {
            var returnValue = (value: 0, parsed: false);

            returnValue.parsed = int.TryParse(input, out returnValue.value);

            return returnValue;
        }

    }

}
