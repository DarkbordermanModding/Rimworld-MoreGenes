using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using UnityEngine;
using Verse;
namespace MoreGenes
{
    [StaticConstructorOnStartup]
    public static class Main
    {
        static Main()
        {
            new Harmony("Mlie.VariedBodySizes").PatchAll(Assembly.GetExecutingAssembly());

            GeneDef x = new GeneDef();

            if (false)
            {
                // Use code to dynamically add/remove GeneDef
                x.displayCategory = DefDatabase<GeneCategoryDef>.GetNamed("Hidden");
                x.defName = "Pork";
                DefDatabase<GeneDef>.Add(x);
            }
        }
    }
}