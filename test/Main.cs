using BrosEngine;

namespace BrosTest;

class Program {
    static void Main(string[] args) {
        Engine engine = new Engine("Test game").Init();
        engine.SetGameLogic(() => {
            
        });
    }
}