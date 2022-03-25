using System;

namespace tpmodul5_1302190047
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo saya = new SayaTubeVideo("Tutorial Design By Contract - Idzhari Syaeful M");
            saya.IncreasePlayCount(0);
            saya.PrintVideoDetails();

            Console.WriteLine();

            SayaTubeVideo saya1 = new SayaTubeVideo("Idzhari Syaeful M");
            saya1.IncreasePlayCount(1000000000);
            saya1.PrintVideoDetails();
        }
    }
}
