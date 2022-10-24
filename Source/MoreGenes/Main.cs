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
        }
    }
}