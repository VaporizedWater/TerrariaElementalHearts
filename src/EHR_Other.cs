using ElementalHeartsRevivedMod.Assets.Effects;
using ElementalHeartsRevivedMod.lib;
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
        public string name = LocalizationUtility.GetText("Items.HardHeart.DisplayName");
        private bool tooltipCreated = false;

        public override string Texture
        {
            get => Constants.HeartsPath + "Other/Hard";
        }

        public override bool CanUseItem(Player player)
        {
            return ModContent.GetInstance<Config>().EHRMaxHearts != 0 && !((EffectManager<Filter>)Filters.Scene)[Constants.RippleEffectName].IsActive();
        }

        public override bool? UseItem(Player player)
        {
            player.GetModPlayer<EHR_Tracker>().used.Clear();
            SoundEngine.PlaySound(SoundID.PlayerKilled, new Vector2?());
            if (Main.netMode != NetmodeID.Server && !((EffectManager<Filter>)Filters.Scene)[Constants.RippleEffectName].IsActive() && ModContent.GetInstance<Config>().EHRWaveEnabled)
            {
                int index = Projectile.NewProjectile(new EntitySource_ItemUse(player, Item, null), player.Center, new Vector2(0.0f, 0.0f), ModContent.GetInstance<EHR_RippleEffect>().Type, 0, 0.0f, Main.myPlayer, 0.0f, 0.0f);
                (Main.projectile[index].ModProjectile as EHR_RippleEffect).SetWaveValues();
            }
            ModContent.GetInstance<EHR_ModSystem>().DeleteText();
            return new bool?(true);
        }

        public override void SetStaticDefaults()
        {
            Mod.Logger.Error(tag + " initialized.");
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.LifeFruit);
            Item.rare = ItemRarityID.Gray;
            Item.value = 0;
        }

        public override void HoldItem(Player player)
        {
            if (!CanUseItem(player))
                return;
            ModContent.GetInstance<EHR_ModSystem>().SendEHRText("-" + LocalizationUtility.GetText("CommonItemTooltip.BonusHP"), Color.Gray);
        }

        public override void UpdateInventory(Player player)
        {
            if (player.HeldItem == Item)
                return;
            ModContent.GetInstance<EHR_ModSystem>().DeleteText();
        }

        public override void AddRecipes()
        {
            Recipe recipe1 = Recipe.Create(ModContent.ItemType<HardHeart>(), 1);
            recipe1.AddTile(TileID.DemonAltar);
            recipe1.Register();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            if (!tooltipCreated)
            {
                TooltipLine tooltipLine = new(Mod, tag, name);
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
                tooltip.Text = LocalizationUtility.GetText("Items.HardHeart.OptionalTip");
            }
        }

        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            ModContent.GetInstance<EHR_ModSystem>().DeleteText();
        }
    }
}