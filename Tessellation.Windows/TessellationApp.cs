using Stride.Engine;

namespace Tessellation
{
    class TessellationApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
