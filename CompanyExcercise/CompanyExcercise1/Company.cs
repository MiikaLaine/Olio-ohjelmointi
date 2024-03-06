namespace CompanyExcercise1
{
    internal class Company
    {
        public string title;
        public string address;
        public string phone;
        public double income;
        public double expense;

        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.income = 0;
            this.expense = 0;
        }
        public Company(Company previousCompany)
        {
            title = previousCompany.title;
            address = previousCompany.address;
            phone = previousCompany.phone;
            income = previousCompany.income;
            expense = previousCompany.expense;
        }



        public Company(string title, string address, string phone, double income, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.income = income;
            this.expense = expense;

        }



        public double Calculateprofit()
        {
            // voitto%=(tulot-menot)/menot x 100
            double currentProfit = (this.income - this.expense) / this.expense * 100;
            {
                Console.WriteLine("Firman tilanne:");

                if (currentProfit < 100)
                {
                    Console.WriteLine("Kehnosti, voitto on alle 100% suurempi kuin menot.");
                }
                else if (currentProfit <= 200)
                {
                    Console.WriteLine("Välttävästi, voitto on enintään 200% suurempi kuin menot.");
                }
                else if (currentProfit < 300)
                {
                    Console.WriteLine("Tyydyttävästi, voitto on vähintään 200% suurempi kuin menot.");
                }
                else
                {
                    Console.WriteLine("Hyvin, voitto on vähintään 300% suurempi kuin menot.");

                }
                return currentProfit;


            }

        }


    }
}