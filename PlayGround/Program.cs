using System;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            int incidentID = 277162;

            var monthSub = DateTime.Now.Month.ToString().Substring(DateTime.Now.Month.ToString().Length - 2);
            var incidentRef = string.Format("{0}-{1}", DateTime.Now.ToString("yyMMdd"), incidentID.ToString().Substring(1));

            var guid = Guid.NewGuid().ToString("N");

            Console.WriteLine(incidentRef);
            Console.WriteLine(guid);
            Console.ReadKey();
        }
    }
}
