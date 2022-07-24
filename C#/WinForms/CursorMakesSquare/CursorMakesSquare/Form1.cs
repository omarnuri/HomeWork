namespace CursorMakesSquare
{
    public partial class Form1 : Form
    {
        Point point1;
        Point point2;
        private class Static:Form1
        {
            public static List<Static> ArrayOfStatics = new();
            public PictureBox pictureBox { get; set; }
            public static int NumberOfStatic { get; set; } = 0;
            int IndexOfStatic { get; set; }
            public Point point1 { get;}
            public Point point2 { get; }
            public int width { 
                get
                {
                   
                    return point2.X - point1.X; ;
                } 
            }
            public int length
            {
                get
                {
                    return point2.Y - point1.Y;
                }
            }
            public bool IsCreated { get; private set; }

            public Static(Point point1, Point point2)
            {
               if (point1.X > point2.X)
                {
                    point2.X += point1.X;
                    point1.X = point2.X - point1.X;
                    point2.X -= point1.X;
                }
               if (point1.Y > point2.Y)
                {
                    point2.Y += point1.Y;
                    point1.Y = point2.Y - point1.Y;
                    point2.Y -= point1.Y;
                }
               this.point1 = point1;
               this.point2 = point2;
               if (width>10 && length > 10)
                {
                    pictureBox = new();
                    IsCreated = true;
                    IndexOfStatic = NumberOfStatic;
                    NumberOfStatic++;
                    pictureBox.BackColor = Color.Black;
                    pictureBox.Location = new Point(point1.X, point1.Y);
                    pictureBox.Size = new Size(width, length);
                    Static.ArrayOfStatics.Add(this);
                    Static.ArrayOfStatics.Last().pictureBox.DoubleClick += BoxDeleter;
                }
                
            }
            public PictureBox Draw()
            {
              
                return pictureBox;
            }
            public static int CheckStatic(Point point)
            {
                int index = 0;
                List<Static> temp = new();
                foreach (var item in ArrayOfStatics)
                {
                    if(point.X >= item.point1.X&& point.X <= item.point2.X && point.Y >= item.point1.Y && point.Y <= item.point2.Y)
                    {
                        temp.Add(item);
                    }
                }
                if (temp.Count > 0)
                {
                    index = temp[0].IndexOfStatic;
                    foreach (var item in temp)
                    {
                        if (item.IndexOfStatic>index)
                        {
                            index = item.IndexOfStatic;
                        }
                    }
                    return index;
                }
                return -1;
            }

        }
        private void BoxDeleter(object sender, EventArgs e)
        {
            this.Dispose();
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
            if (point1.X != point2.X && point1.Y != point2.Y)
            {
                Static stat = new(point1, point2);
                if (stat.IsCreated != false)
                {
                    this.Controls.Add(stat.Draw());
                    Counter.Text = Static.NumberOfStatic.ToString();
                }
                else
                {

                    MessageBox.Show(" вадрат должен быть не меньше 10x10!", "ќшибка!");
                }
            }

        }

       

    
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
           int index =  Static.CheckStatic(point1);
            if (index != -1)
            {
                this.Controls.RemoveAt(index);
            }

        }

       

    }
}