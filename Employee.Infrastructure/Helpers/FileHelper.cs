﻿using System;

namespace Employee.Infrastructure.Helpers
{
    public static class FileHelper
    {
        public const string PersistancePath = "..\\..\\Employee\\Employee.Infrastructure\\Persistences\\";

        public static string Read(string location)
        {
            try
            {
                return System.IO.File.ReadAllText(location);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error Reading File : " + ex);
                System.Console.WriteLine("Continue ... ");

                return "";
            }            
        }
    }
}
