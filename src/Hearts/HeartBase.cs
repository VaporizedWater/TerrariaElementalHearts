using ElementalHeartsRevivedMod.Assets.Effects;
using ElementalHeartsRevivedMod.lib;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using ElementalHeartsRevivedMod.Localization;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.ModLoader;


namespace ElementalHeartsRevivedMod.src.Hearts {
    /// <summary>
    /// The base class for all hearts in the mod. Contains all the necessary logic for hearts to function. <br></br>
    /// Including the functionality for many of the marker interfaces.
    /// </summary>
    public abstract class HeartBase : ModItem {
        private const string UnusedHeartTooltipValue = "[0/";

        // Properties
        protected string tag;
        protected string name;
        protected int bonusHP;
        protected string texturePath;
        protected int rarity;
        protected Func<Color> rarityColor = () => {
            return Color.White;
        };


        // Tooltip constants
        protected bool tooltipCreated;
        protected string optionalTip;
        protected string bonus;
        protected string bossHeartsDisabled;
        protected string materialHeartsDisabled;
        protected string maxConsumed;
        protected string maxHP;
        protected string heartsNotUsed;
        protected string equipmentConsumedWarning;

        private static readonly EHR_ModSystem EHR_ModSystem = ModContent.GetInstance<EHR_ModSystem>();
        private static readonly EHR_Mod EHR_Mod = ModContent.GetInstance<EHR_Mod>();
        private static readonly Config Config = ModContent.GetInstance<Config>();
        private static readonly EHR_RippleEffect RippleEffect = ModContent.GetInstance<EHR_RippleEffect>();

        protected virtual int CraftingStation => TileID.Dirt;
        protected virtual List<int> MaterialCost => [];
        protected virtual int CopperCoinCost => 100;

        public HeartBase() {
            tag = RegexExtensions.CapitalLetters.Replace(GetType().Name, " $0").Trim();

            PatternMatchingInitializers();

            //update localized tooltips
            InitializeTooltipTexts();

            // Not to be confused with the Tooltip, which automatically gets included above any additional text,
            // so this allows tooltip/flavor text to be ordered how I want it (down below in CalculateTooltip).
            optionalTip = LocalizationUtility.GetText("Items." + GetType().Name + ".OptionalTip");
            if (optionalTip.Contains("Mods.ElementalHeartsRevivedMod")) {
                optionalTip = string.Empty;
            }

            name = LocalizationUtility.GetText("Items." + GetType().Name + ".DisplayName");
        }

        /// <summary>
        /// Biggest part of the marker interface system.
        /// This method is called a single time within the constructor to initialize the given heart.
        /// It sets instance variables to whatever the heart needs based on the marker interfaces it has. 
        /// This is done to avoid having to check for interfaces every single time a value is needed, 
        /// which could get expensive for a game like terraria that is primarily single-core.
        /// </summary>
        private void PatternMatchingInitializers() {
            string prefix = "";

            if (this is BossHeart) {
                prefix = "Boss/";
                ModContent.GetInstance<EHR_Mod>().bossHearts.Add(this, ModContent.GetInstance<EHR_Mod>().bossHearts.Count + 1);
            } else if (this is HardmodeHeart) {
                prefix = "Hardmode/";
                ModContent.GetInstance<EHR_Mod>().naturalHearts.Add(this, ModContent.GetInstance<EHR_Mod>().naturalHearts.Count + 1);
            } else if (this is PreHardmodeHeart) {
                prefix = "PreHardmode/";
                ModContent.GetInstance<EHR_Mod>().naturalHearts.Add(this, ModContent.GetInstance<EHR_Mod>().naturalHearts.Count + 1);
            } else if (this is UtilityHeart) {
                prefix = "Utility/";
                ModContent.GetInstance<EHR_Mod>().naturalHearts.Add(this, ModContent.GetInstance<EHR_Mod>().naturalHearts.Count + 1);
            } else if (this is AlloyHeart) {
                prefix = "Alloy/";
                ModContent.GetInstance<EHR_Mod>().naturalHearts.Add(this, ModContent.GetInstance<EHR_Mod>().naturalHearts.Count + 1);
            } else {
                prefix = "Test/";
                ModContent.GetInstance<EHR_Mod>().naturalHearts.Add(this, ModContent.GetInstance<EHR_Mod>().naturalHearts.Count + 1);
            }

            // All of these are + 1 because the rarity of White = 0
            if (this is BlueRarity) {
                rarity = (this as BlueRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as BlueRarity).ItemColor;
            } else if (this is CyanRarity) {
                rarity = (this as CyanRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as CyanRarity).ItemColor;
            } else if (this is GreenRarity) {
                rarity = (this as GreenRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as GreenRarity).ItemColor;
            } else if (this is LightPurpleRarity) {
                rarity = (this as LightPurpleRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as LightPurpleRarity).ItemColor;
            } else if (this is LightRedRarity) {
                rarity = (this as LightRedRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as LightRedRarity).ItemColor;
            } else if (this is LimeRarity) {
                rarity = (this as LimeRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as LimeRarity).ItemColor;
            } else if (this is OrangeRarity) {
                rarity = (this as OrangeRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as OrangeRarity).ItemColor;
            } else if (this is PinkRarity) {
                rarity = (this as PinkRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as PinkRarity).ItemColor;
            } else if (this is PurpleRarity) {
                rarity = (this as BlueRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as PurpleRarity).ItemColor;
            } else if (this is RedRarity) {
                rarity = (this as RedRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as RedRarity).ItemColor;
            } else if (this is WhiteRarity) {
                rarity = (this as WhiteRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as WhiteRarity).ItemColor;
            } else if (this is YellowRarity) {
                rarity = (this as YellowRarity).ItemRarity;
                bonusHP = (rarity + 1) * Config.EHRLovePower;
                rarityColor = (this as YellowRarity).ItemColor;
            }

            /// <summary>
            /// QuestRarity, ExpertRarity, and MasterRarity are special cases because they have negative IDs.
            /// Lite original posted around the internet that boss hearts were 5 HP, so I'm going with that for Quest Rarity.
            /// But there are no original Expert or Master hearts, so I'm taking the liberty of increasing them by 1 and 2 respectively.
            /// 
            /// Additionally, original mod respected the rarity assigned to the materials of craftable hearts, even though the values of
            /// some of those rarities went far higher than 5. The highest being 11, which means the bonusHP of those hearts would be 12.
            /// So the material hearts above could definitely have far higher bonusHP values, but the counter to this is that there
            /// currently are extremely few hearts that have those rarities, and the fact that they are so rare means they are also 
            /// just plain difficult to get. So I'm not going to worry about it.
            /// </summary>
            else if (this is QuestRarity) {
                rarity = (this as QuestRarity).ItemRarity;
                bonusHP = 5 * Config.EHRLovePower;
                rarityColor = (this as QuestRarity).ItemColor;
            } else if (this is ExpertRarity) {
                rarity = (this as ExpertRarity).ItemRarity;
                bonusHP = 6 * Config.EHRLovePower;
                rarityColor = (this as ExpertRarity).ItemColor;
            } else if (this is MasterRarity) {
                rarity = (this as MasterRarity).ItemRarity;
                bonusHP = 7 * Config.EHRLovePower;
                rarityColor = (this as MasterRarity).ItemColor;
            }

            texturePath = new StringBuilder().Append(Constants.HeartsPath).Append(prefix).Append(RegexExtensions.Spaces.Replace(tag, string.Empty)).ToString();
        }

        private void InitializeTooltipTexts() {
            bonus = LocalizationUtility.GetText("CommonItemTooltip.IncreaseLifeBy", bonusHP.ToString());
            bossHeartsDisabled = LocalizationUtility.GetText("CommonItemTooltip.BossHearsDisabled");
            materialHeartsDisabled = LocalizationUtility.GetText("CommonItemTooltip.MaterialHeartsDisabled");
            maxConsumed = LocalizationUtility.GetText("CommonItemTooltip.MaxConsumed");
            maxHP = LocalizationUtility.GetText("CommonItemTooltip.MaxHP");
            heartsNotUsed = LocalizationUtility.GetText("CommonItemTooltip.HeartNotUsed");
            equipmentConsumedWarning = "";

            if (this is CraftableItem) {
                if (MaterialCost.Count < 1) {
                    return;
                }
                StringBuilder materialsList = new();
                if (MaterialCost.Count > 1) {
                    foreach (int itemID in MaterialCost) {
                        Item item = new(itemID);
                        _ = materialsList.Append('\n').Append(item.Name);
                    }
                } else if (MaterialCost.Count == 1) {
                    Item item = new(MaterialCost[0]);
                    _ = materialsList.Append('\n').Append(item.Name);
                }
                equipmentConsumedWarning = LocalizationUtility.GetText("CommonItemTooltip.EquipmentConsumedWarning", materialsList.ToString());
            }

        }

        public override string Texture => texturePath;

        public override bool CanUseItem(Player player) {
            if (this is BossHeart && !Config.EHRBossEnabled) {
                return false;
            }

            if (this is CraftableItem && !Config.EHRMaterialEnabled) {
                return false;
            }

            if (Config.EHRMaxHearts == 0 || Filters.Scene[Constants.RippleEffectName].IsActive()) {
                return false;
            }

            EHR_Player modPlayer = player.GetModPlayer<EHR_Player>();
            return !modPlayer.used.ContainsKey(tag) || modPlayer.used[tag] < Config.EHRMaxHearts * bonusHP;
        }

        public override bool? UseItem(Player player) {
            player.statLifeMax2 += bonusHP;
            player.statLife += bonusHP;

            if (Main.myPlayer == player.whoAmI) {
                player.HealEffect(bonusHP, true);
            }

            EHR_Player modPlayer = player.GetModPlayer<EHR_Player>();
            if (modPlayer.used.ContainsKey(tag)) {
                modPlayer.used[tag] += bonusHP;
            } else {
                modPlayer.used.Add(tag, bonusHP);
            }

            if (Main.netMode != NetmodeID.Server && !Filters.Scene[Constants.RippleEffectName].IsActive() && Config.EHRWaveEnabled) {
                int index = Projectile.NewProjectile(new EntitySource_ItemUse(player, Item), player.Center, new Vector2(0.0f, 0.0f), RippleEffect.Type, 0, 0.0f, Owner: Main.myPlayer);
                (Main.projectile[index].ModProjectile as EHR_RippleEffect).SetWaveValues(bonusHP);
            }

            EHR_ModSystem.DeleteText();
            return true;
        }

        public override void SetStaticDefaults() {
            Mod.Logger.Info(tag + " initialized."); //Do not localize logs, these are more for the developer than the player
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() {
            Item.CloneDefaults(ItemID.LifeFruit);
            Item.rare = rarity;

            // If it is a buyable item, it likely has its own set price, so use that
            if (this is BuyableItem) {
                Item.value = CopperCoinCost;
            } else {
                // Otherwise, calculate the price based on the material cost
                if (MaterialCost.Count != 0) {
                    int value = 0;
                    foreach (int material in MaterialCost) {
                        value += (int)(new Item(material).value * (CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[material] / 1.25));
                    }
                    Item.value = value;
                }
            }

            if (this is ConsumableItem) {
                Item.consumable = true;
            }
        }

        public override void HoldItem(Player player) {
            if (!base.CanUseItem(player)) { return; }

            StringBuilder text = new('+');
            _ = text.Append(bonusHP).Append(' ').Append(maxHP);
            EHR_ModSystem.SendEHRText(text.ToString(), rarityColor());
        }

        public override void UpdateInventory(Player player) {
            if (player.HeldItem != Item) { EHR_ModSystem.DeleteText(); }

            if (this is BossHeart) {
                if (Config.EHRBossEnabled) {
                    return;
                }
                _ = player.SellItem(Item);
                Item.TurnToAir();
            } else {
                if (Config.EHRMaterialEnabled) {
                    return;
                }
                _ = player.SellItem(Item);
                Item.TurnToAir();
            }
        }

        /// <summary>
        /// Provides an override-able method for utility hearts to change the tooltip content without modifying tooltip behavior.
        /// </summary>
        protected virtual void ModifyTooltip(TooltipLine tooltip) {
            tooltip.Text = CalculateTooltip();
        }

        /// <summary>
        /// After doing a lot of testing and looking at the example mod on the tml github, I've come to the conclusion that it is
        /// acceptable to create and add a tooltip everytime this gets called because old tooltips seem to be garbage collected as
        /// the count of the tooltipline list doesn't wildly increase and in some instances, it had decreased. This is good because
        /// it will allow me to animate the colors of the tooltip using an EHR_Utility method.
        /// </summary>
        /// <param name="tooltips"></param>
        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            TooltipLine tooltipLine = new(Mod, tag, name);
            ModifyTooltip(tooltipLine);
            tooltips.Add(tooltipLine);
        }

        public override void Update(ref float gravity, ref float maxFallSpeed) {
            EHR_ModSystem?.DeleteText();
        }

        public override void AddRecipes() {
            // Thinking about adding a new crafting station that allows crafting alloyed hearts that have multiple materials as the requirement
            // So by default, this will only support the legacy hearts with only 1 crafting material

            if (this is CraftableItem && Config.EHRMaterialEnabled && MaterialCost.Count == 1) {
                CreativeItemSacrificesCatalog catalog = CreativeItemSacrificesCatalog.Instance;

                // Add heart recipe if Craftable heart
                Recipe heartRecipe = CreateRecipe();
                foreach (int material in MaterialCost) {
                    _ = heartRecipe.AddIngredient(
                        material,
                        catalog.SacrificeCountNeededByItemId[material] * Config.EHRRecipeDifficulty
                    );
                }

                if (Config.EHRCraftingStationRequired) {
                    _ = heartRecipe.AddTile(CraftingStation);
                    _ = heartRecipe.Register();
                } else {
                    _ = heartRecipe.Register();
                }

                // Add recycling recipe, if recycling is enabled
                if (Config.EHRRecycleEnabled && MaterialCost.Count > 0) {
                    Recipe recipe = Recipe.Create(MaterialCost[0], Math.Max(1, (int)(catalog.SacrificeCountNeededByItemId[MaterialCost[0]] * Config.EHRRecipeDifficulty / 1.25)));
                    _ = recipe.AddIngredient(this);
                    _ = recipe.AddTile(TileID.Extractinator);
                    _ = recipe.Register();
                }
                return;
            }
        }

        /// <summary>
        /// Given the current properties of this heart, and some additional checks, calculate the tooltip to be displayed.
        /// </summary>
        private string CalculateTooltip() {
            StringBuilder tooltipReturned = new(bonus);

            //calculate bonus + optional tooltip first to reduce complexity of checks below
            if (string.IsNullOrWhiteSpace(optionalTip)) {
                _ = tooltipReturned.Append('\n');
            } else {
                _ = tooltipReturned.Append('\n').Append(optionalTip).Append('\n');
            }

            //If the player is hovering over the crafting menu, then return the equipment consumed warning
            if (EHR_ModSystem.isUserHoveringOverCraftingMenu && this is NonConsumableMaterialCost) {
                _ = tooltipReturned.Append(equipmentConsumedWarning).Append('\n');
            }

            //if current heart is a boss heart and boss hearts are disabled
            if (this is BossHeart) {
                if (!Config.EHRBossEnabled) {
                    _ = tooltipReturned.Append(bossHeartsDisabled);
                    return tooltipReturned.ToString();
                }
            }

            //if current heart is a crafted material heart and material hearts are disabled
            else if (!Config.EHRMaterialEnabled) {
                _ = tooltipReturned.Append(materialHeartsDisabled);
                return tooltipReturned.ToString();
            }

            //if the max hearts in the mod config are set to 1 (default behavior) and if player cannot use the item, then that means they've already used it
            if (Config.EHRMaxHearts == 1) {
                if (!CanUseItem(Main.LocalPlayer)) {
                    _ = tooltipReturned.Append(maxConsumed);
                    return tooltipReturned.ToString();
                }
            }

            //if max hearts in the config is greater than 1 then show the amount of hearts used out of the max amount of hearts that can be used
            if (Config.EHRMaxHearts > 1) {
                _ = Main.LocalPlayer.GetModPlayer<EHR_Player>().used.TryGetValue(tag, out int usedHearts);
                int amountUsed = usedHearts / bonusHP;
                if (Main.LocalPlayer.GetModPlayer<EHR_Player>().used.ContainsKey(tag)) {
                    _ = tooltipReturned.Append('［').Append(amountUsed).Append('/').Append(Config.EHRMaxHearts).Append('］');
                } else {
                    _ = tooltipReturned.Append(UnusedHeartTooltipValue).Append(Config.EHRMaxHearts).Append('］');
                }
                return tooltipReturned.ToString();
            }

            _ = tooltipReturned.Append(heartsNotUsed);
            return tooltipReturned.ToString();
        }

        public override Color? GetAlpha(Color lightColor) {
            if (this is RainbowItem || this is ExpertRarity) {
                return Main.DiscoColor;
            }
            return base.GetAlpha(lightColor);
        }
    }
}
