using BrosEngine;

namespace BrosTest;

class Program {
    static void Main(string[] args) {
        Engine engine = new Engine("Test game");
        engine.SetGameLogic(() => {
                
        });
        engine.Init();
    }
}