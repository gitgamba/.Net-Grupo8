using System;

namespace AuthTestings1
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public static string Something()
        { return "Algo"; }

        public static bool Login(string user, string pass) =>
            user == "rafael" && pass == "123456" ? true : false;
            
    }
}
