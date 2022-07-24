using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Security.Cryptography;
using System.Runtime.Serialization.Json;
using ViktorinaProjectUser;

namespace ViktorinaProjectUser
{
     class RegistrationAndSignin:Application
    {
        public delegate int Params(string argm);
        public delegate void Message(int argm);
        User user { get; set; } = new();
        bool seek = false;

        private int LoginChecker(string login)
        {
            int error = 0x000;
            if (!IsDigitOrLetter(login))
            {
                error |= 0x100;
            }
            if (login.Length < 6)
            {
                error |= 0x010;
            }
            if (login.Length > 18)
            {
                error |= 0x001;
            }
                return error;

        }
        public void LoginMessage(int error_code)
        {
            int error = 0x000;

            int line = 0;
            if ((error_code & 0x100) != 0)
            {
                Console.WriteLine("Логин может содержать толко буквы и цифры");
                line = Console.CursorTop;

            }
            else
            {
                Console.WriteLine();
                ClearLine(2);
            }
            if ((error_code & 0x010) != 0)
            {
                Console.WriteLine("Логин должен быть больше 6 символов");
                line = Console.CursorTop;
            }
            else
            {
                Console.WriteLine();
                ClearLine(3);
            }
            if ((error_code & 0x001) != 0)
            {
                Console.WriteLine("Логин должен быть меньше 18 символов");
                line = Console.CursorTop;
            }
            else
            {
                Console.WriteLine();
                ClearLine(4);
            }

        }
        bool HasUpper(string txt)
        {
            char[] txt_arr = txt.ToCharArray();
            foreach (char item in txt_arr)
            {
                if (char.IsUpper(item))
                {
                    return true;
                }
                
            }
            return false;
        }
        bool HasDigit(string txt)
        {
            char[] txt_arr = txt.ToCharArray();
            foreach (char item in txt_arr)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }

            }
            return false;
        }
        bool HasLower(string txt)
        {
            char[] txt_arr = txt.ToCharArray();
            foreach (char item in txt_arr)
            {
                if (char.IsLower(item))
                {
                    return true;
                }

            }
            return false;
        }
        bool HasLetter(string txt)
        {
            char[] txt_arr = txt.ToCharArray();
            foreach (char item in txt_arr)
            {
                if (char.IsLetter(item))
                {
                    return true;
                }

            }
            return false;
        }
        bool IsDigitOrLetter(string txt)
        {
            char[] txt_arr = txt.ToCharArray();
            foreach (char item in txt_arr)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }

            }
            return true;
        }

        private int PasswordChecker(string password)
        {
            int error = 0x0000;
            if (!HasDigit(password))
            {
                error |= 0x100000;
            }
            if (!HasLetter(password))
            {
                error |= 0x010000;
            }
            if (!HasLower(password))
            {
                error |= 0x001000;
            }
            if (!HasUpper(password))
            {
                error |= 0x000100;
            }
            if(password.Length < 6)
            {
                error |= 0x000010;
            }
            if (password.Length > 18)
            {
                error |= 0x000001;
            }

            return error;


        }
        private void PassErrorMessage(int error_code)
        {
            int line = 0;
            if ((error_code & 0x100000) != 0)
            {
                Console.WriteLine("Пароль должен содержать цифры!");
                line = Console.CursorTop;
                
            }
            else {
                Console.WriteLine();
                ClearLine(2);
            }
            if ((error_code & 0x010000) != 0)
            {
                Console.WriteLine("Пароль должен содержать буквы!");
                line = Console.CursorTop;
            }
            else
            {
                Console.WriteLine();
                ClearLine(3);
            }
            if ((error_code & 0x001000) != 0)
            {
                Console.WriteLine("Пароль должен содержать маленькие буквы!");
                line = Console.CursorTop;
            }

            else
            {
                Console.WriteLine();
                ClearLine(4);
            }

            if ((error_code & 0x000100) != 0)
            {
                Console.WriteLine("Пароль должен содержать заглавные буквы!");
                line = Console.CursorTop;
            }
            else
            {
                Console.WriteLine();
                ClearLine(5);
            }
            if ((error_code & 0x000010) != 0)
            {
                Console.WriteLine("Пароль должен содержать не менее 6 символов!");
                line = Console.CursorTop;
            }
            else
            {
                Console.WriteLine();
                ClearLine(6);
            }
            if ((error_code & 0x000001) != 0)
            {
                Console.WriteLine("Пароль должен содержать не более 18 символов!");
                line = Console.CursorTop;
            }
            else
            {
                Console.WriteLine();
                ClearLine(7);
            }
        }
        void ClearLine(int line)
        {
            Console.MoveBufferArea(0, line, Console.BufferWidth, 1, Console.BufferWidth, line, ' ', Console.ForegroundColor, Console.BackgroundColor);
        }
        private void ConsolePop(int numb, bool del = true)
        {
            if (numb == 0) return;
            for (int i = 0; i < numb; i++)
            {
                if (del)
                Console.Write('\b');
                Console.Write(' ');
                Console.Write('\b');
            }
           
        }
        private string KeyInputAction(ref ConsoleKeyInfo key, string temp, ref bool seek, bool pass = false)
        {
            key = Console.ReadKey(seek);
            if (key.Key.Equals(ConsoleKey.S) && key.Modifiers.Equals(ConsoleModifiers.Control) && pass == true)
            {
                if (temp.Length == 0)
                {
                    ConsolePop(1);
                }
                else if (!seek)
                {
                    seek = true;
                    ConsolePop(1);
                    SeekPass(temp);
                }
                else
                {
                    seek = false;
                    ShowPass(temp);
                }
            }
            else if (key.Key.Equals(ConsoleKey.Backspace) && !key.Modifiers.Equals(ConsoleModifiers.Control))
            {
                if (temp.Length > 0)
                {
                    ConsolePop(1, seek);
                    temp = temp.Remove(temp.Length - 1);
                }
                else if (!seek)
                {
                    Console.Write(' ');
                }
            }
            else if (!key.Key.Equals(ConsoleKey.Enter))
            {
                if (key.Modifiers.Equals(ConsoleModifiers.Control))
                {
                    return temp;
                }
                temp += key.KeyChar;
                if (seek == true)
                {

                    Console.Write('*');
                }
            }
            return temp;

        }
        private string PassAndLoginInput(string Message, Params checker_param = null, Message error_message = null,bool pass = false)
        {
            
            int error_code = -1;
            string temp = string.Empty;
            int _left = 0;
            while (error_code != 0)
            {
                
                ConsoleKeyInfo key = default(ConsoleKeyInfo);
                Console.Write(Message);
                temp = string.Empty;
                while (!key.Key.Equals(ConsoleKey.Enter))
                {

                    
                    temp = KeyInputAction(ref key, temp, ref seek ,pass);
                    int left = Console.CursorLeft;
                    if (!key.Key.Equals(ConsoleKey.Enter))
                    {
                        _left = left;
                    }
                    if (checker_param != null)
                    {
                        error_code = checker_param(temp);
                        Console.WriteLine('\n');
                        error_message(error_code);
                    }
                    else
                    {
                        error_code = 0;
                    }

                    Console.SetCursorPosition(left,0);
                    
                }
                if (error_code != 0)
                {
                    Console.SetCursorPosition(_left, 0);
                    this.ConsolePop(temp.Length);
                }
                Console.SetCursorPosition(0, 0);
            }
            Console.Clear();
            return temp;
        }
        private void SeekPass(string pass)
        {
            ConsolePop(pass.Length);
            for (int i = 0; i < pass.Length; i++)
            {
                Console.Write('*'); ;
            }
        }
        private void ShowPass(string pass)
        {
            ConsolePop(pass.Length);
            Console.Write(pass);
        }
        private void SeekPass(int len)
        {
            ConsolePop(len);
            for (int i = 0; i < len; i++)
            {
                Console.Write('*'); ;
            }
        }
        public void Registration()
        {

            Accounts_Base accounts_Base = new();
            Params Pass_Param = this.PasswordChecker, Login_Param = this.LoginChecker;
            Message Pass_Message = this.PassErrorMessage, Login_Message = this.LoginMessage;

            
            do
            {

                user.Login = PassAndLoginInput("Введите логин: ", Login_Param, Login_Message);
                if (!Accounts_Base.Check(user.Login))
                {
                    Console.WriteLine("Такой логин уже существует, выберите другой!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            while (!Accounts_Base.Check(user.Login));
            user.Password = PassAndLoginInput("Введите пароль: ", Pass_Param, Pass_Message, true);
            Console.WriteLine("Вы успешно зарегистрировались!");
            accounts_Base.Add(user.Login, user);



        }
        public void Signin()
        {

            Accounts_Base accounts_Base = new();
            do
            {
                user.Login = PassAndLoginInput("Введите логин: ");
                if (Accounts_Base.Check(user.Login))
                {
                    Console.WriteLine("Такого логина не существует, проверьте логин на верность или же заругистрируйтесь!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            while (Accounts_Base.Check(user.Login));
            Accounts_Base.Accounts.TryGetValue(user.Login,out User value);

            do
            {
                user.Password = PassAndLoginInput("Введите пароль: ");
                if (user.Password!=value.Password)
                {
                    Console.WriteLine("Неверный пароль!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            while (user.Password!=value.Password);


        }

        public RegistrationAndSignin()
        {
            
        }    
    }



    class Accounts_Base
    {
        static string path = @"C:\HomeWork\ViktorinaProject\ViktorinaProject\Accounts.json";
        static public Dictionary<string, User>? Accounts;
        public Accounts_Base()
        {
           Get();
        }
        static public bool Check(string arg)
        {
            if (Accounts != null)
            {
                foreach (var key in Accounts.Keys)
                {
                    if (key.Equals(arg)) { return false; }
                }
            }
            return true;
          

        }
        public bool Add(string key, User arg)
        {
            if (Accounts == null)
            {
                Accounts = new();
            }
            Accounts.Add(key, arg);
            using (FileStream file = new(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<Dictionary<string, User>>(file, Accounts);
                return true;    
            }
            return false;
        }
        public static long[] Encrypt(string arg)
        {
            long[] args2 = new long[arg.Length];
            for (int i = 0; i < args2.Length; i++)
            {
                args2[i] = arg[i];
            }
            for (int i = 1; i < arg.Length + 1; i++)
            {
                args2[i - 1] <<= i;
            }
            return args2;
        }
        public static long[] Decrypt(long[] arg)
        {
            for (int i = 1; i < arg.Length + 1; i++)
            {
                arg[i - 1] >>= i;
            }
            return arg;
        }
        public static string DecryptToString(long[] arg)
        {
            char[] chars = new char[arg.Length];
            for (int i = 0; i < arg.Length; i++)
            {
                chars[i] = (char)arg[i];
            }
            return new string(chars);
        }
        public static long[] StringToDecrypt(string arg)
        {
            long[] chars = new long[arg.Length];
            for (int i = 0; i < arg.Length; i++)
            {
                chars[i] = arg[i];
            }
            return chars;
        }
        public static string Decrypt(string key)
        {
            long[] ___key = Accounts_Base.Encrypt(key);
            string[] __key = Accounts_Base.LongArrayToStringArray(___key);
            string _key = Accounts_Base.StringArrayOfLongsToString(__key);
            return _key;
        }



        static public  void Get()
        {
            
            using (FileStream file = new(path, FileMode.OpenOrCreate))
            {
                Accounts = JsonSerializer.Deserialize<Dictionary<string, User>>(file);
                
            }
        }
        public static string StringArrayOfLongsToString(string[] arg)
        {
            string temp = string.Empty;
            for (int i = 0; i < arg.Length; i++)
            {
                temp+=arg[i];
                if (i != arg.Length - 1)
                {
                    temp += " ";
                }
            }
            return temp;
        }
        public static string[] StringToStringArrayOfLongs(string arg)
        {
            int length = 0;
            foreach (var item in arg)
            {
                if (item == ' ')
                {
                    length++;
                }

            }
            string []temp = new string[length+1];
            int i = 0;
            int j = 0;
            string _temp = string.Empty;
           while(j< arg.Length)
            {
                if (arg[j] == ' ')
                {
                    j++;
                    i++;
                }
                temp[i] += arg[j++].ToString();
                
            }
            return temp;
        }
        public static long[] StringArrayToLongArray(string[] arg)
        {
            long[] temp = new long[arg.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = long.Parse(arg[i]);
            }
            return temp;
        }
        public static string[] LongArrayToStringArray(long[] arg)
        {
            string[] temp = new string[arg.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = arg[i].ToString();
            }
            return temp;
        }
        public static string Encrypt_Str(string key)
        {
                string[] ___key = Accounts_Base.StringToStringArrayOfLongs(key);
                long[] __key = Accounts_Base.StringArrayToLongArray(___key);
                Accounts_Base.Decrypt(__key);
                return DecryptToString(__key);
        }
    }
}
