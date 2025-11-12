using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CustomComboBox : ComboBox
    {
        private Color _borderColor = Color.LightBlue; // Couleur de bordure
        private int _borderRadius = 5;
        private int _borderThickness = 1;

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }
        public int BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = value; Invalidate(); }
        }

        public CustomComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList; // Empêche l'édition de texte
            FlatStyle = FlatStyle.Flat;

            // Définir la taille dès l'initialisation
            this.Size = new Size(348, 37);
        }

        

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            e.Graphics.DrawString(Items[e.Index].ToString(), Font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0xF || m.Msg == 0x85) // WM_PAINT or WM_NC_PAINT
            {
                using (Graphics g = Graphics.FromHwnd(Handle))
                {
                    using (Pen pen = new Pen(_borderColor, _borderThickness))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.DrawRoundedRectangle(pen, new Rectangle(0, 0, Width - 1, Height - 1), _borderRadius);
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Dessiner l'arrière-plan
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    g.FillRoundedRectangle(brush, new Rectangle(0, 0, Width, Height), _borderRadius);
                }

                // Dessiner la bordure
                using (Pen pen = new Pen(_borderColor, 2))
                {
                    g.DrawRoundedRectangle(pen, new Rectangle(0, 0, Width - 1, Height - 1), _borderRadius);
                }

                // Dessiner le texte
                TextRenderer.DrawText(g, Text, Font, new Rectangle(4, 4, Width - 20, Height - 8), ForeColor);

                // Dessiner la flèche du menu déroulant
                DrawArrow(g);
            }
        }

        private void DrawArrow(Graphics g)
        {
            int arrowX = Width - 20;
            int arrowY = (Height / 2) - 2;
            Point[] arrowPoints =
            {
                new Point(arrowX, arrowY),
                new Point(arrowX + 10, arrowY),
                new Point(arrowX + 5, arrowY + 5)
            };
            using (Brush brush = new SolidBrush(ForeColor))
            {
                g.FillPolygon(brush, arrowPoints);
            }
        }
    }

    // Extension pour dessiner des rectangles arrondis
    public static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, Rectangle bounds, int radius)
        {
            using (GraphicsPath path = CreateRoundedRectanglePath(bounds, radius))
            {
                graphics.FillPath(brush, path);
            }
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle bounds, int radius)
        {
            using (GraphicsPath path = CreateRoundedRectanglePath(bounds, radius))
            {
                graphics.DrawPath(pen, path);
            }
        }

        private static GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}