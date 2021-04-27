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

namespace SampleBinding1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<model.Employee> Employees = new List<model.Employee>();
        int currentIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            InitEmployee();
            MainGrid.DataContext = Employees[currentIndex];
        }
        private void InitEmployee()
        {
            Employees.Add(new model.Employee("Ashraf", 21, "9600630212", "7796 7455 2221", "CEO", "images/ashraf.jpg"));
            Employees.Add(new model.Employee("Safdhar", 21, "9600630212", "7796 7455 2221","Manager", "images/safdhar.jpeg"));
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            if(currentIndex>0)
            {
                MainGrid.DataContext = Employees[--currentIndex];
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if(currentIndex<Employees.Count-1)
            {
                MainGrid.DataContext = Employees[++currentIndex];
            }
        }
    }
}
