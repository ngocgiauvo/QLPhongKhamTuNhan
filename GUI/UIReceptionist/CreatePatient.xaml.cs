using QLPhongKhamTuNhan.BUS;
using QLPhongKhamTuNhan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QLPhongKhamTuNhan.GUI.UIReceptionist
{
    /// <summary>
    /// Interaction logic for CreatePatient.xaml
    /// </summary>
    public partial class CreatePatient : Window
    {
        public CreatePatient(Patient p)
        {
            InitializeComponent();
            if (p == null)
            {
                btnEdit.Visibility = Visibility.Hidden;
            }
            else
            {
                btnCreate.Visibility = Visibility.Hidden;
                DataContext = p;
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Patient p = new Patient();
            p.name = txtHoTen.Text;
            p.sex = cboGioiTinh.SelectedIndex;
            p.yob = Convert.ToInt32(txtNamSinh.Text);
            p.address = txtDiaChi.Text;

            PatientBUS patientBUS = new PatientBUS();

            try
            {
                int id = patientBUS.insertPatient(p);
                MessageBox.Show("Them benh nhan thanh cong");
                Close();
            }
            catch
            {
                MessageBox.Show("Them benh nhan that bai");
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Patient p = new Patient();
            p.id = Convert.ToInt32(txtPatientId.Text);
            p.name = txtHoTen.Text;
            p.sex = cboGioiTinh.SelectedIndex;
            p.yob = Convert.ToInt32(txtNamSinh.Text);
            p.address = txtDiaChi.Text;

            PatientBUS patientBUS = new PatientBUS();

            try
            {
                int id = patientBUS.updatePatient(p);
                MessageBox.Show("Cap nhat benh nhan thanh cong");
                Close();
            }
            catch
            {
                MessageBox.Show("Cap nhat benh nhan that bai");
            }
        }
    }
}
