using System.Text.RegularExpressions;

namespace ElementalHeartsRevivedMod.lib {
    internal static class RegexExtensions {
        internal static Regex CapitalLetters = new("[A-Z]");
        internal static Regex Spaces = new(" ");
    }
}
