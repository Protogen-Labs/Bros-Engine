using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BrosEngine.Content;

public class TileMap {
    public Tile BackgroundTile;
    public Dictionary<TilePos, ActiveTile> Tiles = new Dictionary<TilePos, ActiveTile>();
    private readonly Engine Engine;

    public TileMap(Engine engine, Tile backgroundTile) {
        Engine = engine;
        BackgroundTile = backgroundTile;
    }

    public void Render(float x, float y, float z) {
        float totalY = y - z;
        // TODO: Account for z
        int dz = 0;
        for (int dy = (int)MathF.Floor(totalY); dy < MathF.Ceiling(totalY + 20); dy++) {
            for (int dx = (int)MathF.Floor(x); dx < MathF.Ceiling(x + 30); dx++) {
                var pos = new TilePos(dx,dy,dz);
                if (Tiles[pos] != null) {
                    var texture = Tiles[pos].Tile.GetTexture(Tiles[pos]);
                    Engine.SpriteBatch!.Draw(texture, new Vector2(dx, dy), Color.White);
                }
            }
        }
    }
}