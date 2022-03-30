using System;
using System.Windows.Forms;

namespace AutomaticParkingSystem
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        // Данные на ввод
        int averagePrice = 0;     // Средняя цена в городе за час
        int fineFee = 0;          // Размер штрафа
        int violationPercent = 0; // Процент нарушителей
        int leaveChance = 0;      // Темп увольнений

        // Внутренние данные
        int hourPrice = 0;
        int demand = 0;
        int salary = 0;
        int originalSalary = 0;

        // Global Economics
        int income = 0;
        int expenses = 0;
        int bank = 0;

        int adrent = 0;

        int curday = 0;

        AutomaticParking automaticParking = new AutomaticParking();

        // Macro
        private void Start_Click(object sender, EventArgs e)
        {
            // Start/stop timer

            if (Start.Text == "Start")
            {
                Start.Text = "Stop";
                Step.Enabled = false;
                timer1.Start();
            }
            else
            {
                Start.Text = "Start";
                Step.Enabled = true;
                timer1.Stop();
            }
        }

        private void Step_Click(object sender, EventArgs e)
        {
            // Шаг

            // Simulation logic:

            // Клиенты паркуются (доход) 1
            // Проверка увольнения 2
            // Проверка найма 3
            // Проверка на расширение (demand + bank) 4
            // Перерасчет цены в час + (изменение спроса(demand)) 5
<<<<<<< HEAD
            // Перерасчет зарплат 6
=======
            // Перерасчет зарплат
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            // 
            // Выплата зарплат 7
            // Плата за ренту 8
            // 
            // Доход/расход за день 9

            // На 30 день выплата зарплат (сотрудники * зарплата)
            // На 30 день плата за ренту и обслуживание по формуле (количество парковочных мест * rent + adrent)

            income = 0;
            expenses = 0;
            curday++;

            // Клиенты паркуются
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int revenue = 0;
            int violationRevenue = 0;
            int violators = 0;
            int intersectors = 0;
            int[] CIV = new int[4];
            int clients = 0;
            int totalClients = 0;
            for (int i = 0; i < automaticParking.places.Length; i++)
            {
<<<<<<< HEAD
                clients = (int)(demand / (float)((random.Next(80) + 20) / automaticParking.places.Length)); // Clients per place
                if (clients > 0)
=======
                clients = demand / ((random.Next(30) + 50) / automaticParking.places.Length); // Clients per place
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
                totalClients += clients;
                CIV = automaticParking.places[i].SimulateDay(hourPrice, fineFee, violationPercent, clients);
                revenue += CIV[0];
                intersectors += CIV[1];
                violators += CIV[2];
                violationRevenue += CIV[3];
            }
            income += revenue;

            // Проверка увольнения
            for (int i = 0; i < automaticParking.workers; i++)
                if (random.Next(101) <= leaveChance)
                {
                    automaticParking.WorkerLeft();
                    expenses += (curday % 30) * (salary / 30) + 5000;
                }

            // Проверка найма

            // Проверка на расширение (demand + bank)
            float mediumClientsOnSpot = totalClients / automaticParking.places.Length;
            if (mediumClientsOnSpot >= 3 + (automaticParking.places.Length - 4)*0.5f)
                if (random.Next(101) <= ((mediumClientsOnSpot - 1) * 100))
                {
                    if (bank > 300000 && (curday%30) < 15)
                    {
                        automaticParking.Expand(1);
                        bank -= 150000;
                    }
                }

            // Перерасчет цены в час + (изменение спроса(demand))

            hourPrice = (90 + automaticParking.workers * 5)+(automaticParking.places.Length-4);
            demand = 30 - (hourPrice/8 - 10);

            // Пересчет зарплаты 

            salary = 30000 + income / 5;

            // Зарплата и рента
            adrent = 30000 + automaticParking.places.Length * 1000;

            expenses += (curday % 30 == 0) ? (salary+(salary*13/100)) * automaticParking.workers : 0;
            expenses += (curday % 30 == 0) ? automaticParking.rent : 0;
            expenses += (curday % 30 == 0) ? adrent : 0;
=======

            // Проверка на расширение (demand + bank)
            float mediumClientsOnSpot = totalClients / automaticParking.places.Length;
            if(mediumClientsOnSpot >= 5)
                if(random.Next(101) <= ((mediumClientsOnSpot-1)*100))
                    automaticParking.Expand(1);

            // Перерасчет цены в час + (изменение спроса(demand))
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea

            // Налоги
            income -= (income * 13) / 100;

            expenses += (curday % 30 == 0) ? salary * automaticParking.workers : 0;
            expenses += (curday % 30 == 0) ? automaticParking.rent : 0;
            bank += (income - expenses);

            if (bank < 0)
            {
                Step.Enabled = false;
                Start.Enabled = false;
            }

            labelParkingPlaces.Text = "Parking places: " + automaticParking.places.Length;
            labelSalary.Text = "Salary: " + salary.ToString();
            labelExpenses.Text = "Expenses: " + expenses.ToString();
            labelMoney.Text = "Bank: " + bank.ToString();
            labelWorkers.Text = "Workers: " + automaticParking.workers + "/"+ (automaticParking.workers+automaticParking.GetFreeWorkerPlaces());

            labelIntersect.Text = "Intersect: " + intersectors;
            labelViolations.Text = "Violation: " + violators;
            labelVFee.Text = "Violators Fee: " + violationRevenue;
            labelIncome.Text = "Income: " + income;
            labelClients.Text = "Clients: " + totalClients;
<<<<<<< HEAD
            labelPrice.Text = "Price an hour: " + hourPrice;
=======
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea

            chart1.Series[0].Points.AddXY(curday, automaticParking.workers);

            chart1.Series[1].Points.AddXY(curday, income);


            //
        }

        private void Init_Click(object sender, EventArgs e)
        {
            Init.Visible = false;
            panelControl.Visible = true;
            panelInfo.Visible = true;
            panelParameters.Enabled = false;
            // Собрать переменные
            averagePrice = int.Parse((inputAvgPrice.Value).ToString());
            leaveChance = trackBarLC.Value;
            fineFee = int.Parse((inputFeeSize.Value).ToString());
            violationPercent = trackBarVP.Value;
            bank = int.Parse((inputBank.Value).ToString());
            // Данные собраны

            // Создать свои данные
            hourPrice = averagePrice;
<<<<<<< HEAD
            demand = 30;
            salary = 30000;
            originalSalary = salary;
            adrent = 25000; // Extra expenses
=======
            demand = 20;
            salary = 15000;
            originalSalary = salary;
            adrent = 10000; // Extra expenses
>>>>>>> 5dea678878af796954b4dd8e3df3a19a7afa23ea
            curday = 0;
            //

            // Создать парковку:
            automaticParking = new AutomaticParking();
            // Вывести начальные данные:
            labelParkingPlaces.Text = "Parking places: " + automaticParking.places.Length;
            labelSalary.Text = "Salary: " + salary.ToString();
            labelExpenses.Text = "Expenses: " + expenses.ToString();
            labelMoney.Text = "Bank: " + bank.ToString();
            labelWorkers.Text = "Workers: " + automaticParking.workers;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(curday, automaticParking.workers);

            chart1.Series[1].Points.Clear();
            chart1.Series[1].Points.AddXY(curday, income);
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            panelControl.Visible = false;
            panelInfo.Visible = false;
            Init.Visible = true;
            panelParameters.Enabled = true;
            timer1.Stop();
            if (Start.Text == "Stop")
            {
                Step.Enabled = true;
                Start.Text = "Start";
                Start.Enabled = true;
            }
            
            // Обнулить переменные

        }

        private void trackBarVP_Scroll(object sender, EventArgs e)
        {
            labelVP.Text = trackBarVP.Value.ToString() + "%";
        }

        private void trackBarLC_Scroll(object sender, EventArgs e)
        {
            labelLC.Text = trackBarLC.Value.ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            income = 0;
            expenses = 0;
            curday++;

            // Клиенты паркуются
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int revenue = 0;
            int violationRevenue = 0;
            int violators = 0;
            int intersectors = 0;
            int[] CIV = new int[4];
            int clients = 0;
            int totalClients = 0;
            for (int i = 0; i < automaticParking.places.Length; i++)
            {
                clients = (int)(demand / (float)((random.Next(80) + 20) / automaticParking.places.Length)); // Clients per place
                if (clients > 0)
                    totalClients += clients;
                CIV = automaticParking.places[i].SimulateDay(hourPrice, fineFee, violationPercent, clients);
                revenue += CIV[0];
                intersectors += CIV[1];
                violators += CIV[2];
                violationRevenue += CIV[3];
            }
            income += revenue;

            // Проверка увольнения
            for (int i = 0; i < automaticParking.workers; i++)
                if (random.Next(101) <= leaveChance)
                {
                    automaticParking.WorkerLeft();
                    expenses += (curday % 30) * (salary / 30) + 5000;
                }

            // Проверка найма
            for (int i = 0; i < automaticParking.GetFreeWorkerPlaces(); i++)
            {
                float chances = (salary / originalSalary) * 50f;
                chances = (chances > 65f) ? 65f : chances;
                if (random.Next(101) <= Math.Floor(chances))
                    automaticParking.WorkerHire();
            }

            // Проверка на расширение (demand + bank)
            float mediumClientsOnSpot = totalClients / automaticParking.places.Length;
            if (mediumClientsOnSpot >= 3 + (automaticParking.places.Length - 4) * 0.5f)
                if (random.Next(101) <= ((mediumClientsOnSpot - 1) * 100))
                {
                    if (bank > 300000 && (curday % 30) < 15)
                    {
                        automaticParking.Expand(1);
                        bank -= 150000;
                    }
                }

            // Перерасчет цены в час + (изменение спроса(demand))

            hourPrice = (90 + automaticParking.workers * 5) + (automaticParking.places.Length - 4);
            demand = 30 - (hourPrice / 8 - 10);

            // Пересчет зарплаты 

            salary = 30000 + income / 5;

            // Зарплата и рента
            adrent = 30000 + automaticParking.places.Length * 1000;

            expenses += (curday % 30 == 0) ? (salary + (salary * 13 / 100)) * automaticParking.workers : 0;
            expenses += (curday % 30 == 0) ? automaticParking.rent : 0;
            expenses += (curday % 30 == 0) ? adrent : 0;

            // Налоги
            income -= (income * 13) / 100;

            bank += (income - expenses);

            if (bank < 0)
            {
                Step.Enabled = false;
                Start.Enabled = false;
                timer1.Stop();
            }

            labelParkingPlaces.Text = "Parking places: " + automaticParking.places.Length;
            labelSalary.Text = "Salary: " + salary.ToString();
            labelExpenses.Text = "Expenses: " + expenses.ToString();
            labelMoney.Text = "Bank: " + bank.ToString();
            labelWorkers.Text = "Workers: " + automaticParking.workers + "/" + (automaticParking.workers + automaticParking.GetFreeWorkerPlaces());

            labelIntersect.Text = "Intersect: " + intersectors;
            labelViolations.Text = "Violation: " + violators;
            labelVFee.Text = "Violators Fee: " + violationRevenue;
            labelIncome.Text = "Income: " + income;
            labelClients.Text = "Clients: " + totalClients;
            labelPrice.Text = "Price an hour: " + hourPrice;

            chart1.Series[0].Points.AddXY(curday, automaticParking.workers);

            chart1.Series[1].Points.AddXY(curday, income);

        }
    }
}
