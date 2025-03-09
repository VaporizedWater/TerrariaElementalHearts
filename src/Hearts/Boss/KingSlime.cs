using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;

namespace ElementalHeartsRevivedMod.src.Hearts.Boss
{
    public class KingSlime : HeartBase, BossHeart, QuestRarity, ConsumableItem {
        public KingSlime()
          : base() {
        }
    }
}
