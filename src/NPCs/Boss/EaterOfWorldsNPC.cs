using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class EaterOfWorldsNPC : NPC_Base {
        public EaterOfWorldsNPC()
          : base(item: ModContent.ItemType<EaterOfWorlds>(), shopLoot: false) {
        }
    }
}
