using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;

namespace AlphaProps
{
    //Setting the Harmony instance
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.AlphaProps");
            harmony.PatchAll(Assembly.GetExecutingAssembly());       
        }          
    }
}
