

namespace BrosEngine.Content;

interface Tile {
    void OnHit();
    void OnDig();
    void OnWalkOver();
    void OnWalkInto();
    void OnSwimOver();
    bool IsSolid();
    bool IsFluid();
}

class TileMap {

}