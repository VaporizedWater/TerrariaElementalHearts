using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class MartianSaucerNPC : NPC_Base {
        public MartianSaucerNPC()
          : base(NPCID.MartianSaucerCore, ModContent.ItemType<MartianSaucer>(), false) {
        }
    }
}
