using GradeManagerV4.Windows;
using MahApps.Metro.Controls.Dialogs;
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
using GradeManagerV4.Classes;

namespace GradeManagerV4.Views
{
    /// <summary>
    /// Interaction logic for MoneyCalculatorScreen.xaml
    /// </summary>
    public partial class MoneyCalculatorScreen : Page
    {
        private SplashWindow Window;

        public enum Grade
        { A, B, C, D, F };

        public MoneyCalculatorScreen(SplashWindow Splash)
        {
            InitializeComponent();
            Window = Splash;

            List<Grade> ClassGrade = new List<Grade>();
            ClassGrade.Add(Grade.A);
            ClassGrade.Add(Grade.B);
            ClassGrade.Add(Grade.C);
            ClassGrade.Add(Grade.D);
            ClassGrade.Add(Grade.F);

            Class1DropDown.ItemsSource = ClassGrade;
            Class2DropDown.ItemsSource = ClassGrade;
            Class3DropDown.ItemsSource = ClassGrade;
            Class4DropDown.ItemsSource = ClassGrade;
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            string text = "Report Card Grades:@Each A: $10@Each B: $5@Each C: $0@Each D: -$5@Each F: -$20@@Assignment Grades:@Each A: $.50@Each B: $.25@Each C: $0@Each D: -$.25@Each F: -$1";
            text = text.Replace("@", Environment.NewLine);

            Window.ShowMessageAsync("Money Scale", text);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window.Frame.Content = new StartScreen("", Window.ProfileFlyout, Window);
        }

        private async void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            Double FinalGradeTotal = 0;

            if (!string.IsNullOrWhiteSpace(Class1NameBox.Text) && !string.IsNullOrWhiteSpace(Class2NameBox.Text) && !string.IsNullOrWhiteSpace(Class3NameBox.Text) && !string.IsNullOrWhiteSpace(Class4NameBox.Text) && Class1DropDown.SelectedIndex != -1 && Class2DropDown.SelectedIndex != -1 && Class3DropDown.SelectedIndex != -1 && Class4DropDown.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(Class1A.Text) && !string.IsNullOrWhiteSpace(Class2A.Text) && !string.IsNullOrWhiteSpace(Class3A.Text) && !string.IsNullOrWhiteSpace(Class4A.Text) && !string.IsNullOrWhiteSpace(Class1B.Text) && !string.IsNullOrWhiteSpace(Class2B.Text) && !string.IsNullOrWhiteSpace(Class3B.Text) && !string.IsNullOrWhiteSpace(Class4B.Text) && !string.IsNullOrWhiteSpace(Class1C.Text) && !string.IsNullOrWhiteSpace(Class2C.Text) && !string.IsNullOrWhiteSpace(Class3C.Text) && !string.IsNullOrWhiteSpace(Class4C.Text) && !string.IsNullOrWhiteSpace(Class1D.Text) && !string.IsNullOrWhiteSpace(Class2D.Text) && !string.IsNullOrWhiteSpace(Class3D.Text) && !string.IsNullOrWhiteSpace(Class4D.Text) && !string.IsNullOrWhiteSpace(Class1F.Text) && !string.IsNullOrWhiteSpace(Class2F.Text) && !string.IsNullOrWhiteSpace(Class3F.Text) && !string.IsNullOrWhiteSpace(Class4F.Text))
            {
                switch (Class1DropDown.SelectedIndex)
                {
                    case 0:
                        FinalGradeTotal += 10;
                        break;

                    case 1:
                        FinalGradeTotal += 5;
                        break;

                    case 2:
                        break;

                    case 3:
                        FinalGradeTotal -= 5;
                        break;

                    case 4:
                        FinalGradeTotal -= 20;
                        break;
                }

                switch (Class2DropDown.SelectedIndex)
                {
                    case 0:
                        FinalGradeTotal += 10;
                        break;

                    case 1:
                        FinalGradeTotal += 5;
                        break;

                    case 2:
                        break;

                    case 3:
                        FinalGradeTotal -= 5;
                        break;

                    case 4:
                        FinalGradeTotal -= 20;
                        break;
                }

                switch (Class3DropDown.SelectedIndex)
                {
                    case 0:
                        FinalGradeTotal += 10;
                        break;

                    case 1:
                        FinalGradeTotal += 5;
                        break;

                    case 2:
                        break;

                    case 3:
                        FinalGradeTotal -= 5;
                        break;

                    case 4:
                        FinalGradeTotal -= 20;
                        break;
                }

                switch (Class4DropDown.SelectedIndex)
                {
                    case 0:
                        FinalGradeTotal += 10;
                        break;

                    case 1:
                        FinalGradeTotal += 5;
                        break;

                    case 2:
                        break;

                    case 3:
                        FinalGradeTotal -= 5;
                        break;

                    case 4:
                        FinalGradeTotal -= 20;
                        break;
                }

                var Class1 = new MoneyClass();
                var Class2 = new MoneyClass();
                var Class3 = new MoneyClass();
                var Class4 = new MoneyClass();

                try
                {
                    Class1.A = int.Parse(Class1A.Text);
                    Class1.B = int.Parse(Class1B.Text);
                    Class1.C = int.Parse(Class1C.Text);
                    Class1.D = int.Parse(Class1D.Text);
                    Class1.F = int.Parse(Class1F.Text);

                    Class2.A = int.Parse(Class2A.Text);
                    Class2.B = int.Parse(Class2B.Text);
                    Class2.C = int.Parse(Class2C.Text);
                    Class2.D = int.Parse(Class2D.Text);
                    Class2.F = int.Parse(Class2F.Text);

                    Class3.A = int.Parse(Class3A.Text);
                    Class3.B = int.Parse(Class3B.Text);
                    Class3.C = int.Parse(Class3C.Text);
                    Class3.D = int.Parse(Class3D.Text);
                    Class3.F = int.Parse(Class3F.Text);

                    Class4.A = int.Parse(Class4A.Text);
                    Class4.B = int.Parse(Class4B.Text);
                    Class4.C = int.Parse(Class4C.Text);
                    Class4.D = int.Parse(Class4D.Text);
                    Class4.F = int.Parse(Class4F.Text);
                }
                catch (Exception)
                {
                    await Window.ShowMessageAsync("Error", "You must enter a number for all assignment grades");
                }

                List<MoneyClass> Classes = new List<MoneyClass>();

                Classes.Add(Class1);
                Classes.Add(Class2);
                Classes.Add(Class3);
                Classes.Add(Class4);

                double total = 0;

                foreach (var input in Classes)
                {
                    total += input.A * .5;
                    total += input.B * .25;
                    total -= input.D * .5;
                    total -= input.F * 1;
                }

                double GradesTotal = FinalGradeTotal;
                double AssingmentTotal = total;
                double DualTotal = GradesTotal + AssingmentTotal;
                double SavingTotal = GradesTotal / 2;
                double CashTotal = SavingTotal + AssingmentTotal;

                string text = $"Your total earned is: ${DualTotal}@You will recieve ${CashTotal} in cash@${SavingTotal} will be going into your savings account@${GradesTotal} is coming from your report card grades@${AssingmentTotal} is coming from your assignment grades";
                text = text.Replace("@", Environment.NewLine);

                await Window.ShowMessageAsync("Your Grade Money Has been Calculated", text);
            }
            else
            {
                await Window.ShowMessageAsync("Error", "Please fill in all fields");
            }
        }

        public struct MoneyClass
        {
            public int A;
            public int B;
            public int C;
            public int D;
            public int F;
        }
    }
}