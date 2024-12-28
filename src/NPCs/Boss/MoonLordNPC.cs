using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class MoonLordNPC : NPC_Base {
        public MoonLordNPC()
          : base(NPCID.MoonLordCore, ModContent.ItemType<MoonLord>(), false) {
        }
    }
}
