using QLPhongKhamTuNhan.GUI.UIAdmin;
using QLPhongKhamTuNhan.GUI.UIDoctor;
using QLPhongKhamTuNhan.GUI.UIReceptionist;
using QLPhongKhamTuNhan.GUI.UIReport;
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

namespace QLPhongKhamTuNhan.GUI.UIGeneral
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Home();
        }

        private void btnMyAccount_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MyAccount();
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Dashboard();
        }

        private void btnMakeListPatientMenu_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MakeListPatient();
        }

        private void btnListPatientMenu_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ListOfPatient();
        }

        private void btnTurnOverMenu_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Turnover();
        }

        private void btnMedicineMenu_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Medicine();
        }

        private void btnRegulationMenu_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Regulation();
        }

        private void btnUserMenu_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new UserManagement();
        }
    }
}
