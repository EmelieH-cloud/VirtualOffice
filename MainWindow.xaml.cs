using System;
using System.Collections.Generic;
using System.Windows;
using static VirtualOffice.Person;

namespace VirtualOffice
{

    public partial class MainWindow : Window
    {

        Manager manager = new Manager();
        List<Person> persons = new();

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

                // data-bindningen möjliggör denna placering i listview
                EmployeeListView.Items.Add(new
                {
                    Förnamn = fname,
                    EfterNamn = lname,
                    Bakgrund = department,
                });
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


            }
        }
    }
}
