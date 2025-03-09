namespace ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory {

    /// <summary>
    /// Hearts that will be considerably more difficult to craft, but can provide an option for additional hearts, if one needs a bit more health due to skill issues.
    /// Will require smelted ores, no raw materials, advanced crafting stations, possibly special constraints like time of day or weather conditions.
    /// Downside is that completionists may dislike this, or they might actually love this because it adds an extra and interesting layer of complexity.
    /// <br></br><br></br>
    /// So far, no heart has been implemented with this category.
    /// </summary>
    internal interface AlloyHeart : ItemCategoryBase {
        new string PathPrefix => "Alloy/";
    }
}
