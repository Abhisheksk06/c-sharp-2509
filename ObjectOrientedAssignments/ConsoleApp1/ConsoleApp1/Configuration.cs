using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Configuration
    {
        // static field for system-wide settings
        public static string AppName;

        // instance fields for individual user preferences
        public string UserTheme;
        public string LanguagePreference;

        // static constructor to initialize system-wide settings
        static Configuration()
        {
            AppName = "My Application"; // initializing the application name
            Console.WriteLine("Static constructor called: AppName initialized to " + AppName);
        }

        // instance constructor to initialize user preferences
        public Configuration(string userTheme, string languagePreference)
        {
            UserTheme = userTheme;
            LanguagePreference = languagePreference;
            Console.WriteLine("Instance constructor called: User preferences set.");
        }

        // method to display system-wide settings
        public static void DisplaySystemSettings()
        {
            Console.WriteLine("Application Name: " + AppName);
        }

        // method to display individual user preferences
        public void DisplayUserPreferences()
        {
            Console.WriteLine($"User Theme: {UserTheme}, Language: {LanguagePreference}");
        }
    }
}
