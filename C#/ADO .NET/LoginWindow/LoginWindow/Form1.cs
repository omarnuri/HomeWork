using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace LoginWindow
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();




        }
        string connstring = "Data Source=localhost;Initial Catalog=Accounts;Integrated Security=True";

        private void loginButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(connstring);
            conn.Open();
            string commstring = $"SELECT COUNT(*) FROM Users WHERE [Password] LIKE N\'{passwordTextBox.Text}\' AND [Login] LIKE N\'{loginTextBox.Text}\' GROUP BY [Login]";
            Clipboard.SetText(commstring);
            SqlCommand cmd = new SqlCommand(commstring, conn);

            object reader = cmd.ExecuteScalar();
            string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley";
            if (Convert.ToInt32(reader) != 1)
            {
                messageLabel.Text = "Пароль или логин введены неправильно";
            }
            else if(Convert.ToInt32(reader) == 1)
            {
                messageLabel.Text = String.Empty;
                try
                {
                    Process.Start(url);
                }
                catch
                {
                    // hack because of this: https://github.com/dotnet/corefx/issues/10361
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        url = url.Replace("&", "^&");
                        Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        Process.Start("xdg-open", url);
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        Process.Start("open", url);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            conn.Close();

        }
    }
}