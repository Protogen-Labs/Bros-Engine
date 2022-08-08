using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BrosEngine.Content;

interface Tile {
    bool IsFluid(ActiveTile tile);
    bool IsSolid(ActiveTile tile);
    void OnDig(ActiveTile tile);
    void OnHit(ActiveTile tile);
    void OnSwimOver(ActiveTile tile);
    void OnUse(ActiveTile tile);
    void OnWalkInto(ActiveTile tile);
    void OnWalkOver(ActiveTile tile);
}

class ActiveTile {
    public Tile Tile;

    public ActiveTile(Tile tile) {
        Tile = tile;
    }
}

class TileMap {
    public TileMap() {}

    public void Render(Engine engine, float x, float y, float z) {
        float totalY = y + z;
        
    }
}