using System.Collections.Generic;
using System.Linq;

namespace TuringModules.Common
{
    static class Validator
    {
        public static List<string> AllModulesList;
        public static List<string> NoParameterModuleList;
        public static List<string> OneParameterModuleList;
        public static List<string> TwoParameterModuleList;

        public static void LoadResource()
        {
            string modules = Properties.Resources.ResourceManager.GetString("SupportedModules");
            AllModulesList = modules.Split(',').ToList<string>();

            modules = Properties.Resources.ResourceManager.GetString("NoParameter");
            NoParameterModuleList = modules.Split(',').ToList<string>();

            modules = Properties.Resources.ResourceManager.GetString("OneParameter");
            OneParameterModuleList = modules.Split(',').ToList<string>();

            modules = Properties.Resources.ResourceManager.GetString("TwoParameter");
            TwoParameterModuleList = modules.Split(',').ToList<string>();
        }

        public static bool IsValidModule(string moduleName)
        {
            if (AllModulesList.IndexOf(moduleName) == -1)
                return false;

            return true;
        }
    }
}
