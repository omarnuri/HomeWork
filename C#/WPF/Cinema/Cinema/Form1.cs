namespace Cinema
{
    public partial class Form1 : Form
    {
        public List<int> SelectedPlaces = new();
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void FilmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }
    }
}