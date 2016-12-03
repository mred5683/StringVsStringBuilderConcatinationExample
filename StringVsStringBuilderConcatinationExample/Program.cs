﻿using System;
using System.Text;

namespace StringVsStringBuilderConcatinationExample {
  internal class Program {
    private static void Main(string[] args) {
      const int sLen = 30, Loops = 30000;
      DateTime sTime, eTime;
      int i;
      var sSource = new string('X', sLen);
      var sDest = "";
      // 
      // Time string concatenation.
      // 
      sTime = DateTime.Now;
      for (i = 0; i < Loops; i++) sDest += sSource;
      eTime = DateTime.Now;
      Console.WriteLine("Concatenation took " + ( eTime - sTime ).TotalSeconds + " seconds.");
      // 
      // Time StringBuilder.
      // 
      sTime = DateTime.Now;
      var sb = new StringBuilder((int) ( sLen*Loops*1.1 ));
      for (i = 0; i < Loops; i++) sb.Append(sSource);
      sDest = sb.ToString();
      eTime = DateTime.Now;
      Console.WriteLine("String Builder took " + ( eTime - sTime ).TotalSeconds + " seconds.");
      // 
      // Make the console window stay open
      // so that you can see the results when running from the IDE.
      // 
      Console.WriteLine();
      Console.Write("Press Enter to finish ... ");
      Console.Read();
    }
  }
}
