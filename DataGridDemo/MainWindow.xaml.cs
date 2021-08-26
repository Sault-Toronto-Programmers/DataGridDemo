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

namespace DataGridDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Student> roll = new List<Student>();
            roll.Add(new Student(123, "Jim", new DateTime(1995, 11, 11)));
            roll.Add(new Student(124, "Steve", new DateTime(1995, 11, 10)));
            roll.Add(new Student(125, "Rob", new DateTime(1995, 5, 10)));
            Items.ItemsSource = roll;
        }

    }

    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime date_of_birth { get; set; }

        public Student(int _id, string _name, DateTime _dob)
        {
            id = _id;
            name = _name;
            date_of_birth = _dob;
        }
    }


}
