﻿using System;

namespace Learn.CSharp.Language
{
    delegate void LogMessage();
    delegate void LogCustomMessage(string message);

    public class Program
    {
        public static void Main(string[] args)
        {
            #region LogMessage delegate
            
            LogMessage lm = () =>
            {
                Console.WriteLine("Logging using LogMessage delegate");
            };

            lm();
            
            #endregion

            #region LogCustomMessage delegate

            LogCustomMessage lcm = (s) =>
            {
                Console.WriteLine(s);
            };

            lcm("Log this message using LogCustomMessage delegate");

            #endregion

            #region LogMessage Action delegate
            
            Action<string> LogMessageAction = (message) => Console.WriteLine(message);
            LogMessageAction("With Action delegate"); 

            #endregion

            Console.ReadLine(); 
        }
    }
}
