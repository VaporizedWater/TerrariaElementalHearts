using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;

namespace ElementalHeartsRevivedMod.src.Hearts.Boss
{
    public class SoulOfSight : HeartBase, BossHeart, QuestRarity, ConsumableItem {
        public SoulOfSight()
          : base() {
        }
    }
}
