using PulsarModLoader;

namespace ExteriorZoomSave
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.0.0";

        public override string Author => "18107";

        public override string ShortDescription => "Remembers the last zoom level when entering the pilot's seat";

        public override string Name => "Exterior Zoom Save";

        public override string ModID => "exteriorzoomsave";

        public override string HarmonyIdentifier()
        {
            return "id107.exteriorzoomsave";
        }
    }
}
