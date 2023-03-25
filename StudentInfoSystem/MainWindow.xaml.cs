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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Student Student { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        { 
            Student student = new Student();
            try
            {
                student.FirstName = firstName.Text == string.Empty ? throw new Exception("Must fill out all fields") : firstName.Text;
                student.MiddleName = middleName.Text == string.Empty ? throw new Exception("Must fill out all fields") : middleName.Text;
                student.LastName = lastName.Text == string.Empty ? throw new Exception("Must fill out all fields") : lastName.Text;
                student.Faculty = faculty.Text == string.Empty ? throw new Exception("Must fill out all fields") : faculty.Text;
                student.FacultyNumber = facultyNumber.Text == string.Empty ? throw new Exception("Must fill out all fields") : facultyNumber.Text;
                student.Speciality = speciality.Text == string.Empty ? throw new Exception("Must fill out all fields") : speciality.Text;
                student.Degree = degree.Text == string.Empty ? throw new Exception("Must fill out all fields") : degree.Text;
                student.GroupNumber = Int32.Parse(group.Text);
                student.Stream = Int32.Parse(stream.Text);
                student.Status = status.Text == string.Empty ? throw new Exception("Must fill out all fields") : status.Text;
                student.Course = Int32.Parse(course.Text);
            }
            catch (Exception err) { 
                MessageBox.Show(err.Message);
                ClearFields();
            }


        }
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void toggleEnableButton_Click(object sender, RoutedEventArgs e)
        {
            bool isEnabled = !toggleEnable.Content.Equals("Disable");

            firstName.IsEnabled = isEnabled;
            middleName.IsEnabled = isEnabled;
            lastName.IsEnabled = isEnabled;
            faculty.IsEnabled = isEnabled;
            facultyNumber.IsEnabled = isEnabled;
            speciality.IsEnabled = isEnabled;
            degree.IsEnabled = isEnabled;
            group.IsEnabled = isEnabled;
            stream.IsEnabled = isEnabled;
            status.IsEnabled = isEnabled;
            course.IsEnabled = isEnabled;

            toggleEnable.Content = isEnabled ? "Disable" : "Enable";
        }

        private void ClearFields()
        {
            firstName.Text = string.Empty;
            middleName.Text = string.Empty;
            lastName.Text = string.Empty;
            faculty.Text = string.Empty;
            facultyNumber.Text = string.Empty;
            speciality.Text = string.Empty;
            degree.Text = string.Empty;
            group.Text = string.Empty;
            stream.Text = string.Empty;
            status.Text = string.Empty;
            course.Text = string.Empty;
        }
    }
}
