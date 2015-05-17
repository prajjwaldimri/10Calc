using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

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

        public double num1 { get; set; }
        public double num2 { get; set; }
        public string op { get; set; }
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
        }

        private void ButtonBase_OnClickcbrac(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Buttoncbrac.Content;
            ShowTextBlock.Text += Buttoncbrac.Content.ToString();
        }



        //private void ButtonBase_OnClickinf(object sender, RoutedEventArgs e)
        //{
        //    CalculateTextBlock.Text += ("0/0").ToString();
        //    ShowTextBlock.Text += "Inf.";
        //}

        private void ButtonBase_OnClickperc(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(CalculateTextBlock.Text);
            op = "perc";
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text = "";
        }

        private void ButtonBase_OnClickupon(object sender, RoutedEventArgs e)
        {
            if(CalculateTextBlock.Text!="")
            {
            num1 = Convert.ToDouble(CalculateTextBlock.Text);
            op = "upon";
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text = "";
            num2 = 1/num1;
            CalculateTextBlock.Text = num2.ToString();
            num1 = 0;
            ShowTextBlock.Text = "";
            }
            else
            {
                CalculateTextBlock.Text = "";
            }
        }

        private void ButtonBase_OnClicksquare(object sender, RoutedEventArgs e)
        {
            if(CalculateTextBlock.Text!="")
            {
            num1 = Convert.ToDouble(CalculateTextBlock.Text);
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text = "";
            num2 = num1*num1;
            CalculateTextBlock.Text = num2.ToString();
            num1 = 0;
            ShowTextBlock.Text = "";
            }
            else
            {
                CalculateTextBlock.Text = "";
            }
        }

        private void ButtonBase_OnClickroot(object sender, RoutedEventArgs e)
        {
            if(CalculateTextBlock.Text!="")
            {
            num1 = Convert.ToDouble(CalculateTextBlock.Text);
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text = "";
            num2 = Math.Sqrt(num1);
            CalculateTextBlock.Text = num2.ToString();
            num1 = 0;
            ShowTextBlock.Text = ""; 
            }
            else
            {
                CalculateTextBlock.Text = "";
            }
        }

        private void ButtonBase_OnClickbackspace(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text == "")
            {
                CalculateTextBlock.Text = "";
            }
            else
            {
                string mystring = CalculateTextBlock.Text;
                string showstring = ShowTextBlock.Text;
                CalculateTextBlock.Text = mystring.Substring(0, mystring.Length - 1);
                if (ShowTextBlock.Text == "")
                    ShowTextBlock.Text = "";
                else
                ShowTextBlock.Text = showstring.Substring(0, showstring.Length - 1);
            }
                
            
        } 


        private void ButtonBase_OnClicklog(object sender, RoutedEventArgs e)
        {
            if(CalculateTextBlock.Text!="")
            {
            num1 = Convert.ToDouble(CalculateTextBlock.Text);
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text = "";
            num2 = Math.Log10(num1);
            CalculateTextBlock.Text = num2.ToString();
            num1 = 0;
            }
            else
            {
                CalculateTextBlock.Text = "";
            }
            
        }

        private void ButtonBase_OnClickplus(object sender, RoutedEventArgs e)
        {
            //num1 += double.Parse(CalculateTextBlock.Text);
            if (num2!=0)
            {
                ShowTextBlock.Text = num2.ToString();
            }
            if(CalculateTextBlock.Text!="")
            {
            num1 = Convert.ToDouble(CalculateTextBlock.Text);
            op = "plus";
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text += "+";
            }
            else
            {
                CalculateTextBlock.Text = "";
            }
        }

        private void ButtonBase_OnClickminus(object sender, RoutedEventArgs e)
        {
            if (num2 != 0)
            {
                ShowTextBlock.Text = num2.ToString();
            }
            if(CalculateTextBlock.Text!="")
            {
            num1 += double.Parse(CalculateTextBlock.Text);
            op = "sub";
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text += "-";
            }
            else
            {
                CalculateTextBlock.Text = "";
            }
        }

        private void ButtonBase_OnClickmul(object sender, RoutedEventArgs e)
        {
            if (num2 != 0)
            {
                ShowTextBlock.Text = num2.ToString();
            }
            if (CalculateTextBlock.Text != "")
            {
                num1 += double.Parse(CalculateTextBlock.Text);
                op = "mul";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "*";
            }
            else
            {
                CalculateTextBlock.Text = "";
            }
        }

        private void ButtonBase_OnClickdiv(object sender, RoutedEventArgs e)
        {
            if (num2 != 0)
            {
                ShowTextBlock.Text = num2.ToString();
            }
            if(CalculateTextBlock.Text!="")
            {
            num1 += double.Parse(CalculateTextBlock.Text);
            op = "div";
            CalculateTextBlock.Text = "";
            ShowTextBlock.Text += "/";
            }
            else
            {
                CalculateTextBlock.Text = "";
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

                switch (op)
                {
                    case "plus":
                        num2 = num1 + double.Parse(CalculateTextBlock.Text);
                        break;

                    case "sub":
                        num2 = num1 - double.Parse(CalculateTextBlock.Text);
                        break;

                    case "mul":
                        num2 = num1*double.Parse(CalculateTextBlock.Text);
                        break;

                    case "div":
                        num2 = num1/double.Parse(CalculateTextBlock.Text);
                        break;


                }
                CalculateTextBlock.Text = num2.ToString();
                num1 = 0;
                ShowTextBlock.Text = "";
                op = "";
            }
        }

        private void ButtonBase_OnClickclear(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            ShowTextBlock.Text = "";
            CalculateTextBlock.Text = "";
        }

    }
}
