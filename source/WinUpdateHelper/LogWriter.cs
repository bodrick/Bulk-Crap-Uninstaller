/*
    Copyright (c) 2017 Marcin Szeniak (https://github.com/Klocman/)
    Apache License Version 2.0
*/

using System;
using System.IO;
using System.Reflection;

namespace WinUpdateHelper
{
    internal static class LogWriter
    {
        public static void WriteMessageToLog(string message)
        {
            var location = Assembly.GetCallingAssembly().Location;
            location = location[..^3] + "log";

            using var writer = new StreamWriter(location, true);
            writer.WriteLine("--- " + DateTime.UtcNow);
            writer.WriteLine(message);
        }
    }
}
