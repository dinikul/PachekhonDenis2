using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MyLaba2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Piano piano = new Piano();
            piano.Customize_the_Piano();
            piano.Play_the_Piano();
        }
    }
    class Piano
    {
        public Button button;
        public Pedal pedal;
        public Piano()
        {
            button = new Button();
            pedal = new Pedal();
        }
        public void Customize_the_Piano()
        {
            Console.WriteLine("customize the piano");
            var customize = Console.ReadLine();
            if (customize == "customize")
            {
                Console.WriteLine("The piano is tuned");
            }
            else
            {
                Console.WriteLine("The piano is not configured");
            }
        }
        public void Play_the_Piano()
        {
            while (button.status)
            {
                if (Console.KeyAvailable == true)
                {
                    var keyInfo = Console.ReadKey();
                    button.Pressing_a_Key(keyInfo);
                    pedal.Pressing_the_Pedal(keyInfo);
                }
                
            }
        }
    }
    class Button
    {
        public bool status = true;
        public SoundPlayer DO;
        public SoundPlayer RE;
        public SoundPlayer MI;
        public SoundPlayer FA;
        public SoundPlayer SOL;
        public SoundPlayer LIA;
        public SoundPlayer SI;
        public void Pressing_a_Key(ConsoleKeyInfo keyInfo)
        {
          
            if (keyInfo.Key == ConsoleKey.Q)
            {
                
                DO = new SoundPlayer(@"C:\Users\Home\Downloads\noty-do.wav");
                DO.Play();
                Console.Clear();
                
            }
            if (keyInfo.Key == ConsoleKey.W)
            {
                RE = new SoundPlayer(@"C:\Users\Home\Downloads\re.wav");
                RE.Play();
                Console.Clear();
            }
            if (keyInfo.Key == ConsoleKey.E)
            {
                MI = new SoundPlayer(@"C:\Users\Home\Downloads\mi (online-audio-converter.com).wav");
                MI.Play();
                Console.Clear();
            }
            if (keyInfo.Key == ConsoleKey.R)
            {
                FA = new SoundPlayer(@"C:\Users\Home\Downloads\fa (online-audio-converter.com).wav");
                FA.Play();
                Console.Clear();
            }
            if (keyInfo.Key == ConsoleKey.T)
            {
                SOL = new SoundPlayer(@"C:\Users\Home\Downloads\sol (online-audio-converter.com).wav");
                SOL.Play();
                Console.Clear();
            }
            if (keyInfo.Key == ConsoleKey.Y)
            {
                LIA = new SoundPlayer(@"C:\Users\Home\Downloads\lja (online-audio-converter.com).wav");
                LIA.Play();
                Console.Clear();
            }
            if (keyInfo.Key == ConsoleKey.U)
            {
                SI = new SoundPlayer(@"C:\Users\Home\Downloads\si (online-audio-converter.com).wav");
                SI.Play();
                Console.Clear();
            }
            if (keyInfo.Key == ConsoleKey.I)
            {
                status = false;
            }
        }
    }
    class Pedal
    {
        public string right_pedal = "пiдняття всiх демпфер";
        public string left_pedal = "послаблення звуку";
        public string middle_pedal = "затримка обраних демпферiв у пiднятому станi";
        public void Pressing_the_Pedal(ConsoleKeyInfo keyInfo)
        {

            if (keyInfo.Key == ConsoleKey.G)
            {
                Console.WriteLine(right_pedal);
            }

            if (keyInfo.Key == ConsoleKey.F)
            {
                Console.WriteLine(middle_pedal);
            }

            if (keyInfo.Key == ConsoleKey.D)
            {
                Console.WriteLine(left_pedal);
            }
        }
    }
}
