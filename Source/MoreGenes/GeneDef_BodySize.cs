using Verse;
using HarmonyLib;

[HarmonyPatch(typeof(Pawn), "BodySize", MethodType.Getter)]
public static class Pawn_BodySize
{
    public static void Postfix(ref float __result, Pawn __instance)
    {
        if(__instance != null && __instance.genes != null)
        {
            if (__instance.genes.HasGene(DefDatabase<GeneDef>.GetNamed("LargeBodySize")))
            {
                __result = (float)(__result * 1.25);
            }
            if(__instance.genes.HasGene(DefDatabase<GeneDef>.GetNamed("SmallBodySize")))
            {
                __result = (float)(__result * 0.75);
            }
        } 

    }
}


/*

[HarmonyPatch(typeof(Pawn), "RaceProps", MethodType.Getter)]
public static class Pawn_RaceProps
{
    public static void Postfix(ref RaceProperties __result, Pawn __instance)
    {
        if (__instance != null && __instance.genes != null)
        {
            //if(__instance.kindDef.defName)
            ThingDef defaultMeatDef = DefDatabase<ThingDef>.GetNamed("Meat_Human");
            ThingDef defaultLeatherDef = DefDatabase<ThingDef>.GetNamed("Leather_Human");
            
            if (__instance.genes.HasGene(DefDatabase<GeneDef>.GetNamed("PigAnimalType")))
            {
                __result.meatDef = DefDatabase<ThingDef>.GetNamed("Meat_Pig");
                __result.leatherDef = DefDatabase<ThingDef>.GetNamed("Leather_Pig");
            }
            else
            {
                __result.meatDef = defaultMeatDef;
                __result.leatherDef = defaultLeatherDef;
            }
            
        }
    }
}

*/