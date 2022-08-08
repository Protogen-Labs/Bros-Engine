using BrosEngine.Registry;

namespace BrosEngine.Content.Builtin;

class BuiltinTiles {
    public static Tile DEFAULT = BuiltinRegistries.TILES.Register(Id("default"), new DefaultTile());

    private static IdentifiableString Id(string value) => new IdentifiableString("BrosEngine", value);
}