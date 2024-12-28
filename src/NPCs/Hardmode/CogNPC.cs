using ElementalHeartsRevivedMod.src.Hearts.Hardmode;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Hardmode {
    public class CogNPC : NPC_Base {
        public CogNPC()
          : base(NPCID.Steampunker, ModContent.ItemType<Cog>()) {
        }
    }
}
