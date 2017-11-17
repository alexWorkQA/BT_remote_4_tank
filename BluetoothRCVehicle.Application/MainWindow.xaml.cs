using BluetoothRCVehicle.Application.Models;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using BluetoothRCVehicle.Application.Factory;

namespace BluetoothRCVehicle.Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BluetoothPort bt_Port;
        Vehicle vehicle;

        public MainWindow()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(check_Key_Press);
            KeyUp += new KeyEventHandler(check_Key_UnPress);
            bt_Port = BluetoothPortFactory.getBlutoothPortinstance();
        }

        private void check_Key_UnPress(object sender, KeyEventArgs e)
        {
            if (button_Forward.Content.Equals("Pressed") )
            {
                vehicle.Stop();
                button_Forward.Content = "Forward";
            }

            if (button_Backward.Content.Equals("Pressed"))
            {
                vehicle.Stop();
                button_Backward.Content = "Back";
            }

            if (button_Left.Content.Equals("Pressed"))
            {
                vehicle.Stop();
                button_Left.Content = "Left";
            }

            if (button_Right.Content.Equals("Pressed"))
            {
                vehicle.Stop();
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
                            vehicle.Forward();
                            button_Forward.Content = "Pressed";
                            break;
                        }
                    case "Down":
                        {
                            vehicle.Backward();
                            button_Backward.Content = "Pressed";
                            break;
                        }
                    case "Left":
                        {
                            vehicle.Left();
                            button_Left.Content = "Pressed";
                            break;
                        }
                    case "Right":
                        {
                            vehicle.Right();
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
                    if (tank_RadioButton.IsChecked == true)
                        vehicle = new Tank(bt_Port);
                    else
                        if (car_RadioButton.IsChecked == true)
                        vehicle = new Car(bt_Port);

                    button_Test_Port.Content = "Port Open";
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
