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
using System.Windows.Shapes;

namespace pr_14_teselko_01._01
{
    /// <summary>
    /// Логика взаимодействия для Password.xaml
    /// </summary>
    public partial class Password : Window
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            inputPass.Focus();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if(inputPass.Password == "123")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль", "Ошибка");
                inputPass.Focus();
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Owner.Close();
        }
    }
}
