using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class EmpressOfLightNPC : NPC_Base {
        public EmpressOfLightNPC()
          : base(NPCID.EmpressButterfly, ModContent.ItemType<EmpressOfLight>(), false) {
        }
    }
}
