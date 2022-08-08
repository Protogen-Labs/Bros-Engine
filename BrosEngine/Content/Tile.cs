using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BrosEngine.Content;

enum Side {
    UP,
    DOWN,
    LEFT,
    RIGHT,
    FRONT,
    BACK
}

interface Tile {
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

class ActiveTile {
    public Tile Tile;

    public ActiveTile(Tile tile) {
        Tile = tile;
    }
    
}