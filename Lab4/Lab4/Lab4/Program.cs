using System;

namespace Lab4
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      Time t1 = new Time(4, 20, 28);
      Time t2 = new Time();
      
      Console.WriteLine($"\nT1: {t1.Hours()}:{t1.Minutes()}:{t1.Seconds()}");
      Console.WriteLine($"T2: {t2.Hours()}:{t2.Minutes()}:{t2.Seconds()}");
      
      int m1 = 17, m2 = 34;
      t1 += m1;
      t2 += m2;
      
      Console.WriteLine($"\nT1 after adding 17 m: {t1.Hours()}:{t1.Minutes()}:{t1.Seconds()}");
      Console.WriteLine($"T2 after adding 34 m: {t2.Hours()}:{t2.Minutes()}:{t2.Seconds()}");
      Console.WriteLine($"Time between T1 & T2: {(t1 - t2).Hours()}:{(t1 - t2).Minutes()}:{(t1 - t2).Seconds()}");
      
      Time t3 = new Time(t1);
      
      Console.WriteLine($"\nT3: {t3.Hours()}:{t3.Minutes()}:{t3.Seconds()}");
      Console.WriteLine($"Time left until the end of day: {t3.ToEod().Hours()}:{t3.ToEod().Minutes()}:{t3.ToEod().Seconds()}");
    }
  }
}