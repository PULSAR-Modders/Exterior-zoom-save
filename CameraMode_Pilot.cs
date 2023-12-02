using HarmonyLib;

namespace ExteriorZoomSave
{
    [HarmonyPatch(typeof(PLCameraMode_Pilot), "Tick")]
    internal class CameraMode_Pilot
    {
        private static float distance = 220f;

        static void Prefix(ref float ___distance, ref float ___smoothDistance)
        {
            ___distance = distance;

            if (___smoothDistance == 100f)
            {
                ___smoothDistance = distance;
            }
        }

        static void Postfix(float ___distance)
        {
            distance = ___distance;
        }
    }
}
