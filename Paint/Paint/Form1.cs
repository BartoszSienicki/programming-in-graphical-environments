namespace Paint
{
    public partial class Form1 : Form
    {
        List<Point> pp = new List<Point>();
        enum Tool { Point, Line, Rect, Ellipse }
        Tool currentTool = Tool.Point;

        List<Rectangle> lines = new List<Rectangle>();
        List<Rectangle> rects = new List<Rectangle>();
        List<Rectangle> ellipses = new List<Rectangle>();

        Point start; 
        Point temp;  
        bool drawing = false;



        public Form1()
        {
            InitializeComponent();
            panel1.BringToFront();
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            pp.Add(new Point(e.X, e.Y));
            panel1.Invalidate(); 
        }

        private void toolStripButtonPoint_Click(object sender, EventArgs e) => currentTool = Tool.Point;
        private void toolStripButtonLine_Click(object sender, EventArgs e) => currentTool = Tool.Line;
        private void toolStripButtonRect_Click(object sender, EventArgs e) => currentTool = Tool.Rect;
        private void toolStripButtonEllipse_Click(object sender, EventArgs e) => currentTool = Tool.Ellipse;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentTool == Tool.Point)
            {
                pp.Add(new Point(e.X, e.Y));
            }
            else
            {
                start = e.Location;
                drawing = true;
            }
            panel1.Invalidate();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                temp = e.Location;
                panel1.Invalidate();
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            Rectangle r = new Rectangle(
                Math.Min(start.X, e.X),
                Math.Min(start.Y, e.Y),
                Math.Abs(start.X - e.X),
                Math.Abs(start.Y - e.Y)
            );

            switch (currentTool)
            {
                case Tool.Line:
                    lines.Add(r);
                    break;
                case Tool.Rect:
                    rects.Add(r);
                    break;
                case Tool.Ellipse:
                    ellipses.Add(r);
                    break;
            }

            panel1.Invalidate();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Point p in pp)
                e.Graphics.FillRectangle(Brushes.Black, p.X, p.Y, 2, 2);

            foreach (var l in lines)
                e.Graphics.DrawLine(Pens.Black, l.X, l.Y, l.Right, l.Bottom);

            foreach (var r in rects)
                e.Graphics.DrawRectangle(Pens.Black, r);

            foreach (var el in ellipses)
                e.Graphics.DrawEllipse(Pens.Black, el);

            if (drawing)
            {
                Rectangle r = new Rectangle(
                    Math.Min(start.X, temp.X),
                    Math.Min(start.Y, temp.Y),
                    Math.Abs(start.X - temp.X),
                    Math.Abs(start.Y - temp.Y)
                );

                switch (currentTool)
                {
                    case Tool.Line:
                        e.Graphics.DrawLine(Pens.Gray, start, temp);
                        break;
                    case Tool.Rect:
                        e.Graphics.DrawRectangle(Pens.Gray, r);
                        break;
                    case Tool.Ellipse:
                        e.Graphics.DrawEllipse(Pens.Gray, r);
                        break;
                }
            }
        }
        Pen currentPen = new Pen(Color.Black, 2);
        SolidBrush currentBrush = new SolidBrush(Color.LightBlue);
        private void btnPenColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentPen = new Pen(colorDialog1.Color, currentPen.Width);
                btnPenColor.Invalidate();
            }
        }

        private void btnBrushColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentBrush = new SolidBrush(colorDialog1.Color);
                btnBrushColor.Invalidate();
            }
        }
        private void btnPenColor_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(2, 2, btnPenColor.Width - 4, btnPenColor.Height - 4);
            using (Brush b = new SolidBrush(currentPen.Color))
            {
                e.Graphics.FillRectangle(b, r);
                e.Graphics.DrawRectangle(Pens.Black, r);
            }
        }

        private void btnBrushColor_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(2, 2, btnBrushColor.Width - 4, btnBrushColor.Height - 4);
            e.Graphics.FillRectangle(currentBrush, r);
            e.Graphics.DrawRectangle(Pens.Black, r);
        }
        private void comboBoxPenWidth_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(comboBoxPenWidth.Text, out float width))
            {
                currentPen.Width = width;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
