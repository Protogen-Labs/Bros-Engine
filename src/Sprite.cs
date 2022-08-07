using Microsoft.Xna.Framework.Graphics;

namespace BrosEngine;

class Sprite {
    public readonly Engine Engine;
    public Sprite(Engine engine, string fileName) {
        Engine = engine;
        Engine.Content.Load<Texture2D>(fileName);
    }


}