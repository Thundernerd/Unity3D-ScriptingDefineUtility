using UnityEditor;

namespace TNRD.Utilities
{
    public static class ScriptingDefineUtility
    {
        /// <summary>
        /// Returns the symbols split by ';'
        /// </summary>
        public static string[] Symbols
        {
            get
            {
                string symbols = GetSymbols();
                return symbols.Split(';');
            }
        }

        /// <summary>
        /// Returns the raw string with scripting define symbols for the selected build target group
        /// </summary>
        public static string GetSymbols()
        {
            BuildTargetGroup buildTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
            string symbols = PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTargetGroup);
            return symbols;
        }

        /// <summary>
        /// Overwrites the scripting define symbols for the selected build target group
        /// </summary>
        public static void SetSymbols(string symbols)
        {
            BuildTargetGroup buildTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
            PlayerSettings.SetScriptingDefineSymbolsForGroup(buildTargetGroup, symbols);
        }

        /// <summary>
        /// Adds the given symbol to the selected build target group
        /// </summary>
        /// <param name="symbol">A single scripting define symbol</param>
        public static void Add(string symbol)
        {
            string symbols = GetSymbols();
            if (string.IsNullOrEmpty(symbol))
            {
                symbols = symbol;
            }
            else
            {
                symbols += $";{symbol}";
            }

            SetSymbols(symbols);
        }

        /// <summary>
        /// Checks if the selected build target group contains the given symbol
        /// </summary>
        /// <param name="symbol">The symbol to check</param>
        /// <returns>true when found, false when not found</returns>
        public static bool Contains(string symbol)
        {
            BuildTargetGroup buildTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
            string symbols = PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTargetGroup);
            return symbols.Contains(symbol);
        }

        /// <summary>
        /// Removes the given symbol from the selected build target group
        /// </summary>
        /// <param name="symbol">The symbol to remove</param>
        public static void Remove(string symbol)
        {
            string symbols = GetSymbols();

            if (symbols.Contains($"{symbol};"))
            {
                symbols = symbols.Replace($"{symbol};", string.Empty);
            }
            else if (symbols.Contains(symbol))
            {
                symbols = symbols.Replace(symbol, string.Empty);
            }
            else
            {
                return;
            }

            SetSymbols(symbols);
        }

        /// <summary>
        /// Removes all symbols from the selected build target group. Use with caution.
        /// </summary>
        public static void Clear()
        {
            SetSymbols(string.Empty);
        }
    }
}
