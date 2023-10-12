namespace VirtualOffice
{

    internal class Manager
    {

        public bool ValidateAgeInput(string age)
        {
            bool result;
            int converted;
            result = int.TryParse(age, out converted);
            if (result == true)
            {
                return true;
            }
            return false;
        }

        public bool ValidateSalaryInput(string salary)
        {
            bool result;
            decimal converted;
            result = decimal.TryParse(salary, out converted);
            if (result == true)
            {
                return true;
            }
            return false;

        }

        public bool ValidateStringInput(string str)
        {
            if (str.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }

}
