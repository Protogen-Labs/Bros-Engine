using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BrosEngine.Content;

public enum Side {
    UP,
    DOWN,
    LEFT,
    RIGHT,
    FRONT,
    BACK
}

public interface Tile {
    Side[] GetSolidSides(ActiveTile tile);
    bool IsFluid(ActiveTile tile);
    bool IsSolid(ActiveTile tile);
    void OnDig(ActiveTile tile);
    void OnHit(ActiveTile tile);
    void OnSwimOver(ActiveTile tile);
    void OnUse(ActiveTile tile);
    void OnWalkInto(ActiveTile tile);
    void OnWalkOver(ActiveTile tile);
    Texture2D GetTexture(ActiveTile tile);
}

public class ActiveTile {
    public Tile Tile;

    public ActiveTile(Tile tile, Engine engine) {
        Tile = tile;
    }
}

public class TilePos {
    public int X;
    public int Y;
    public int Z;

    public TilePos(int x, int y, int z) {
        X = x;
        Y = y;
        Z = z;
    }
}