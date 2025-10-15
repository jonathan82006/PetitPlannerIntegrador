using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundButton : Button
{
    
    [DefaultValue(20)]
    public int CornerRadius { get; set; } = 20;

    protected override void OnPaint(PaintEventArgs pevent)
    {
        GraphicsPath grPath = new GraphicsPath();
        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
        // Código para dibujar las esquinas
        grPath.AddArc(rect.X, rect.Y, CornerRadius, CornerRadius, 180, 90);
        grPath.AddArc(rect.Right - CornerRadius, rect.Y, CornerRadius, CornerRadius, 270, 90);
        grPath.AddArc(rect.Right - CornerRadius, rect.Bottom - CornerRadius, CornerRadius, CornerRadius, 0, 90);
        grPath.AddArc(rect.X, rect.Bottom - CornerRadius, CornerRadius, CornerRadius, 90, 90);
        grPath.CloseFigure();

        this.Region = new Region(grPath);
        base.OnPaint(pevent);
    }
}
