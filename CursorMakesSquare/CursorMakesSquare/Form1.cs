namespace CursorMakesSquare
{
    public partial class Form1 : Form
    {
        Point point1;
        Point point2;
        private class Static : Form
        {

            public static int NumberOfStatic { get; set; } = 0;
            public Point point1 { get; set; }
            public Point point2 { get; set; }
            private int Width { get { return Width; }set { Width = value; }  }
            public int width { 
                get
                {
                    Point point1 = this.point1;
                    Point point2 = this.point2;
                    if (point1.X > point2.X)
                    {
                        point2.X += point1.X;
                        point1.X = point2.X - point1.X;
                        point2.X -= point1.X;
                    }
                    return point2.X - point1.X; ;
                } 
            }
            public int length
            {
                get
                {
                    Point point1 = this.point1;
                    Point point2 = this.point2;
                    if (point1.Y > point2.Y)
                    {
                        point2.Y += point1.Y;
                        point1.Y = point2.Y - point1.Y;
                        point2.Y -= point1.Y;
                    }
                    return point2.Y - point1.Y;
                }
            }

            public Static(Point point1, Point point2)
            {
               this.point1 = point1;
               this.point2 = point2;
                NumberOfStatic++;
            }
            public PictureBox Draw()
            {
                
                
                
                if (width < 10 || length < 10)
                {
                    NumberOfStatic--;
                    return null;
                }
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Black;
                pictureBox.Location = new Point(point1.X, point1.Y);
                pictureBox.Size = new Size(width, length);
                return pictureBox;
            }

        }
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form_MouseDown1(object sender, MouseEventArgs e)
        {
           point1 = e.Location;
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            
            point2 = e.Location;
            Static? stat = new(point1, point2);
            PictureBox? elem = stat.Draw();
            if (elem != null)
            {
                this.Controls.Add(elem);
                Counter.Text = Static.NumberOfStatic.ToString();
            }
            else
            {
                
                MessageBox.Show(" вадрат должен быть не меньше 10x10!", "ќшибка!");
            }
            

        }

        
    }
}