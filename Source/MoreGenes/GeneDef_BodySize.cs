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
