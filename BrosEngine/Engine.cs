using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using BrosEngine.Content;

namespace BrosEngine;

public class Engine : Game {

    private GraphicsDeviceManager Graphics;
    public SpriteBatch? SpriteBatch;

    private string title;

    private Action GameLogic = () => {
        Console.WriteLine("No game logic set!");
    };

    public Engine(string title) {
        Graphics = new GraphicsDeviceManager(this);
        this.title = title;
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    public Engine Init() {
        new Thread(new ThreadStart(Run)).Start();
        return this;
    }

    public Sprite createSprite(string fileName) {
        return new Sprite(this);
    }

    public void SetGameLogic(Action logic) {
        GameLogic = logic;
    }

    protected override void Initialize() {
        System.Console.WriteLine("=============================");
        System.Console.WriteLine("== Initializing BrosEngine ==");
        System.Console.WriteLine("=============================");

        Window.Title = title;

        base.Initialize();

        System.Console.WriteLine("============================");
        System.Console.WriteLine("== Initialized BrosEngine ==");
        System.Console.WriteLine("============================");
    }

    protected override void LoadContent() {
        SpriteBatch = new SpriteBatch(GraphicsDevice);
    }

    protected override void Update(GameTime gameTime) {
        GameLogic();

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        base.Draw(gameTime);
    }
}