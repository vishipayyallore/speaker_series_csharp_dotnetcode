using static System.Console;

namespace MethodChainingAndExtensions.ChainingDemo
{

    public class SoftwareDeveloper
    {

        public SoftwareDeveloper GathersRequirements()
        {
            WriteLine("Software Develper Gathers Requirements.");
            return this;
        }


        public SoftwareDeveloper WritesCode()
        {
            WriteLine("Software Develper Writes Code.");
            return this;
        }

        public SoftwareDeveloper WriteUnitTests()
        {
            WriteLine("Software Develper Writes Unit Tests.");
            return this;
        }

        public SoftwareDeveloper DeploysCodeToProduction()
        {
            WriteLine("Software Develper Deploys Code To Production.");
            return this;
        }

    }

}
