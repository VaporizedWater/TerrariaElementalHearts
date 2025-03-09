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

        /// <summary> provides a single method for getting localized text with or without text replacements </summary>
        public static string GetText(string key, object[] replacements) {
            return Language.GetTextValue("Mods.ElementalHeartsRevivedMod." + key, replacements);
        }

        /// <summary> provides a single method for getting localized text with or without text replacements </summary>
        public static string GetText(string key) {
            return Language.GetTextValue("Mods.ElementalHeartsRevivedMod." + key);
        }

        /// <summary> provides a single method for getting localized text with or without text replacements </summary>
        public static string GetText(string key, string replacementStr) {
            return Language.GetTextValue("Mods.ElementalHeartsRevivedMod." + key, replacementStr);
        }
    }
}
