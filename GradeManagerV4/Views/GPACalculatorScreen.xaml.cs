using GradeManagerV4.Windows;
using GradeManagerV4.Classes;
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
using MahApps.Metro.Controls.Dialogs;

namespace GradeManagerV4.Views
{
    /// <summary>
    /// Interaction logic for GPACalculatorScreen.xaml
    /// </summary>
    public partial class GPACalculatorScreen : Page
    {
        private SplashWindow Window;
        private bool Weighted;

        public enum Grade
        { A, B, C, D, F };

        public GPACalculatorScreen(SplashWindow SplashWindow)
        {
            InitializeComponent();
            Window = SplashWindow;

            List<ParentClass.Types> ClassTypes = new List<ParentClass.Types>();
            ClassTypes.Add(ParentClass.Types.Standard);
            ClassTypes.Add(ParentClass.Types.Honors);
            ClassTypes.Add(ParentClass.Types.Ap);

            Class1DropDown.ItemsSource = ClassTypes;
            Class2DropDown.ItemsSource = ClassTypes;
            Class3DropDown.ItemsSource = ClassTypes;
            Class4DropDown.ItemsSource = ClassTypes;

            List<Grade> ClassGrade = new List<Grade>();
            ClassGrade.Add(Grade.A);
            ClassGrade.Add(Grade.B);
            ClassGrade.Add(Grade.C);
            ClassGrade.Add(Grade.D);
            ClassGrade.Add(Grade.F);

            Class1GradeDropDown.ItemsSource = ClassGrade;
            Class2GradeDropDown.ItemsSource = ClassGrade;
            Class3GradeDropDown.ItemsSource = ClassGrade;
            Class4GradeDropDown.ItemsSource = ClassGrade;

            WeightedCheckBox.IsChecked = true;
            Weighted = true;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window.Frame.Content = new StartScreen("", Window.ProfileFlyout, Window);
        }

        private async void UnweightedGpaAboutBox_Click(object sender, RoutedEventArgs e)
        {
            string text = "Unweighted Grading Scale:@@A = 4@B = 3@C = 2@D = 1@F = 0";
            text = text.Replace("@", Environment.NewLine);

            await Window.ShowMessageAsync("Scale", text);
        }

        private async void WeightedGpaAboutBox_Click(object sender, RoutedEventArgs e)
        {
            string text = "Weighted Grading Scale:@@Standard A = 4 | Honors A = 4.5 | AP A = 5@Standard B = 3 | Honors B = 3.5 | AP B = 4@Standard C = 2 | Honors C = 2.5 | AP C = 3@Standard D = 1 | Honors D = 1.5 | AP D = 2@Standard F = 0 | Honors F = 0.5 | AP F = 1";
            text = text.Replace("@", Environment.NewLine);

            await Window.ShowMessageAsync("Scale", text);
        }

        private void WeightedCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (Weighted)
            {
                WeightedCheckBox.IsChecked = false;
                Weighted = false;
                UnweighedCheckBox.IsChecked = true;
            }
            else
            {
                Weighted = true;
                WeightedCheckBox.IsChecked = true;
                UnweighedCheckBox.IsChecked = false;
            }
        }

        private void UnweighedCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (!Weighted)
            {
                UnweighedCheckBox.IsChecked = false;
                Weighted = true;
                WeightedCheckBox.IsChecked = true;
            }
            else
            {
                WeightedCheckBox.IsChecked = false;
                UnweighedCheckBox.IsChecked = true;
                Weighted = false;
            }
        }

        private void UnweighedCheckBox_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void WeightedCheckBox_Checked(object sender, RoutedEventArgs e)
        {
        }

        private async void SingleCalculateButton_Click(object sender, RoutedEventArgs e)
        {
            List<GpaClass> InputList = new List<GpaClass>();

            if (!string.IsNullOrWhiteSpace(Class1NameBox.Text) && !string.IsNullOrWhiteSpace(Class2NameBox.Text) && !string.IsNullOrWhiteSpace(Class3NameBox.Text) && !string.IsNullOrWhiteSpace(Class4NameBox.Text) && Class1DropDown.SelectedIndex != -1 && Class1GradeDropDown.SelectedIndex != -1 && Class2DropDown.SelectedIndex != -1 && Class2GradeDropDown.SelectedIndex != -1 && Class3DropDown.SelectedIndex != -1 && Class3GradeDropDown.SelectedIndex != -1 && Class4DropDown.SelectedIndex != -1 && Class4GradeDropDown.SelectedIndex != -1)
            {
                GpaClass Class1 = new GpaClass();
                Class1.ClassName = Class1NameBox.Text;
                switch (Class1DropDown.SelectedIndex)
                {
                    case 0:
                        Class1.ClassType = ParentClass.Types.Standard;
                        break;

                    case 1:
                        Class1.ClassType = ParentClass.Types.Honors;
                        break;

                    case 2:
                        Class1.ClassType = ParentClass.Types.Ap;
                        break;
                }

                switch (Class1GradeDropDown.SelectedIndex)
                {
                    case 0:
                        Class1.ClassGrade = Grade.A;
                        break;

                    case 1:
                        Class1.ClassGrade = Grade.B;
                        break;

                    case 2:
                        Class1.ClassGrade = Grade.C;
                        break;

                    case 3:
                        Class1.ClassGrade = Grade.D;
                        break;

                    case 4:
                        Class1.ClassGrade = Grade.F;
                        break;
                }

                InputList.Add(Class1);

                GpaClass Class2 = new GpaClass();
                Class2.ClassName = Class2NameBox.Text;
                switch (Class2DropDown.SelectedIndex)
                {
                    case 0:
                        Class2.ClassType = ParentClass.Types.Standard;
                        break;

                    case 1:
                        Class2.ClassType = ParentClass.Types.Honors;
                        break;

                    case 2:
                        Class2.ClassType = ParentClass.Types.Ap;
                        break;
                }

                switch (Class2GradeDropDown.SelectedIndex)
                {
                    case 0:
                        Class2.ClassGrade = Grade.A;
                        break;

                    case 1:
                        Class2.ClassGrade = Grade.B;
                        break;

                    case 2:
                        Class2.ClassGrade = Grade.C;
                        break;

                    case 3:
                        Class2.ClassGrade = Grade.D;
                        break;

                    case 4:
                        Class2.ClassGrade = Grade.F;
                        break;
                }

                InputList.Add(Class2);

                GpaClass Class3 = new GpaClass();
                Class3.ClassName = Class3NameBox.Text;
                switch (Class3DropDown.SelectedIndex)
                {
                    case 0:
                        Class3.ClassType = ParentClass.Types.Standard;
                        break;

                    case 1:
                        Class3.ClassType = ParentClass.Types.Honors;
                        break;

                    case 2:
                        Class3.ClassType = ParentClass.Types.Ap;
                        break;
                }

                switch (Class3GradeDropDown.SelectedIndex)
                {
                    case 0:
                        Class3.ClassGrade = Grade.A;
                        break;

                    case 1:
                        Class3.ClassGrade = Grade.B;
                        break;

                    case 2:
                        Class3.ClassGrade = Grade.C;
                        break;

                    case 3:
                        Class3.ClassGrade = Grade.D;
                        break;

                    case 4:
                        Class3.ClassGrade = Grade.F;
                        break;
                }

                InputList.Add(Class3);

                GpaClass Class4 = new GpaClass();
                Class4.ClassName = Class4NameBox.Text;
                switch (Class4DropDown.SelectedIndex)
                {
                    case 0:
                        Class4.ClassType = ParentClass.Types.Standard;
                        break;

                    case 1:
                        Class4.ClassType = ParentClass.Types.Honors;
                        break;

                    case 2:
                        Class4.ClassType = ParentClass.Types.Ap;
                        break;
                }

                switch (Class4GradeDropDown.SelectedIndex)
                {
                    case 0:
                        Class4.ClassGrade = Grade.A;
                        break;

                    case 1:
                        Class4.ClassGrade = Grade.B;
                        break;

                    case 2:
                        Class4.ClassGrade = Grade.C;
                        break;

                    case 3:
                        Class4.ClassGrade = Grade.D;
                        break;

                    case 4:
                        Class4.ClassGrade = Grade.F;
                        break;
                }

                InputList.Add(Class4);

                double total = 0;

                foreach (var input in InputList)
                {
                    if (Weighted)
                    {
                        if (input.ClassGrade == Grade.A)
                        {
                            switch (input.ClassType)
                            {
                                case ParentClass.Types.Standard:
                                    total += 4;
                                    break;

                                case ParentClass.Types.Honors:
                                    total += 4.5;
                                    break;

                                case ParentClass.Types.Ap:
                                    total += 5;
                                    break;
                            }
                        }
                        else if (input.ClassGrade == Grade.B)
                        {
                            switch (input.ClassType)
                            {
                                case ParentClass.Types.Standard:
                                    total += 3;
                                    break;

                                case ParentClass.Types.Honors:
                                    total += 3.5;
                                    break;

                                case ParentClass.Types.Ap:
                                    total += 4;
                                    break;
                            }
                        }
                        else if (input.ClassGrade == Grade.C)
                        {
                            switch (input.ClassType)
                            {
                                case ParentClass.Types.Standard:
                                    total += 2;
                                    break;

                                case ParentClass.Types.Honors:
                                    total += 2.5;
                                    break;

                                case ParentClass.Types.Ap:
                                    total += 3;
                                    break;
                            }
                        }
                        else if (input.ClassGrade == Grade.D)
                        {
                            switch (input.ClassType)
                            {
                                case ParentClass.Types.Standard:
                                    total += 1;
                                    break;

                                case ParentClass.Types.Honors:
                                    total += 1.5;
                                    break;

                                case ParentClass.Types.Ap:
                                    total += 2;
                                    break;
                            }
                        }
                        else if (input.ClassGrade == Grade.F)
                        {
                            switch (input.ClassType)
                            {
                                case ParentClass.Types.Standard:
                                    total += 0;
                                    break;

                                case ParentClass.Types.Honors:
                                    total += 0.5;
                                    break;

                                case ParentClass.Types.Ap:
                                    total += 1;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        switch (input.ClassGrade)
                        {
                            case Grade.A:
                                total += 4;
                                break;

                            case Grade.B:
                                total += 3;
                                break;

                            case Grade.C:
                                total += 2;
                                break;

                            case Grade.D:
                                total += 1;
                                break;

                            case Grade.F:
                                total += 0;
                                break;
                        }
                    }
                }

                double GPA = total / 4;

                await Window.ShowMessageAsync("GPA Calculated", $"Your GPA has been calculated at: {GPA}");
            }
            else
            {
                await Window.ShowMessageAsync("Error", "You must fill in all fields");
            }
        }

        public struct GpaClass
        {
            public Grade ClassGrade;
            public ParentClass.Types ClassType;
            public string ClassName;
        }
    }
}