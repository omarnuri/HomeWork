using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using Forms = System.Windows.Forms;
using Media = System.Windows.Media;
using Drawing = System.Drawing;

namespace TextRedactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.FontStyle? DrawFontToWinFont(Drawing.FontStyle fontStyle)
        {
            switch (fontStyle)
            {
                case Drawing.FontStyle.Regular:
                    return System.Windows.FontStyles.Normal;
                case Drawing.FontStyle.Bold:
                    return System.Windows.FontStyles.Oblique;
                case Drawing.FontStyle.Italic:
                    return System.Windows.FontStyles.Italic;
                default:
                    return null;
            }
        }
        string FileName { get; set; } = string.Empty;
        public MainWindow()
        {
            InitializeComponent();


        }
        private void Save(string? path = null)
        {
            if (path == null)
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File (*.txt)|*.txt";
                saveFileDialog.FileName = "Безымянный Файл.txt";
                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, Text.Text);
                }
            }
            else
            {

                File.WriteAllText(path, Text.Text);

            }
        }
        private bool SaveD()
        {
            MessageBoxResult result = MessageBox.Show("Сохранить файл?", "Блокнот", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                if (FileName == String.Empty)
                {
                    Save();
                }
                else
                {
                    Save(FileName);
                }
            }
            else if (result == MessageBoxResult.Cancel)
            {
                return true;
            }
            return false;
        }

       


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((FileName != String.Empty && Text.Text != File.ReadAllText(FileName)) || (FileName == String.Empty && Text.Text != String.Empty))
            {

                if (SaveD() == false)
                {
                    return;
                }
                else
                {
                    e.Cancel = true;
                }

            }
        }
        private void MenuSave_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveD();
        }
        private void MenuNew_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if ((Text.Text != string.Empty && FileName == String.Empty) || (FileName != String.Empty && Text.Text != File.ReadAllText(FileName)))
            {

                if (SaveD() == true)
                {
                    return;
                }
            }
            Text.Text = string.Empty;
            FileName = String.Empty;
            Window.Title = "Без Имени - Блокнот";
        }
        private void MenuAbout_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            About_Window win = new About_Window();
            win.Show();
        }
        private void MenuColor_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            {
                Forms.ColorDialog colorDialog = new();
                colorDialog.ShowDialog();
                Media.BrushConverter converter = new();
                string sRGB = new($"#{colorDialog.Color.R:X2}{colorDialog.Color.G:X2}{colorDialog.Color.B:X2}");
                Text.Foreground = converter.ConvertFromString(sRGB) as Media.Brush;
            }
        }
        private void MenuWordWrap_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (Text.TextWrapping == TextWrapping.Wrap)
            {
                Text.TextWrapping = TextWrapping.NoWrap;
            }
            else
            {
                Text.TextWrapping = TextWrapping.Wrap;
            }
        }
        private void MenuFont_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Forms.FontDialog fontDialog = new();
            fontDialog.ShowDialog();
            Text.FontSize = fontDialog.Font.Size;
            Drawing.Font font = fontDialog.Font;
            Media.FontFamily fontFamily = new(font.FontFamily.Name);
            Text.FontFamily = fontFamily;
            if (DrawFontToWinFont(fontDialog.Font.Style) != null)
            {
                Text.FontStyle = (FontStyle)DrawFontToWinFont(fontDialog.Font.Style);
            }

        }
        private void MenuExit_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Window.Close();
        }
        private void MenuPrint_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }
        private void MenuOpen_CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {

                Text.Text = File.ReadAllText(openFileDialog.FileName);
                FileName = openFileDialog.FileName;
                Window.Title = FileName;
            }

        }
        private void MenuHotKeys_CommandBinding_Executed(object ssender, ExecutedRoutedEventArgs e)
        {
            HotKeys_ModalWin modalWin = new();
            modalWin.ShowDialog();
        }
    }
    }
