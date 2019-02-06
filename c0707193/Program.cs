using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _707193
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA();
        }

        public static void MethodA()
        {
            while (Peanut())
            {
                Console.WriteLine("help i am stuck in infinite loop");

            }
        }

        public static bool Peanut()
        {

            // GGGG
            return true;
        }
    }
}

