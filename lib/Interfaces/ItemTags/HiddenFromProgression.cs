namespace ElementalHeartsRevivedMod.lib.Interfaces.ItemTags {

    /// <summary>
    /// An item tag applied to special hearts that will hide them (by default) from the heart tracker UI that will be added after the overhaul.
    /// Will show a "black heart with a question mark" sprite for the image with question marks for the title and descriptions. 
    /// Shows the existence of the heart, but does not give clues on how to get it. Used for hidden achievement sort of things.
    /// 
    /// Hearts that do not have this will have (if not unlocked) a darkened UI element in the list, with the heart sprite being the "black heart with a question mark". 
    /// However, the difference is that they will have the name of the heart and the description listed on their entry. 
    /// </summary>
    internal interface HiddenFromProgression {
    }
}
