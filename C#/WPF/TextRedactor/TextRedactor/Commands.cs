using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyCommands
{
     public class Commands
    {
        public static   RoutedUICommand Exit = new RoutedUICommand("", "Exit", typeof(Commands));
        public static RoutedUICommand WordWrap = new RoutedUICommand("", "WordWrap", typeof(Commands));
        public static RoutedUICommand Font = new RoutedUICommand("", "Font", typeof(Commands));
        public static RoutedUICommand Color = new RoutedUICommand("", "Color", typeof(Commands));
        public static RoutedUICommand HotkeysHelp = new RoutedUICommand("", "Help", typeof(Commands));
        public static RoutedUICommand About = new RoutedUICommand("", "About", typeof(Commands));
    }
}
