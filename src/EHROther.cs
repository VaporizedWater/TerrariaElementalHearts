using ElementalHeartsRevivedMod.Assets.Effects;
using ElementalHeartsRevivedMod.Localization;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.ModLoader;


namespace ElementalHeartsRevivedMod.src
{
    public class HardHeart : ModItem
    {
        public string tag = nameof(HardHeart);
        public string name = Localization.GetText("Items.HardHeart.DisplayName");
        private bool tooltipCreated = false;

        public override string Texture
        {
            get => "ElementalHeartsRevivedMod/Assets/Items/Consumables/Hearts/Other/Hard";
        }

        public override bool CanUseItem(Player player)
        {
            return ModContent.GetInstance<EHRConfig>().EHRMaxHearts != 0 && !((EffectManager<Filter>)Filters.Scene)["EHRWave"].IsActive();
        }

        public override bool? UseItem(Player player)
        {
            player.GetModPlayer<EHRTracker>().used.Clear();
            SoundEngine.PlaySound(SoundID.PlayerKilled, new Vector2?());
            if (Main.netMode != NetmodeID.Server && !((EffectManager<Filter>)Filters.Scene)["EHRWave"].IsActive() && ModContent.GetInstance<EHRConfig>().EHRWaveEnabled)
            {
                int index = Projectile.NewProjectile(new EntitySource_ItemUse(player, Item, null), player.Center, new Vector2(0.0f, 0.0f), ModContent.GetInstance<EHRWave>().Type, 0, 0.0f, Main.myPlayer, 0.0f, 0.0f);
                (Main.projectile[index].ModProjectile as EHRWave).SetWaveValues();
            }
            ModContent.GetInstance<EHRModSystem>().DeleteText();
            return new bool?(true);
        }

        public override void SetStaticDefaults()
        {
            Mod.Logger.Error(tag + " initialized.");
            //CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.LifeFruit);
            Item.rare = ItemRarityID.Gray;
            Item.value = 0;// -5000;
        }

        public override void HoldItem(Player player)
        {
            if (!CanUseItem(player))
                return;
            ModContent.GetInstance<EHRModSystem>().SendEHRText("-" + Localization.GetText("CommonItemTooltip.BonusHP"), Color.Gray);
        }

        public override void UpdateInventory(Player player)
        {
            if (player.HeldItem == Item)
                return;
            ModContent.GetInstance<EHRModSystem>().DeleteText();
        }

        public override void AddRecipes()
        {
            Recipe recipe1 = Recipe.Create(ModContent.ItemType<HardHeart>(), 1);
            //recipe1.AddIngredient(this, 1);
            recipe1.AddTile(TileID.DemonAltar);
            recipe1.Register();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            if (!tooltipCreated)
            {
                TooltipLine tooltipLine = new TooltipLine(Mod, tag, name);
                tooltips.Add(tooltipLine);
                tooltipCreated = true;
            }
            if (!tooltipCreated)
                return;
            TooltipLine tooltip = tooltips.Find(ttl =>
            {
                return ttl.Name == tag;
            });
            if (tooltip != null)
            {
                tooltip.Text = Localization.GetText("Items.HardHeart.OptionalTip");
            }
        }

        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            ModContent.GetInstance<EHRModSystem>().DeleteText();
        }
    }
}