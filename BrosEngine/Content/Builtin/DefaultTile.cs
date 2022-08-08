namespace BrosEngine.Content.Builtin;

class DefaultTile : Tile {
    public Side[] GetSolidSides(ActiveTile tile) => new Side[] {
        Side.UP,
        Side.DOWN,
        Side.LEFT,
        Side.RIGHT,
        Side.FRONT,
        Side.BACK
    };
    public bool IsFluid(ActiveTile tile) => false;
    public bool IsSolid(ActiveTile tile) => true;
    public void OnDig(ActiveTile tile) {}
    public void OnHit(ActiveTile tile) {}
    public void OnSwimOver(ActiveTile tile) {}
    public void OnUse(ActiveTile tile) {}
    public void OnWalkInto(ActiveTile tile) {}
    public void OnWalkOver(ActiveTile tile) {}
}