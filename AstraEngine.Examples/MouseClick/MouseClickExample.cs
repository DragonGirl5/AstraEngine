using AstraEngine.Canvas2D;
using AstraEngine.Canvas2D.RaylibAdapter;
using AstraEngine.Core;

namespace AstraEngine.Examples.PlayerMovement;

public static class MouseClickExample
{
    public static void Run()
    {
        // Create a Windowed Game
        WindowedGame game = new();


        // Add a player to the game
        game.Root.AddChild(CreatePlayer());
        // Run the game
        Engine.Run(game);
    }

    private static Entity CreatePlayer()
    {
        Entity player = new();
        Rectangle2D toAdd = new() { Width = 50, Height = 40, Color = Color.Blue };
        player.AttachComponent(toAdd);
        // The player is a white rectangle
        // The player starts at position 50, 50
        player.AttachComponent(new Position2D { X = 50, Y = 50 });
        // The player can be controlled using the arrow keys
        player.AttachComponent(new ClickController());
        return player;
    }
}