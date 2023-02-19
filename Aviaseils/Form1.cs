using System.Collections.Specialized;

namespace Aviaseils
{
    public partial class Form1 : Form
    {
        int count;
        private static City[] DbCities()
        {
            City[] cities = new City[] {

                    new City  (1, "Áåðëèí", 399, 175, 1.13),
                    new City  (2, "Ïðàãà", 300, 175),
                    new City  (3, "Ïàðèæ", 350, 220),
                    new City  (4, "Ðèãà", 250, 170),
                    new City  (5, "Ëîíäîí", 390, 270),
                    new City  (6, "Âàòèêàí", 500, 350),
                    new City  (7, "Ïàëåðìî", 230, 150),
                    new City  (8, "Âàðøàâà", 300, 190),
                    new City  (9, "Êèøèíåâ", 215, 110),
                    new City  (10, "Ìàäðèä", 260, 190),
                    new City  (11, "Áóäàïåøò", 399, 175)
                };
            return cities;
        }

        public Form1()
        {
            InitializeComponent();
        }

        static double CalcPrice(double price, City[] cities, string firstCity, string secondCity)
        {

            for (int i = 1; i < 10; i++)
            {
                if (secondCity == cities[i].name)
                {
                    price += cities[i].price;
                }
            }

            if (secondCity == "Áåðëèí")
            {
                price += cities[1].price * cities[1].nalog - cities[1].price;
                price += cities[1].price * 1.04 - cities[1].price;
            }

            if (secondCity == "Ïðàãà")
                price += cities[2].price * 1.04 - cities[2].price;

            if (secondCity == "Ïàðèæ")
                price += cities[3].price * 1.04 - cities[3].price;

            if (secondCity == "Ðèãà")
            {
                price += cities[8].transit;
                if (firstCity == "Ïàðèæ") price += cities[4].price * 1.09 - cities[4].price;
                price += cities[4].price * 1.04 - cities[4].price;
                if (firstCity == "Ïàëåðìî") price += cities[8].transit + cities[1].transit;
            }

            if (secondCity == "Ëîíäîí")
                price += cities[3].price;

            if (secondCity == "Ïàëåðìî")
            {
                if (firstCity == "Ëîíäîí") price += cities[7].price * 1.07 - cities[7].price;
                if (firstCity == "Êèøèíåâ") price += cities[7].price * 1.11 - cities[7].price;
                price += cities[7].price * 1.04 - cities[7].price;
                if (firstCity == "Ðèãà") price += cities[8].transit + cities[1].transit;
            }

            if (secondCity == "Âàðøàâà")
                price += cities[8].price * 1.04 - cities[8].price;

            if (secondCity == "Êèøèíåâ")
                price += cities[10].transit;

            if (secondCity == "Ìàäðèä")
            {
                price += cities[3].transit;
                price += cities[10].price * 1.04 - cities[10].price;
            }

            if (secondCity == "Áóäàïåøò")
                price += cities[10].price * 1.04 - cities[10].price;

            return price;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void NumCityTravel()
        {
            if (count >= 1)
            {
                labelOneCity.Visible = true;
                cbOneCity.Visible = true;
            }
            if (count >= 2)
            {
                labelTwoCity.Visible = true;
                cbTwoCity.Visible = true;
            }
            if(count == 3)
            {
                labelThreeCity.Visible = true;
                cbThreeCity.Visible = true;
            }

        }

        private void numCity_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void butPr_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(numCity.Text);
            NumCityTravel();
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelOneCity.Visible = false;
            cbOneCity.Visible = false;
            labelTwoCity.Visible = false;
            cbTwoCity.Visible = false;
            labelThreeCity.Visible = false;
            cbThreeCity.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            City[] cities = DbCities();


            int budget = Convert.ToInt32(myPrise.Text);


            string[] arrCombo = new string[12];
            arrCombo[0] = cbOneCity.Text;
            arrCombo[1] = cbTwoCity.Text;
            arrCombo[2] = cbThreeCity.Text;


            double price = 0;

            for (int i = 0; i < count; i++)
            {
                int temp = count;
                if (temp == count)
                {
                    price += CalcPrice(price, cities, cbMyCity.Text, arrCombo[i]);
                    if (cbMyCity.Text == "Âàòèêàí") price *= 1.5;
                }
            }


            if (price > budget)
            {
                MessageBox.Show($"Âàøåãî áþäæåòà íå äîñòàòî÷íî, ñòîèìîñòü ïîåçäêè {price} $");
            }
            else
            {
                MessageBox.Show($"Ñòîèìîñòü ïîåçäêè: {price}, âàøåãî áþäæåòà äîñòàòî÷íî");
            }


            Console.ReadLine();
        }

        private void myPrise_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
