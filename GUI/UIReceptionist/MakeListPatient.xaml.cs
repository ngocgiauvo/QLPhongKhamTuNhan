using QLPhongKhamTuNhan.BUS;
using QLPhongKhamTuNhan.DTO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QLPhongKhamTuNhan.GUI.UIReceptionist
{
    /// <summary>
    /// Interaction logic for MakeListPatient.xaml
    /// </summary>
    public partial class MakeListPatient : Page
    {
        PatientBUS patientBUS = new PatientBUS();

        public MakeListPatient()
        {
            InitializeComponent();

            currentDay.Text = DateTime.Today.ToShortDateString();
            DataContext = patientBUS.getListPatient();
        }

        private void btnCreatePatient_Click(object sender, RoutedEventArgs e)
        {
            CreatePatient createPatient = new CreatePatient(null);
            createPatient.ShowDialog();
            
            DataContext = patientBUS.getListPatient();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Patient p = patientDataGrid.SelectedItem as Patient;

            CreatePatient createPatient = new CreatePatient(p);
            createPatient.ShowDialog();

            DataContext = patientBUS.getListPatient();
        }
    }
}
