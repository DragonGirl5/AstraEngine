using AstraEngine.Core;
using AstraEngine.InputSystem;
using AstraEngine.Canvas2D;

namespace AstraEngine.Examples.PlayerMovement;

public sealed class ClickController : Component
{
    public override void Tick(double delta)
    {
        if (Input.Shared.IsMouseClicked())
        {
            Entity.GetComponent<Rectangle2D>()!.Color = Color.White;
        }
    }
}