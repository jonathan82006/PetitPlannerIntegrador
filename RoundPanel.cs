using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundPanel : Panel
{
    [Category("Appearance")]
    [Description("El radio de las esquinas del panel.")]
    [DefaultValue(30)]
    public int CornerRadius { get; set; } = 30;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        GraphicsPath path = new GraphicsPath();
        // Código para dibujar las esquinas redondeadas
        path.AddArc(new Rectangle(0, 0, CornerRadius * 2, CornerRadius * 2), 180, 90);
        path.AddArc(new Rectangle(Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2), 270, 90);
        path.AddArc(new Rectangle(Width - CornerRadius * 2, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2), 0, 90);
        path.AddArc(new Rectangle(0, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2), 90, 90);
        path.CloseAllFigures();
        Region = new Region(path);
    }
}
