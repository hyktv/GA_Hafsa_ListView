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

namespace GA_Hafsa_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();

        public MainWindow()
    {
            InitializeComponent();

            // Create a student
            // Assign an id number
            // First and last name
            Student name = new Student("Jane", "Doe");
            students.Add(name);
            students.Add(new Student("Will", "Cram"));
            students.Add(new Student("Hafsa", "Mohamed"));
            students.Add(new Student("John", "Doe"));
            students.Add(new Student("J", "K"));



            // Declare and instantiate


            // Put on list view

            //students.Add("");

            lvDisplayList.ItemsSource = students;
            lvDisplayList.SelectedIndex = 0;
            
        }

        private void lvDisplayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lvDisplayList.SelectedIndex;
            Student selectedStudent = students[selectedIndex];

            string firstName = selectedStudent.FirstName;
            string lastName = selectedStudent.LastName;

            MessageBox.Show($"Full Name: {firstName + " " + lastName}");
            
        }
    }
}
