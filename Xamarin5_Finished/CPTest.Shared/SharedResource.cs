// Copyright 2019, Danny Hacker, Apache License 2.0, Soli Deo Gloria
using System;
using System.IO;
using System.Reflection;

namespace CPTest.Shared
{
    // settings.png is from: https://www.flaticon.com/free-icon/settings_149295
    // Icons made by Smashicons at flaticon.com and is licensed by Creative Commons 3.0

    public class SharedResource
    {
#if __ANDROID__
        public static string SharedPrefix = "CPTest.Droid.";
#elif __IOS__
        public static string SharedPrefix = "CPTest.iOS.";
#endif
        public SharedResource()
        {
        }

        static Assembly s_assembly = Assembly.GetExecutingAssembly();

        public static Stream GetStream(string name)
        {
            return s_assembly.GetManifestResourceStream(SharedPrefix + name);
        }
    }
}
