using System;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using _10Calc.Pages;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace _10Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            
            NavigationCacheMode = NavigationCacheMode.Required;

            var rpn = new ReversePolishNotation();

            Loaded += Page_Loaded;

            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var settings = ApplicationData.Current.LocalSettings;
            if (!settings.Values.ContainsKey("WasLaunched"))
            {
                if (Frame != null) Frame.Navigate(typeof(IntroPage));
                settings.Values.Add("WasLaunched", true);
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
           
            
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Op = "";
        public double Num3 { get; set; }
        public string Log { get; set; }
       // public bool checker { get; set; }

       
       
        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button1.Content.ToString();
            ShowTextBlock.Text += Button1.Content.ToString();
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button2.Content.ToString();
            ShowTextBlock.Text += Button2.Content.ToString();
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button3.Content.ToString();
            ShowTextBlock.Text += Button3.Content.ToString();
        }

        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button4.Content.ToString();
            ShowTextBlock.Text += Button4.Content.ToString();
        }

        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button5.Content.ToString();
            ShowTextBlock.Text += Button5.Content.ToString(); 
        }

        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button6.Content.ToString();
            ShowTextBlock.Text += Button6.Content.ToString();
        }

        private void ButtonBase_OnClick7(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button7.Content.ToString();
            ShowTextBlock.Text += Button7.Content.ToString();
        }

        private void ButtonBase_OnClick8(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button8.Content.ToString();
            ShowTextBlock.Text += Button8.Content.ToString();
        }

        private void ButtonBase_OnClick9(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button9.Content.ToString();
            ShowTextBlock.Text += Button9.Content.ToString();
        }

        private void ButtonBase_OnClick0(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Button0.Content.ToString();
            ShowTextBlock.Text += Button0.Content.ToString();
        }

        private void ButtonBase_OnClickdot(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Buttondot.Content.ToString();
            ShowTextBlock.Text += Buttondot.Content.ToString();
        }

        private void ButtonBase_OnClickobrac(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Buttonobrac.Content;
            ShowTextBlock.Text += Buttonobrac.Content.ToString();
            Op = "brac";
        }

        private void ButtonBase_OnClickcbrac(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Buttoncbrac.Content;
            ShowTextBlock.Text += Buttoncbrac.Content.ToString();
            Op = "brac";
        }



        //private void ButtonBase_OnClickinf(object sender, RoutedEventArgs e)
        //{
        //    CalculateTextBlock.Text += ("0/0").ToString();
        //    ShowTextBlock.Text += "Inf.";
        //}

        private void ButtonBase_OnClickperc(object sender, RoutedEventArgs e)
        {
            if (Op == "brac")
            {
                CalculateTextBlock.Text += "";
                ShowTextBlock.Text += "";
            }
            else
            {
                Op = "";
                Num2 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                CalculateTextBlock.Text = ((Num1*Num2)/100).ToString();
                Num1 = 0;
                Num2 = 0;
            }

        }

        private void ButtonBase_OnClickupon(object sender, RoutedEventArgs e)
        {
            if(CalculateTextBlock.Text!="" && Op!="brac")
            {
            Num1 = Convert.ToDouble(CalculateTextBlock.Text);
            Op = "upon";
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text = "";
            Num2 = Math.Round(1/Num1,15);
            CalculateTextBlock.Text = Num2.ToString();
            Num1 = 0;
            ShowTextBlock.Text = "";
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "";
                }
                else
                {
                    CalculateTextBlock.Text = "";
                }
            }
        }

        private void ButtonBase_OnClicksquare(object sender, RoutedEventArgs e)
        {
            if(CalculateTextBlock.Text!="" && Op!="brac")
            {
            Num1 = Convert.ToDouble(CalculateTextBlock.Text);
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text = "";
            Num2 = Num1*Num1;
            CalculateTextBlock.Text = Num2.ToString();
            Num1 = 0;
            ShowTextBlock.Text = "";
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "^2";
                    ShowTextBlock.Text += "^2";
                }
                else
                {
                    CalculateTextBlock.Text = "";
                }
            }
        }

        private void ButtonBase_OnClickroot(object sender, RoutedEventArgs e)
        {
            if(CalculateTextBlock.Text!="" && Op!="brac")
            {
            Num1 = Convert.ToDouble(CalculateTextBlock.Text);
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text = "";
            Num2 = Math.Sqrt(Num1);
            CalculateTextBlock.Text = Num2.ToString();
            Num1 = 0;
            ShowTextBlock.Text = ""; 
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "√";
                    ShowTextBlock.Text += "√";
                }
                else
                {
                    CalculateTextBlock.Text = "";
                }
            }
        }

        private void ButtonBase_OnClickbackspace(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text == "" && ShowTextBlock.Text=="")
            {
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
            }
            else
            {
                string mystring = CalculateTextBlock.Text;
                string showstring = ShowTextBlock.Text;
                if (CalculateTextBlock.Text == "")
                {
                    CalculateTextBlock.Text = "";
                }
                else
                CalculateTextBlock.Text = mystring.Substring(0, mystring.Length - 1);
                if (ShowTextBlock.Text == "")
                    ShowTextBlock.Text = "";
                else
                ShowTextBlock.Text = showstring.Substring(0, showstring.Length - 1);
            }
                
            
        } 


        private void ButtonBase_OnClicklog(object sender, RoutedEventArgs e)
        {
            if(CalculateTextBlock.Text!="" && Op!="brac")
            {
            Num1 = Convert.ToDouble(CalculateTextBlock.Text);
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text = "";
            Num2 = Math.Log10(Num1);
            CalculateTextBlock.Text = Num2.ToString();
            Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "(log";
                    ShowTextBlock.Text += "(log";
                }
                else
                {
                    CalculateTextBlock.Text = "log";
                    ShowTextBlock.Text += "log" + CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3);
                    Op = "log";
                }
            }
            
        }

        private void ButtonBase_OnClickplus(object sender, RoutedEventArgs e)
        {
            if (Op == "brac")
            {
                ShowTextBlock.Text += "+";
                CalculateTextBlock.Text += "+";
            }
            else if (Op == "sub")
            {
                Num1 -= Convert.ToDouble(CalculateTextBlock.Text);
                Op = "plus";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
            }
            else if (Op == "mul")
            {
                Num1 *= Convert.ToDouble(CalculateTextBlock.Text);
                Op = "plus";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
            }
            else if (Op == "div")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                Num2 = Num3/Num1;
                Num1 = Num2;
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Op = "plus";
            }
           else if (Op == "log")
           {
               Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
               Num2 += Math.Log10(Num1);
               CalculateTextBlock.Text = "";
               ShowTextBlock.Text += "+";
               Num1 = 0;
               Log = "plus";
           }
           else if (Op == "" || Op == "plus")
           {
               if (Num2 != 0)
               {
                   ShowTextBlock.Text = Num2.ToString();
               }
               if (CalculateTextBlock.Text != "")
               {
                   Num1 += Convert.ToDouble(CalculateTextBlock.Text);
                   Op = "plus";
                   CalculateTextBlock.Text = "";
                   ShowTextBlock.Text += "+";
               }
               else
               {
                   CalculateTextBlock.Text = "";
               }
           }
        }

        private void ButtonBase_OnClickminus(object sender, RoutedEventArgs e)
        {
            if (Op == "brac")
            {
                CalculateTextBlock.Text += "-";
                ShowTextBlock.Text += "-";
            }
            else if (Op == "plus")
            {
                Num1 += Convert.ToDouble(CalculateTextBlock.Text);
                Op = "sub";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "-";
            }
            else if (Op == "mul")
            {
                Num1 *= Convert.ToDouble(CalculateTextBlock.Text);
                Op = "sub";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "-";
            }
            else if (Op == "div")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                Num2 = Num3 / Num1;
                Num1 = Num2;
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "-";
                Op = "sub";
            }

            else if (Op == "log")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num2 -= Math.Log10(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "-";
                Num1 = 0;
                Log = "plus";
            }
            else if (Op == "" || Op == "sub")
            {
                if (Num2 != 0)
                {
                    ShowTextBlock.Text = Num2.ToString();
                }
                if (CalculateTextBlock.Text != "")
                {
                    Num1 = double.Parse(CalculateTextBlock.Text);
                    Op = "sub";
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "-";
                }
                else
                {
                    CalculateTextBlock.Text = "";
                }
            }
        }

        private void ButtonBase_OnClickmul(object sender, RoutedEventArgs e)
        {
            if (Op == "brac")
            {
                CalculateTextBlock.Text += "*";
                ShowTextBlock.Text += "*";
            }
            else if (Op == "plus")
            {
                Num1 += Convert.ToDouble(CalculateTextBlock.Text);
                Op = "mul";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "*";
            }
            else if (Op == "sub")
            {
                Num1 -= Convert.ToDouble(CalculateTextBlock.Text);
                Op = "mul";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "*";
            }
            else if (Op == "div")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                Num2 = Num3 / Num1;
                Num1 = Num2;
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "*";
                Op = "mul";
            }

            else if (Op == "log")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                    Num2 *= Math.Log10(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Log = "mul";
                }
            }
            else if (Op == "" || Op == "mul")
            {
                if (Num2 != 0)
                {
                    ShowTextBlock.Text = Num2.ToString();
                }
                if (Num1 == 0)
                    Num1 = 1;
                if (CalculateTextBlock.Text != "")
                {
                    Num1 *= double.Parse(CalculateTextBlock.Text);
                    Op = "mul";
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                }
            }
            else
            {
                CalculateTextBlock.Text = "";
            }
        }

        private void ButtonBase_OnClickdiv(object sender, RoutedEventArgs e)
        {
            if (Op == "brac")
            {
                CalculateTextBlock.Text += "/";
                ShowTextBlock.Text += "/";
            }
            else if (Op == "plus")
            {
                Num1 += Convert.ToDouble(CalculateTextBlock.Text);
                Op = "div";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "/";
            }
            else if (Op == "sub")
            {
                Num1 -= Convert.ToDouble(CalculateTextBlock.Text);
                Op = "div";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "/";
            }
            else if (Op == "mul")
            {
                Num1 *= Convert.ToDouble(CalculateTextBlock.Text);
                Op = "div";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "/";
            }
            else if (Op == "log")
            {
                if (Num3 == 0)
                {
                    Num3 = Math.Log10(Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)));
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 =
                        Math.Log10(
                            Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)));
                    CalculateTextBlock.Text = "";
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "/";
                    Num1 = 0;
                    Log = "div";
                }
            }
            else if (Op == "" || Op == "div")
            {

                if (Num2 != 0)
                {
                    ShowTextBlock.Text = Num2.ToString();
                }
                if (CalculateTextBlock.Text != "")
                {
                    if (Num3 == 0)
                    {
                        Num3 = double.Parse(CalculateTextBlock.Text);
                        Op = "div";
                        ShowTextBlock.Text += "/";
                    }
                    else
                    {
                        Num1 = double.Parse(CalculateTextBlock.Text);
                        Num1 = Num3/Num1;
                        Num3 = Num1;
                        Op = "div";
                        CalculateTextBlock.Text = "";
                        ShowTextBlock.Text += "/";
                    }
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    CalculateTextBlock.Text = "";
                }
            }
        }

        private void ButtonBase_OnClickequal(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text=="")
            {
                CalculateTextBlock.Text = "";
            }
            else
            {

                switch (Op)
                {
                    case "brac":
                        try
                        {
                            var rpn = new ReversePolishNotation();
                            rpn.Parse(ShowTextBlock.Text);
                            var result = rpn.Evaluate();
                            CalculateTextBlock.Text = result.ToString();
                        }
                        catch (Exception)
                        {

                            CalculateTextBlock.Text = "Error!";
                        }
                        break;
                        
                    case "":
                        Num2 = double.Parse(CalculateTextBlock.Text);
                        break;
                    case "plus":
                        Num2 = Num1 + double.Parse(CalculateTextBlock.Text);
                        break;

                    case "sub":
                        Num2 = Num1 - double.Parse(CalculateTextBlock.Text);
                        break;

                    case "mul":
                        Num2 = Num1*double.Parse(CalculateTextBlock.Text);
                        break;

                    case "div":
                        Num2 = Num3/double.Parse(CalculateTextBlock.Text);
                        break;

                    case "log":
                        switch (Log)
                        {
                            case "plus":

                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num2 += Math.Log10(Num1);
                                ShowTextBlock.Text = "";
                                break;
                            case "minus":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num2 -= Math.Log10(Num1);
                                ShowTextBlock.Text = "";
                                break;
                            case "mul":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num2 *= Math.Log10(Num1);
                                ShowTextBlock.Text = "";
                                break;
                            case "div":
                                Num1 =
                                    Math.Log10(Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)));
                                Num2 = Num3 / Num1;
                                ShowTextBlock.Text = "";
                                break;
                            default:
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num2 += Math.Log10(Num1);
                                ShowTextBlock.Text = "";
                                break;
                        }
                        break;



                }
                if (Op == "brac")
                {
                    Op = "";
                    ShowTextBlock.Text = "";
                    Num1 = 0;
                    Num3 = 0;

                }
                else
                {
                    CalculateTextBlock.Text = Num2.ToString();
                    Num1 = 0;
                    Num3 = 0;
                    ShowTextBlock.Text = "";
                    Op = "";
                }
            }
        }

        private void ButtonBase_OnClickclear(object sender, RoutedEventArgs e)
        {
            Num1 = 0;
            Num2 = 0;
            Num3 = 0;
            ShowTextBlock.Text = "";
            CalculateTextBlock.Text = "";
            Op = "";
        }

        private void ScientificButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (Scientific));
        }

        private void AboutButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (AboutPage));
        }

        private void UnitButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (UnitConverter));
        }

        private void SettingsButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (SettingsPage));
        }

        private void ProgrammerButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (Programmer_s_Calculator));
        }
    }
}
