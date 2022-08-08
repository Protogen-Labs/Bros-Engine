using BrosEngine.Content;
using BrosEngine.Exception.Registry;

namespace BrosEngine.Registry;

class BuiltinRegistries {
    public static readonly ContentRegistry<Tile> TILES = new ContentRegistry<Tile>();
}

class ContentRegistry<T> {

    private Dictionary<IdentifiableString, T> Registry = new Dictionary<IdentifiableString, T>();

    public ContentRegistry() {}

    public T Register(IdentifiableString id, T value) {
        if (Registry[id] != null) throw new RegistrySpotTakenException<T>(this, id);
        Registry[id] = value;
        return value;
    }
}