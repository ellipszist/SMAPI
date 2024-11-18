namespace StardewModdingAPI.Toolkit.Framework.Clients.Wiki;

/// <summary>Metadata from the wiki's mod compatibility list.</summary>
public class WikiModList
{
    /*********
    ** Accessors
    *********/
    /// <summary>The mods on the wiki.</summary>
    public WikiModEntry[] Mods { get; }


    /*********
    ** Public methods
    *********/
    /// <summary>Construct an instance.</summary>
    /// <param name="mods">The mods on the wiki.</param>
    public WikiModList(WikiModEntry[] mods)
    {
        this.Mods = mods;
    }
}
