using Terraria.Localization;

/*
 * This is a proxy class to provide one single method for abstracting the localization update away from the rest of the classes
 * as much as possible.
 * 
 * It also allows me to name the method something that logically makes sense and isn't multiple confusing variations that all 
 * pretty much do the same thing.
 */

#nullable enable
namespace ElementalHeartsRevivedMod.Localization {
    public class LocalizationUtility {

        /// <summary> provides a single method as a proxy for getting localized text with or without text replacements </summary>
        public static string GetText(string key, string? replacementStr = null, object[]? replacements = null) {
            if (replacementStr != null) {
                return Language.GetTextValue("Mods.ElementalHeartsRevivedMod." + key, replacementStr);
            } else if (replacements != null) {
                return Language.GetTextValue("Mods.ElementalHeartsRevivedMod." + key, replacements);
            }
            return Language.GetTextValue("Mods.ElementalHeartsRevivedMod." + key);
        }
    }
}
