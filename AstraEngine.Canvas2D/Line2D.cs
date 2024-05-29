using AstraEngine.Canvas2D;

namespace AstraEngine.DrawLine;

public class Line2D : Drawable
{
    /// <summary>
    /// For 
    /// </summary>
    public double Width { get; set; }

    public Color Color { get; set; }

    public Position2D Start { get; set; }

    public Position2D End { get; set; }

    public override void Draw(ICanvas2D renderer)
    {
        renderer.DrawLine(Start, End, Width, Color);
    }
}