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

namespace FifthDay.Windows
{
    /// <summary>
    /// Логика взаимодействия для EndRepairWindow.xaml
    /// </summary>
    public partial class EndRepairWindow : Window
    {
        DB.Entity db = new DB.Entity();

        public EndRepairWindow()
        {
            InitializeComponent();

            lv.ItemsSource = db.Repairs.ToList();

            dpDate.SelectedDate = DateTime.Now;

            SelectCBXPeriod();
        }

        private void SelectCBXPeriod()
        {
            List<string> list = new List<string> { "День", "Неделю", "Месяц", "Год", "Весь период" };
            cbxPeriod.ItemsSource = list;
            cbxPeriod.SelectedIndex = list.Count - 1;
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_Search(object sender, RoutedEventArgs e)
        {
            DateTime dt1 = dpDate.SelectedDate.Value;
            DateTime dt2 = dpDate.SelectedDate.Value.AddDays(1);

            lv.ItemsSource = db.Repairs.Where(w => w.StartDate >= dt1 && w.StartDate < dt2).Except(db.Repairs.Where(w => w.StopDate != null)).ToList();
        }

        private void select_cbxPeriod(object sender, SelectionChangedEventArgs e)
        {
            DateTime helpDate1 = DateTime.Now;
            DateTime helpDate2 = DateTime.Now;

            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    {
                        helpDate1 = DateTime.Now;
                        helpDate2 = DateTime.Now.AddDays(1);
                        break;
                    }
                case 1:
                    {
                        helpDate1 = DateTime.Now.AddDays(-7);
                        helpDate2 = DateTime.Now.AddDays(1);
                        break;
                    }
                case 2:
                    {
                        helpDate1 = DateTime.Now.AddMonths(-1);
                        helpDate2 = DateTime.Now.AddDays(1);
                        break;
                    }
                case 3:
                    {
                        helpDate1 = DateTime.Now.AddYears(-1);
                        helpDate2 = DateTime.Now.AddDays(1);
                        break;
                    }
                case 4:
                    {
                        helpDate1 = new DateTime(0001, 01, 01);
                        helpDate2 = new DateTime(9999, 12, 12);
                        break;
                    }
            }

            lv.ItemsSource = db.Repairs.Where(w => w.StartDate >= helpDate1 && w.StartDate < helpDate2).Except(db.Repairs.Where(w=>w.StopDate != null)).ToList();
        }

        private void click_End(object sender, RoutedEventArgs e)
        {
            if (lv.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите товар!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }

            if ((tbxComment.Text.Length == 0) && (tbxCostRepair.Text.Length == 0) && (tbxGuarantee.Text.Length == 0))
            {
                MessageBox.Show("Введите необходимые данные!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                var repair = (DB.Repairs)lv.SelectedItem;
                repair.Comment = tbxComment.Text;
                repair.Guarantee = int.Parse(tbxGuarantee.Text);
                repair.CostRepair = decimal.Parse(tbxCostRepair.Text);
                repair.StopDate = DateTime.Now;

                db.SaveChanges();
                MessageBox.Show("Гарантийный ремонт окончен!","Perfect",MessageBoxButton.OK,MessageBoxImage.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
