using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AMONICWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool acces = true;
        int countertries = 0;
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!acces) return;

            if(!Helper.login(Username.Text, Password.Password))
            {
                MessageLabel.Content = "Неверные логил или пароль";
                countertries++;
            }
            else
            {
                MessageLabel.Content = "Успешная авторизация";
            }
            if (countertries == 3) updateTimer();
        }

        async Task updateTimer()
        {
            await Task.Run(async () =>
            {
                Dispatcher.Invoke(() =>
                {
                    acces = false;
                });

                for (int i = 10; i > 0; i--)
                {
                    Dispatcher.Invoke(() =>
                    {
                        MessageLabel.Content = $"Вход заблокирован еще на {i} секунд";
                    });
                    await Task.Delay(1000);
                }

                Dispatcher.Invoke(() =>
                {
                    acces = true;
                    countertries = 0;
                    MessageLabel.Content = $"";
                });
            });
        }






























        //private void b1_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!acces)
        //    {
        //        l1.Content = "Доступ запрещен";
        //        return;
        //    }

        //    if(t1.Text.Length>1 && t1.Text.Length < 20)
        //    {
        //        l1.Content = Helper.returnHashPass(t1.Text);
        //    }
        //    updateTimer();


        //}

        //public async Task updateTimer()
        //{
        //    await Task.Run(async() =>
        //    {
        //        Dispatcher.Invoke(() =>
        //        {
        //            acces = false;
        //        });

        //        for (int i = 5; i > 0; i--)
        //        {
        //            Dispatcher.Invoke(() =>{

        //                l2.Content = $"Доступ запрещен на {i} секунд";
        //            });
        //            await Task.Delay(1000);
        //        }

        //        Dispatcher.Invoke(() =>
        //        {
        //            l2.Content = "";
        //            acces = true;
        //        });


        //    });
        //} 

    }
}


