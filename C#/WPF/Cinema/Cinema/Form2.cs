using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form2 : Form
    {

        Button place = new();
        int CountOfPlaces = 24;
        public Form2(IWin32Window owner)
        {
            this.Owner = (Form)owner;
            InitializeComponent();
            SetPlaces();
           

        }
        void SetPlaces()
        {
            for (int i = 1, distance_Y = 125, distance_X = 125, j = 1; i <= CountOfPlaces; i++, j++)
            {
                place = new();
                place.Text = i.ToString();
                place.Name = (i - 1).ToString();
                place.Location = new Point(distance_X, distance_Y);

                if (j % 6 == 0)
                {
                    distance_Y += place.Height;
                    distance_X = 125;
                    j = 0;
                }
                else
                {
                    distance_X += place.Width;
                }
                if (((Form1)this.Owner).SelectedPlaces.Contains(i - 1))
                {
                    place.BackColor = Color.Green;
                }
                Controls.Add(place);
                place.Click += ButtonClickAction;
            }

        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Form2)
            {
                ((Form2)sender).Text = e.X.ToString() + " " + e.Y.ToString();

            }
        }
        private void ButtonClickAction(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (((Button)sender).BackColor == Color.Green)
                {
                    ((Button)sender).BackColor = Color.White;
                    ((Form1)this.Owner).SelectedPlaces.Remove(Convert.ToInt32(((Button)sender).Name));
                }
                else
                {
                    ((Button)sender).BackColor = Color.Green;
                    ((Form1)this.Owner).SelectedPlaces.Add(Convert.ToInt32(((Button)sender).Name));

                }
                info.Text = $"Кол-во мест: {((Form1)this.Owner).SelectedPlaces.Count.ToString()}. Цена: {(((Form1)this.Owner).SelectedPlaces.Count * 5).ToString()}";
            }
        }

    }
}
