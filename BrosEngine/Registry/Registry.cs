using BrosEngine.Content;

namespace BrosEngine.Registry;

class IdentifiableString {
    private readonly string Owner;
    private readonly string Value;

    public IdentifiableString(string owner, string value) {
        Owner = owner;
        Value = value;
    }

    public string GetOwner() => Owner;
    public string GetValue() => Value;
}

class ContentRegistry<T> {
    #region predefined registries
        public static readonly ContentRegistry<Tile> TILE = new ContentRegistry<Tile>();
    #endregion

    private Dictionary<IdentifiableString, T> registry = new Dictionary<IdentifiableString, T>();

    public ContentRegistry() {
        
    }
}