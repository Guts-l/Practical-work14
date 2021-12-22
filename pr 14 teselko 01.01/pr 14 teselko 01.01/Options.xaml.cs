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
    /// Логика взаимодействия для Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            currentRowCount.Text = OptionsData.RowCount.ToString();
            currentColumnCount.Text = OptionsData.ColumnCount.ToString();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OptionsData.RowCount = Int32.Parse(newRowCount.Text);
                OptionsData.ColumnCount = Int32.Parse(newColumnCount.Text);
                Close();
            }
            catch
            {
                MessageBox.Show("Проверьте введенные значения", "Ошибка");
            }
        }

        private void canel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
