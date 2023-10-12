using System;
using System.Collections.Generic;
using System.Windows;
using static VirtualOffice.Person;

namespace VirtualOffice
{

    public partial class MainWindow : Window
    {

        Manager manager = new Manager();
        List<Person> EmployeeDatabase = new();

        public MainWindow()
        {
            InitializeComponent();
            // Fyller comboboxen med värden 
            foreach (var item in Enum.GetValues(typeof(Department)))
            {
                comboDepartment.Items.Add(item);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // hämtar user input 
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string age = txtAge.Text;
            string salary = txtSalary.Text;
            string bio = txtBio.Text;

            // hämtar vald department (combobox)
            string? department = comboDepartment.SelectedItem.ToString();

            // verifierar user input 
            bool ageIsConverted = manager.ValidateAgeInput(age);
            bool salaryIsConverted = manager.ValidateSalaryInput(salary);
            bool nameIsLongEnough = manager.ValidateStringInput(fname);
            bool lnameIsLongEnough = manager.ValidateStringInput(lname);
            bool departmentString = manager.ValidateStringInput(department);

            if (ageIsConverted && salaryIsConverted && nameIsLongEnough && lnameIsLongEnough && bio.Length > 0)
            {
                // konverterar om input är ok. 
                int ageInt = Convert.ToInt32(ageIsConverted);
                decimal salaryDecimal = Convert.ToDecimal(salaryIsConverted);
                // använder konstruktorn för att ta in bio
                Employee employee = new Employee(fname, lname, ageInt, bio, salaryDecimal);

                // data-binding av properties med XAML-fönstret 
                EmployeeListView.Items.Add(new
                {
                    Förnamn = fname,
                    EfterNamn = lname,
                    Bakgrund = department,
                });

                EmployeeDatabase.Add(employee);
            }

            else if (ageIsConverted && salaryIsConverted && nameIsLongEnough && lnameIsLongEnough && bio.Length <= 0)
            {
                int ageInt = Convert.ToInt32(ageIsConverted);
                decimal salaryDecimal = Convert.ToDecimal(salaryIsConverted);
                Employee employee = new(fname, lname, ageInt, salaryDecimal);
                string defaultad = employee.Bakgrund; // behållare för default-bion. 

                EmployeeListView.Items.Add(new
                {
                    Förnamn = fname,
                    EfterNamn = lname,
                    Bakgrund = department,
                });

                EmployeeDatabase.Add(employee);
            }
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            int index = EmployeeListView.SelectedIndex; // listview
            Employee emp = (Employee)EmployeeDatabase[index]; // samma index i databasen 
            MessageBoxResult result = MessageBox.Show("Are you sure you want to remove?", "Remove employee", MessageBoxButton.YesNoCancel);
            if (MessageBoxResult.Yes == result)
            {
                EmployeeListView.Items.RemoveAt(index);
                EmployeeDatabase.RemoveAt(index);
            }
        }

        private void EmployeeListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // man kan bara ta bort employees när ett index är valt i listview
            int index = EmployeeListView.SelectedIndex;
            if (index >= 0)
            {
                btndelete.IsEnabled = true;
            }
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            Object Employee = EmployeeListView.SelectedItem;
            for (int i = 0; i < EmployeeDatabase.Count; i++)
            {
                if (EmployeeDatabase[i] == EmployeeListView.SelectedItem)
                {
                    Employee emp = (Employee)EmployeeDatabase[i];
                    EmployeeDetailsWindow detailsWindow = new(emp); // 1. Kör konstruktorn
                    detailsWindow.Show(); // 2. visa fönstret 
                    Close(); // 3. stäng det gamla fönstret 
                    break;
                }
            }
        }
    }
}