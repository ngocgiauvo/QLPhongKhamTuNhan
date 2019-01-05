using QLPhongKhamTuNhan.BUS;
using QLPhongKhamTuNhan.DTO;
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
        User currentUser = new User();
        public MainWindow()
        {
            InitializeComponent();
            currentUser = (User)Application.Current.Properties["UserInfo"];

            UserBUS uBus = new UserBUS();
            List<int> listFunc = uBus.getRoleFunction(currentUser.role_id);
            setRold(listFunc);
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

        void setRold(List<int> listFunc)
        {
            if (!listFunc.Contains(Convert.ToInt32(btnDashboard.Tag)))
            {
                btnDashboard.Visibility = Visibility.Collapsed;
            }
            if (!listFunc.Contains(Convert.ToInt32(btnListPatientMenu.Tag)))
            {
                btnListPatientMenu.Visibility = Visibility.Collapsed;
            }
            if (!listFunc.Contains(Convert.ToInt32(btnMakeListPatientMenu.Tag)))
            {
                btnMakeListPatientMenu.Visibility = Visibility.Collapsed;
            }
            if (!listFunc.Contains(Convert.ToInt32(btnMedicineMenu.Tag)))
            {
                btnMedicineMenu.Visibility = Visibility.Collapsed;
            }
            if (!listFunc.Contains(Convert.ToInt32(btnRegulationMenu.Tag)))
            {
                btnRegulationMenu.Visibility = Visibility.Collapsed;
            }
            if (!listFunc.Contains(Convert.ToInt32(btnTurnOverMenu.Tag)))
            {
                btnTurnOverMenu.Visibility = Visibility.Collapsed;
            }
            if (!listFunc.Contains(Convert.ToInt32(btnUserMenu.Tag)))
            {
                btnUserMenu.Visibility = Visibility.Collapsed;
            }
        }
    }
}
