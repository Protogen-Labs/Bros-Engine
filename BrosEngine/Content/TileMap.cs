

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

}