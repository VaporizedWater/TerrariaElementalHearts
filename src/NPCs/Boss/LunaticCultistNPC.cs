using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class LunaticCultistNPC : NPC_Base {
        public LunaticCultistNPC()
          : base(NPCID.CultistBoss, ModContent.ItemType<LunaticCultist>(), false) {
        }
    }
}
