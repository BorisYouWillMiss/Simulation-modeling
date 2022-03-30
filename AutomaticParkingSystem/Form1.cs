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
            }
            else
            {
                Start.Text = "Start";
                Step.Enabled = true;
            }
        }

        private void Step_Click(object sender, EventArgs e)
        {
            // Шаг

            // Simulation logic:

            // Найм 
            //
            // Проверка на расширение (demand + bank)
            //
            // Перерасчет цены в час + (изменение спроса(demand))
            // Перерасчет зарплат
            // 
            // Выплата зарплат
            // Плата за ренту
            // 
            // Доход/расход за день

            // На 20 день выплата зарплат (20 + 30 + 30...) (сотрудники * зарплата)
            // На 30 день плата за ренту и обслуживание по формуле (количество парковочных мест * rent + adrent)

            income = 0;
            expenses = 0;
            curday++;

            // Клиенты паркуются
            Random random = new Random();
            int revenue = 0;
            int violationRevenue = 0;
            int violators = 0;
            int intersectors = 0;
            int[] CIV = new int[4];
            int clients = 0;
            for (int i = 0; i < automaticParking.places.Length; i++)
            {
                clients = demand / ((random.Next(30) + 50) / automaticParking.places.Length); // Clients per place
                CIV = automaticParking.places[i].SimulateDay(hourPrice, fineFee, violationPercent, clients);
                revenue += CIV[0];
                intersectors += CIV[1];
                violators += CIV[2];
                violationRevenue += CIV[3];
            }
            income += revenue;

            // Проверка увольнения
            for (int i = 0; i < automaticParking.workers; i++)
                if (random.Next(100) + 1 <= leaveChance)
                {
                    automaticParking.WorkerLeft();
                    expenses += (curday % 30) * (salary / 30) + 5000;
                }

            // Проверка найма



            bank += (income - expenses);
            labelParkingPlaces.Text = "Parking places: " + automaticParking.places.Length;
            labelSalary.Text = "Salary: " + salary.ToString();
            labelMoney.Text = "Bank: " + bank.ToString();
            labelWorkers.Text = "Workers: " + automaticParking.workers;

            labelIntersect.Text = "Intersect: " + intersectors;
            labelViolations.Text = "Violation: " + violators;
            labelVFee.Text = "Violators Fee: " + violationRevenue;
            labelIncome.Text = "Income: " + income;
            labelClients.Text = "Clients: " + clients;

            chart1.Series[0].Points.AddXY(0, automaticParking.workers);

            chart1.Series[1].Points.AddXY(0, income);


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
            demand = 20;
            salary = 15000;
            adrent = 10000; // Extra expenses
            curday = 0;
            //

            // Создать парковку:
            automaticParking = new AutomaticParking();
            // Вывести начальные данные:
            labelParkingPlaces.Text = "Parking places: " + automaticParking.places.Length;
            labelSalary.Text = "Salary: " + salary.ToString();
            labelMoney.Text = "Bank: " + bank.ToString();
            labelWorkers.Text = "Workers: " + automaticParking.workers;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, automaticParking.workers);

            chart1.Series[1].Points.Clear();
            chart1.Series[1].Points.AddXY(0, income);
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            panelControl.Visible = false;
            panelInfo.Visible = false;
            Init.Visible = true;
            panelParameters.Enabled = true;
            if (Start.Text == "Stop")
            {
                Step.Enabled = true;
                Start.Text = "Start";
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
    }
}
