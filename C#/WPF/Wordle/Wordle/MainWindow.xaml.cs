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

namespace Wordle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    struct places
    {
        List<int> index;

    }
    public partial class MainWindow : Window
    {
        string Word_Find { get; set; }
        string Word_User { get; set; } = string.Empty;
        int row { get; set; } = 0;
        int column { get; set; } = 0;
        List<string> words = new List<string>();
        struct Letter
        {
            public char letterChar;
            public int count = 0;
            public List<int> indexes = new();
           public Letter(string word, char letter)
            {
                letterChar = letter;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter)
                    {
                        count++;
                        indexes.Add(i);
                    }
                }
            }
            
        
        }
        public MainWindow()
        {
            using (StreamReader reader = new StreamReader("words.txt"))
            {
                string putin = string.Empty;
                while ((putin = reader.ReadLine()) != null)
                {
                    words.Add(putin);

                }
            }
            Word_Find = RandomWord();
            InitializeComponent();         
           


        }
        private void CheckWord()
        {
            List<char> checked_chars = new();
            for (int i = 0; i < 5; i++)
            {
                Letter letter = new Letter(Word_Find, Word_Find[i]);
                Letter letter2 = new Letter(Word_Find, Word_User[i]);
                int length = 0;
                if (checked_chars.Contains(letter2.letterChar))
                {
                    continue;
                }
                if (letter.count>letter2.count)
                {
                    length = letter2.count;
                }
                else
                {
                    length = letter.count;
                }
                for (int j = 0; j < length; j++)
                {
                    if (letter.indexes[j]  == letter2.indexes[j]  )
                    {
                        InputFieldColorChange(column, i, Brushes.Green, Brushes.White);
                    }
                    else
                    {
                        InputFieldColorChange(column, i, Brushes.Yellow, Brushes.White);
                    }
                    char? temp = letter2.letterChar;
                    KeyBoardColorChange(temp, Brushes.Green);
                    
                }
               KeyBoardColorChange(InputFieldColorChange(column, i, Brushes.Red, Brushes.White), Brushes.Gray);
            }
        }
        string  RandomWord()
        {
            Random random = new Random();
            int index = random.Next(words.Count-1);
            return words[index];
        }
        private char? InputFieldColorChange(int column, int row, Brush color, Brush  only)
        {
            if (((Input_Field.Children[column] as StackPanel).Children[row] as Border).Background == only)
            {
                ((Input_Field.Children[column] as StackPanel).Children[row] as Border).Background = color;
                return (((Input_Field.Children[column] as StackPanel).Children[row] as Border).Child as TextBlock).Text.ToString().ToLower()[0];
            }
            return null;
        }
        private void KeyBoardColorChange(char? letter, Brush color)
        {
            if(letter == null)
            {
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                int j_len = 10;
                if (i == 3)
                {
                    j_len = 4;
                }
                for (int j = 0; j < j_len; j++)
                {
                    char temp = ((Keyboard.Children[i] as StackPanel).Children[j] as Button).Content.ToString().ToLower()[0];
                    if (temp == letter)
                    {
                        ((Keyboard.Children[i] as StackPanel).Children[j] as Button).Background = color;
                    }
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Enter_text.IsEnabled == true)
            {
                return;
            }
           (((Input_Field.Children[column] as StackPanel).Children[row] as Border ).Child as TextBlock).Text = (string)(sender as Button).Content.ToString();
            
            Word_User += (string)(sender as Button).Content.ToString().ToLower();
            row++;
            if (row == 5)
            {
                Enter_text.IsEnabled = true;
            }
            else
            {
                Enter_text.IsEnabled = false;
            }
            if (row > 0)
            {
                Delete_text.IsEnabled = true;
            }
            else
            {
                Delete_text.IsEnabled = false;
            }
            
        }

        private void Delete_text_Click(object sender, RoutedEventArgs e)
        {
            row--;
            (((Input_Field.Children[column] as StackPanel).Children[row] as Border).Child as TextBlock).Text = string.Empty;
            Word_User = Word_User.Remove(Word_User.Length-1);
            if (row == 5)
            {
                Enter_text.IsEnabled = true;
            }
            else
            {
                Enter_text.IsEnabled = false;
            }
            if (row > 0)
            {
                Delete_text.IsEnabled = true;
            }
            else
            {
                Delete_text.IsEnabled = false;
            }
        }

        private void Enter_text_Click(object sender, RoutedEventArgs e)
        {
            if (words.Contains(Word_User) == false)
            {
                MessageBox.Show("Такого слова нет в словаре попробуйте например - "+ RandomWord(), "Wordle", MessageBoxButton.OK);
                return;
            }
            CheckWord();
            column++;
            row = 0;
            if (Word_User == Word_Find)
            {
                MessageBox.Show("Вы Победили, поздравляю!", "Wordle", MessageBoxButton.OK);
                window.Close();
            }
            else if (column == 6)
            {
                MessageBox.Show("Вы проиграли искомое слово было - " + Word_Find,"Wordle",MessageBoxButton.OK);
                window.Close();
            }
            Word_User = string.Empty;
            if (row == 5)
            {
                Enter_text.IsEnabled = true;
            }
            else
            {
                Enter_text.IsEnabled = false;
            }
            if (row > 0)
            {
                Delete_text.IsEnabled = true;
            }
            else
            {
                Delete_text.IsEnabled = false;
            }
          
        }
    }
}
