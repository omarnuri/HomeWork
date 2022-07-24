using System.ComponentModel;
namespace DoDoLis
{
   
    public partial class Form1 : Form
    {
        class Tasks
        {
            public string Text { get; set; }
            public DateTime Date { get; set; }
            public override string ToString()
            {
                return $"{Text} - {Date.ToShortTimeString()}";
            }
        }
        BindingList<Tasks> tasks = new BindingList<Tasks>();
        public Form1()
        {
            InitializeComponent();
            TasksListBox.DataSource = tasks;

        }

        
        private void AddButton_Click(object sender, EventArgs e)
        {
            var task = textBox1.Text;
            tasks.Add(new Tasks { Text = task, Date = DateTime.Now });
            textBox1.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            tasks.RemoveAt(TasksListBox.SelectedIndex);
        }

        private void DeleteAllbutton_Click(object sender, EventArgs e)
        {
            if (tasks.Count > 0)
            {
                tasks.Clear();
            }
            else
            {
                MessageBox.Show("Нечего удалять!", "Ошибка");
               
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            tasks = new BindingList<Tasks>(tasks.OrderBy(x => x.Text).ToList());
            TasksListBox.DataSource = tasks;
        }

        private void TasksListBox_Click(object sender, EventArgs e)
        {
           
        }

        private void TasksListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var lol = sender.GetType().Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tasks = new BindingList<Tasks>(tasks.OrderByDescending(x => x.Text).ToList());
            TasksListBox.DataSource = tasks;
        }
    }

}