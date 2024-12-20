using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ElementalHeartsRevivedMod.src
{
    public class EHR_Config : ModConfig
    {

        private const string baseConfig = "$Mods.ElementalHeartsRevivedMod.Configs.EHRConfig.";

        [Header(baseConfig + "Headers.Basic")]
        [Category("Regular")]
        [BackgroundColor(255, 64, 159, 255)]
        [DefaultValue(false)]
        [LabelKey(baseConfig + "EHRInfoEnabled.Label")]
        [TooltipKey(baseConfig + "EHRInfoEnabled.Tooltip")]
        [Description(baseConfig + "EHRInfoEnabled.Tooltip")]
        public bool EHRInfoEnabled;


        [Category("Regular")]
        [BackgroundColor(128, 141, 158, 255)]
        [DefaultValue(true)]
        [LabelKey(baseConfig + "EHRWaveEnabled.Label")]
        [TooltipKey(baseConfig + "EHRWaveEnabled.Tooltip")]
        [Description(baseConfig + "EHRWaveEnabled.Tooltip")]
        public bool EHRWaveEnabled;


        [Category("Regular")]
        [BackgroundColor(193, 223, 156, 255)]
        [DefaultValue(true)]
        [LabelKey(baseConfig + "EHRRecycleEnabled.Label")]
        [TooltipKey(baseConfig + "EHRRecycleEnabled.Tooltip")]
        [Description(baseConfig + "EHRRecycleEnabled.Tooltip")]
        public bool EHRRecycleEnabled;


        [Header(baseConfig + "Headers.DontTouch")]
        [Category("Advanced")]
        [BackgroundColor(255, 0, 102, 150)]
        [DefaultValue(1)]
        [Range(1, int.MaxValue)]
        [ReloadRequired]
        [LabelKey(baseConfig + "EHRMaxHearts.Label")]
        [TooltipKey(baseConfig + "EHRMaxHearts.Tooltip")]
        [Description(baseConfig + "EHRMaxHearts.Tooltip")]
        public int EHRMaxHearts;


        [Category("Advanced")]
        [BackgroundColor(255, 130, 243, 150)]
        [DefaultValue(2)]
        [Range(1, 100)]
        [ReloadRequired]
        [LabelKey(baseConfig + "EHRLovePower.Label")]
        [TooltipKey(baseConfig + "EHRLovePower.Tooltip")]
        [Description(baseConfig + "EHRLovePower.Tooltip")]
        public int EHRLovePower;


        [Category("Advanced")]
        [BackgroundColor(135, 255, 235, 150)]
        [DefaultValue(1)]
        [Range(1, 100)]
        [ReloadRequired]
        [LabelKey(baseConfig + "EHRRecipeDifficulty.Label")]
        [TooltipKey(baseConfig + "EHRRecipeDifficulty.Tooltip")]
        [Description(baseConfig + "EHRRecipeDifficulty.Tooltip")]
        public int EHRRecipeDifficulty;

        [Category("Advanced")]
        [DefaultValue(true)]
        [ReloadRequired]
        [LabelKey(baseConfig + "EHRCraftingStationRequired.Label")]
        [TooltipKey(baseConfig + "EHRCraftingStationRequired.Tooltip")]
        [Description(baseConfig + "EHRCraftingStationRequired.Tooltip")]
        public bool EHRCraftingStationRequired;

        [Category("Advanced")]
        [DefaultValue(true)]
        [ReloadRequired]
        [LabelKey(baseConfig + "EHRBossEnabled.Label")]
        [TooltipKey(baseConfig + "EHRBossEnabled.Tooltip")]
        [Description(baseConfig + "EHRBossEnabled.Tooltip")]
        public bool EHRBossEnabled;


        [Category("Advanced")]
        [DefaultValue(true)]
        [ReloadRequired]
        [LabelKey(baseConfig + "EHRMaterialEnabled.Label")]
        [TooltipKey(baseConfig + "EHRMaterialEnabled.Tooltip")]
        [Description(baseConfig + "EHRMaterialEnabled.Tooltip")]
        public bool EHRMaterialEnabled;


        [Category("Advanced")]
        [BackgroundColor(128, 117, 121, 150)]
        [DefaultValue(false)]
        [LabelKey(baseConfig + "RoamingLogsEnabled.Label")]
        [TooltipKey(baseConfig + "RoamingLogsEnabled.Tooltip")]
        [Description(baseConfig + "RoamingLogsEnabled.Tooltip")]
        public bool RoamingLogsEnabled;


        public override ConfigScope Mode => ConfigScope.ServerSide;
    }
}
