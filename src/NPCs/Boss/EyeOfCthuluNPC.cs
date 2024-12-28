using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class EyeOfCthulhuNPC : NPC_Base {
        public EyeOfCthulhuNPC()
          : base(NPCID.EyeofCthulhu, ModContent.ItemType<EyeOfCthulhu>(), false) {
        }
    }
}
