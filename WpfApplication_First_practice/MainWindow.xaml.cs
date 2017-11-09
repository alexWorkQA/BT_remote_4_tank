using System;
using System.Collections.Generic;
using System.IO.Ports;
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

namespace WpfApplication_First_practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort bt_Port;
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(check_Key_Press);
            this.KeyUp += new KeyEventHandler(check_Key_UnPress);
            bt_Port = new SerialPort();
            bt_Port.BaudRate = 9600;
            bt_Port.PortName = "COM5";
        }

        private void check_Key_UnPress(object sender, KeyEventArgs e)
        {
            if (button_Forward.Content.Equals("Pressed") )
            {
                button_Forward.Content = "Forward";
            }

            if (button_Backward.Content.Equals("Pressed"))
            {
                button_Backward.Content = "Back";
            }

            if (button_Left.Content.Equals("Pressed"))
            {
                button_Left.Content = "Left";
            }

            if (button_Right.Content.Equals("Pressed"))
            {
                button_Right.Content = "Right";
            }
        }


        private void check_Key_Press(object sender, KeyEventArgs e)
        {
            if (e.IsDown)
            {
                switch (e.Key.ToString()) {
                    case "Up":
                        {
                            bt_Port.Write("F");
                            button_Forward.Content = "Pressed";
                            break;
                        }
                    case "Down":
                        {
                            bt_Port.Write("B");
                            button_Backward.Content = "Pressed";
                            break;
                        }
                    case "Left":
                        {
                            bt_Port.Write("L");
                            button_Left.Content = "Pressed";
                            break;
                        }
                    case "Right":
                        {
                            bt_Port.Write("R");
                            button_Right.Content = "Pressed";
                            break;
                        }
                }
            }
        }
        private void button_Test_Port_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton_Open_Port.IsChecked==true)
            {
                if (!bt_Port.IsOpen)
                {
                    bt_Port.Open();
                    button_Test_Port.Content = "Port Open";
                    //test if BT port is opened

                   // int counter = 0;
                    //while (counter<10)
                    //{
                        // WRITE THE INCOMING BUFFER TO CONSOLE
                      //  while (bt_Port.BytesToRead > 0)
                        //{
                           // text4Test.Text = Convert.ToString(bt_Port.ReadChar());
                        //}
                        // SEND
                        //bt_Port.WriteLine("PC counter: " + (counter++));
                    //}

                        button_Test_Port.Background = new SolidColorBrush(Color.FromRgb(1, 254, 1));
                }
            }
            else
            {
                if (radioButton_Close_Port.IsChecked == true)
                {
                    bt_Port.Close();
                    button_Test_Port.Content = "Port Close";
                    button_Test_Port.Background = new SolidColorBrush(Color.FromRgb(254, 1, 1));
                }
            }
        }

     }
}
