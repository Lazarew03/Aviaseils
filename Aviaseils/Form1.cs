using System.Collections.Specialized;

namespace Aviaseils
{
    public partial class Form1 : Form
    {
        int count;
        private static City[] DbCities()
        {
            City[] cities = new City[] {

                    new City  (1, "������", 399, 175, 1.13),
                    new City  (2, "�����", 300, 175),
                    new City  (3, "�����", 350, 220),
                    new City  (4, "����", 250, 170),
                    new City  (5, "������", 390, 270),
                    new City  (6, "�������", 500, 350),
                    new City  (7, "�������", 230, 150),
                    new City  (8, "�������", 300, 190),
                    new City  (9, "�������", 215, 110),
                    new City  (10, "������", 260, 190),
                    new City  (11, "��������", 399, 175)
                };
            return cities;
        }

        public Form1()
        {
            InitializeComponent();
        }

        static double CalcPrice(double price, City[] cities, string firstCity, string secondCity)
        {

            for (int i = 1; i < 11; i++)
            {
                if (secondCity == cities[i].name)
                {
                    price += cities[i].price;
                }
            }

            if (secondCity == "������")
            {
                price += cities[1].price * cities[1].nalog - cities[1].price;
                price += cities[1].price * 1.04 - cities[1].price;
            }

            if (secondCity == "�����")
                price += cities[2].price * 1.04 - cities[2].price;

            if (secondCity == "�����")
                price += cities[3].price * 1.04 - cities[3].price;

            if (secondCity == "����")
            {
                price += cities[8].transit;
                if (firstCity == "�����") price += cities[4].price * 1.09 - cities[4].price;
                price += cities[4].price * 1.04 - cities[4].price;
                if (firstCity == "�������") price += cities[8].transit + cities[1].transit;
            }

            if (secondCity == "������")
                price += cities[3].price;

            if (secondCity == "�������")
            {
                if (firstCity == "������") price += cities[7].price * 1.07 - cities[7].price;
                if (firstCity == "�������") price += cities[7].price * 1.11 - cities[7].price;
                price += cities[7].price * 1.04 - cities[7].price;
                if (firstCity == "����") price += cities[8].transit + cities[1].transit;
            }

            if (secondCity == "�������")
                price += cities[8].price * 1.04 - cities[8].price;

            if (secondCity == "�������")
                price += cities[10].transit;

            if (secondCity == "������")
            {
                price += cities[3].transit;
                price += cities[10].price * 1.04 - cities[10].price;
            }

            if (secondCity == "��������")
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
                    if (cbMyCity.Text == "�������") price *= 1.5;
                }
            }


            if (price > budget)
            {
                MessageBox.Show($"������ ������� �� ����������, ��������� ������� {price} $");
            }
            else
            {
                MessageBox.Show($"��������� �������: {price}, ������ ������� ����������");
            }


            Console.ReadLine();
        }

        private void myPrise_TextChanged(object sender, EventArgs e)
        {

        }
    }
}