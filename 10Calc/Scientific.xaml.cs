using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using _10Calc.Common;
using _10Calc.Pages;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace _10Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scientific : Page
    {
        private NavigationHelper _navigationHelper;
        private ObservableDictionary _defaultViewModel = new ObservableDictionary();

        public Scientific()
        {
            InitializeComponent();

            _navigationHelper = new NavigationHelper(this);
            _navigationHelper.LoadState += NavigationHelper_LoadState;
            _navigationHelper.SaveState += NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return _navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return _defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Num3 { get; set; }
        public int I { get; set; }
        public int Fact { get; set; }
        public string Operand { get; set; }
        public string Op { get; set; }
        public string Log { get; set; }
        public string Trig { get; set; }
        public double Pi = Math.Round(Math.PI, 10);
        public bool Visible = false;
     
        #region Buttons
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
        }

        private void ButtonBase_OnClickpi(object sender, RoutedEventArgs e)
        {
            CalculateTextBlock.Text += Pi.ToString();
            ShowTextBlock.Text += "Pi";
            Op = "brac";
        }

        #endregion

        #region Basic Functions
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
                CalculateTextBlock.Text = ((Num1 * Num2) / 100).ToString();
            }

        }

        private void ButtonBase_OnClickupon(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                Op = "upon";
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = Math.Round(1 / Num1, 15);
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
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = Num1 * Num1;
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

        private void ButtonBase_OnClickcube(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = Num1 * Num1 * Num1;
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
                ShowTextBlock.Text = "";
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text = "^3";
                    ShowTextBlock.Text += "^3";
                }
                else
                {
                    CalculateTextBlock.Text = "";
                }
            }
        }

        private void ButtonBase_OnClickfourpow(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = Num1 * Num1 * Num1 * Num1;
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
                ShowTextBlock.Text = "";
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text = "^4";
                    ShowTextBlock.Text += "^4";
                }
                else
                {
                    CalculateTextBlock.Text = "";
                }
            }
        }

       
        private void ButtonBase_OnClickn(object sender, RoutedEventArgs e)
        {
            Op = "";
            if (CalculateTextBlock.Text != "" && Op!="brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "^";
                CalculateTextBlock.Text = "n=";
                Op = "n";
            }
            else
            {
                CalculateTextBlock.Text += "";
                ShowTextBlock.Text += "";
            }
        }

        private void ButtonBase_OnClickdeg(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op!="brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                Num2 += Num1*(180/Pi);
                CalculateTextBlock.Text = Num2.ToString();
                ShowTextBlock.Text = "";
                Num1 = 0;
                Num2 = 0;
            }
            else
            {
                CalculateTextBlock.Text += "";
                ShowTextBlock.Text += "";
            }
        }

        private void ButtonBase_OnClickrad(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op!="brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                Num2 += Num1 / (180 / Pi);
                CalculateTextBlock.Text = Num2.ToString();
                ShowTextBlock.Text = "";
                Num1 = 0;
                Num2 = 0;
            }
            else
            {
                CalculateTextBlock.Text += "";
                ShowTextBlock.Text += "";
            }
        }


        private void ButtonBase_OnClickgrad(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                Num2 += 1.11111111111 * Num1;
                CalculateTextBlock.Text = Num2.ToString();
                ShowTextBlock.Text = "";
                Num1 = 0;
                Num2 = 0;
            }
            else
            {
                CalculateTextBlock.Text += "";
                ShowTextBlock.Text += "";
            }
        }

        private void ButtonBase_OnClickex(object sender, RoutedEventArgs e)
        {
            if (Op == "brac")
            {
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "e^";
            }
            else if (CalculateTextBlock.Text != "")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                Num2 += Math.Exp(Num1);
                CalculateTextBlock.Text = Num2.ToString();
                ShowTextBlock.Text = "";
            }
            else
                CalculateTextBlock.Text = "";
        }

        private void ButtonBase_OnClickunderrootn(object sender, RoutedEventArgs e)
        {
            Op = "";
            if (CalculateTextBlock.Text != "" && Op!="brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "^";
                CalculateTextBlock.Text = "x=";
                Op = "rootn";
            }
            else
            {
                CalculateTextBlock.Text += "";
                ShowTextBlock.Text += "";
            }
        }



        private void ButtonBase_OnClickroot(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op!="brac")
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
                if (Op != "brac") return;
                CalculateTextBlock.Text += "√";
                ShowTextBlock.Text += "√";
            }
        }

        private void ButtonBase_OnClickbackspace(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text == "" && ShowTextBlock.Text == "")
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
        #endregion

        #region Logarithmic
        private void ButtonBase_OnClicklog(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                 Num2 = Math.Log10(Num1);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
                Op = "log";
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

        private void ButtonBase_OnClickloge(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = Math.Log(Num1);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
                Op = "loge";
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "(loge";
                    ShowTextBlock.Text += "(loge";
                }
                else
                {
                    CalculateTextBlock.Text = "log";
                    ShowTextBlock.Text += "loge" +
                                          CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3);
                    Op = "loge";
                }
            }
        }

        private void ButtonBase_OnClicklogn(object sender, RoutedEventArgs e)
        {
            Op = "";
            if (CalculateTextBlock.Text != "")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                CalculateTextBlock.Text = "n=";
                Op = "e";
            }
            else
            {
                CalculateTextBlock.Text = "";
            }
        }
        #endregion

        #region Trignometry
        private void Buttonsin_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op!="brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num1 = Num1 * (Pi / 180);
                Num2 = Math.Round(Math.Sin(Num1),10);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "sin";
                    ShowTextBlock.Text += "sin";
                }
                else
                {
                    CalculateTextBlock.Text = "sin";
                    ShowTextBlock.Text += "sin" +
                                          CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3);
                    Op = "sin";
                }
                
            }
        }

        private void Buttoncos_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num1 = Num1 * (Pi / 180);
                Num2 = Math.Round(Math.Cos(Num1),10);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "cos";
                    ShowTextBlock.Text += "cos";
                }
                else
                {
                    CalculateTextBlock.Text = "cos";
                    ShowTextBlock.Text += "cos" +
                                          CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3);
                    Op = "cos";
                }
            }
        }

        private void Buttontan_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num1 = Num1 * (Pi / 180);
                Num2 = Math.Round(Math.Tan(Num1),10);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "tan";
                    ShowTextBlock.Text += "tan";
                }
                else
                {
                    CalculateTextBlock.Text = "tan";
                    ShowTextBlock.Text += "tan" +
                                          CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3);
                    Op = "tan";
                }
            }
        }

        private void Buttoncot_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num1 = Num1 * (Pi / 180);
                Num2 = Math.Round(1/Math.Tan(Num1), 10);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "cot";
                    ShowTextBlock.Text += "cot";
                }
                else
                {
                    CalculateTextBlock.Text = "cot";
                    ShowTextBlock.Text += "cot" +
                                          CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3);
                    Op = "cot";
                }
            }
        }

        private void Buttonsec_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num1 = Num1 * (Pi / 180);
                Num2 = Math.Round(1/Math.Cos(Num1),10);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "sec";
                    ShowTextBlock.Text += "sec";
                }
                else
                {
                    CalculateTextBlock.Text = "sec";
                    ShowTextBlock.Text += "sec" +
                                          CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3);
                    Op = "sec";
                }
            }
        }

        private void Buttoncosec_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num1 = Num1 * (Pi / 180);
                Num2 = Math.Round(1/Math.Sin(Num1),10);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "cosec";
                    ShowTextBlock.Text += "cosec";
                }
                else
                {
                    CalculateTextBlock.Text = "cosec";
                    ShowTextBlock.Text += "cosec" +
                                          CalculateTextBlock.Text.Substring(5, CalculateTextBlock.Text.Length - 5);
                    Op = "cosec";
                }
            }
        }

        private void Buttonasin_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = Math.Asin(Num1) *(180/Pi);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "asin";
                    ShowTextBlock.Text += "asin";
                }
                else
                {
                    CalculateTextBlock.Text = "asin";
                    ShowTextBlock.Text += "asin" +
                                          CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4);
                    Op = "asin";
                }
            }
        }

        private void Buttonacos_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = Math.Acos(Num1) * (180 / Pi);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "acos";
                    ShowTextBlock.Text += "acos";
                }
                else
                {
                    CalculateTextBlock.Text = "acos";
                    ShowTextBlock.Text += "acos" +
                                          CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4);
                    Op = "acos";
                }
            }
        }

        private void Buttonatan_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "atan";
                    ShowTextBlock.Text += "atan";
                }
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text = "";
                    Num2 = Math.Atan(Num1)*(180/Pi);
                    CalculateTextBlock.Text = Num2.ToString();
                    Num1 = 0;
                }
            }
            else
            {
                CalculateTextBlock.Text = "atan";
                ShowTextBlock.Text += "atan" +
                                      CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4);
                Op = "atan";
            }
        }

        private void Buttonacot_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = 1 / Math.Atan(Num1) * (180 / Pi);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "acot";
                    ShowTextBlock.Text += "acot";
                }
                else
                {
                    CalculateTextBlock.Text = "acot";
                    ShowTextBlock.Text += "acot" +
                                          CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4);
                    Op = "acot";
                }
            }
        }

        private void Buttonasec_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = 1 / Math.Acos(Num1) * (180 / Pi);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "asec";
                    ShowTextBlock.Text += "asec";
                }
                else
                {
                    CalculateTextBlock.Text = "asec";
                    ShowTextBlock.Text += "asec" +
                                          CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4);
                    Op = "asec";
                }
            }
        }

        private void Buttonacosec_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" && Op != "brac")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text = "";
                Num2 = 1 / Math.Asin(Num1) * (180 / Pi);
                CalculateTextBlock.Text = Num2.ToString();
                Num1 = 0;
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "acosec";
                    ShowTextBlock.Text += "acosec";
                }
                else
                {
                    CalculateTextBlock.Text = "acosec";
                    ShowTextBlock.Text += "acosec" +
                                          CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6);
                    Op = "acosec";
                }
            }
        }

        #endregion

        #region (+,-,*,/)
        private void ButtonBase_OnClickplus(object sender, RoutedEventArgs e)
        {
            if (Op == "brac")
            {
                CalculateTextBlock.Text += "+";
                ShowTextBlock.Text += "+";
            }
            else if (Op == "sin")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 += Math.Sin(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";

            }
            else if (Op == "cos")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 += Math.Cos(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";
            }
            else if (Op == "tan")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 += Math.Tan(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";

            }
            else if (Op == "cot")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 += 1 / Math.Tan(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";

            }
            else if (Op == "sec")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 += 1 / Math.Cos(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";
            }
            else if (Op == "cosec")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(5, CalculateTextBlock.Text.Length - 5));
                Num1 = Num1 * ((Pi) / 180);
                Num2 += 1 / Math.Sin(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";
 
            }
            else if (Op == "asin")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 += Math.Asin(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";
            }
            else if (Op == "acos")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 += Math.Acos(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";

            }
            else if (Op == "atan")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 += Math.Atan(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";

            }
            else if (Op == "acot")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 += 1 / Math.Atan(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";

            }
            else if (Op == "asec")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 += 1 / Math.Acos(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";

            }
            else if (Op == "acosec")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6));
                Num2 += 1/Math.Asin(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "plus";

            }
            else if (Op == "log")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length-3));
                Num2 += Math.Log10(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Log = "plus";
            }
            else if (Op == "loge")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length-3));
                Num2 += Math.Log(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Log = "plus";
            }
            else if (Op == "root")
            {
                Operand = CalculateTextBlock.Text.Substring(2, CalculateTextBlock.Text.Length - 2);
                Num3 = Convert.ToDouble(Operand);
                ShowTextBlock.Text = "";
                Num2 += Math.Log(Num1, Num3);
                Log = "plus";
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
                Num2 = Num3 / Num1;
                Num1 = Num2;
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Op = "plus";
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
                Trig = "plus";
            }
        }

        private void ButtonBase_OnClickminus(object sender, RoutedEventArgs e)
        {
            if (Op == "brac")
            {
                CalculateTextBlock.Text += "-";
                ShowTextBlock.Text += "-";
            }
            else if (Op == "sin")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 -= Math.Sin(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";

            }
            else if (Op == "cos")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 -= Math.Cos(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";

            }
            else if (Op == "tan")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 -= Math.Tan(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";

            }
            else if (Op == "cot")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 -= 1 / Math.Tan(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";
            }
            else if (Op == "sec")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                Num1 = Num1 * ((Pi) / 180);
                Num2 -= 1 / Math.Cos(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";

            }
            else if (Op == "cosec")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(5, CalculateTextBlock.Text.Length - 5));
                Num1 = Num1 * ((Pi) / 180);
                Num2 -= 1 / Math.Sin(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";

            }
            else if (Op == "asin")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 -= Math.Asin(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";
            }
            else if (Op == "acos")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 -= Math.Acos(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";

            }
            else if (Op == "atan")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 -= Math.Atan(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";

            }
            else if (Op == "acot")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 -= 1 / Math.Atan(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";
            }
            else if (Op == "asec")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                Num2 -= 1 / Math.Acos(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";
            }
            else if (Op == "acosec")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6));
                Num2 -= 1 / Math.Asin(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Trig = "minus";
            }
            else if (Op == "log")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length-3));
                Num2 -= Math.Log10(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Log = "minus";
            }
            else if (Op == "loge")
            {
                Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length-3));
                Num2 -= Math.Log(Num1);
                CalculateTextBlock.Text = "";
                ShowTextBlock.Text += "+";
                Num1 = 0;
                Log = "minus";
            }
            else if (Op == "n")
            {
                Operand = CalculateTextBlock.Text.Substring(2, CalculateTextBlock.Text.Length - 2);
                Num3 = Convert.ToDouble(Operand);
                ShowTextBlock.Text = "";
                Num2 -= Math.Log(Num1, Num3);
                Log = "minus";
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
            else if (Op == "sin")
            {
                if (Num2 == 0)
                    Num2 = 1;
                
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                    Num1 = Num1 * ((Pi) / 180);
                    Num2 *= Math.Sin(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                

            }
            else if (Op == "cos")
            {
                if (Num2 == 0)
                    Num2 = 1;
                
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                    Num1 = Num1 * ((Pi) / 180);
                    Num2 *= Math.Cos(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                

            }
            else if (Op == "tan")
            {
                if (Num2 == 0)
                    Num2 = 1;
                
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                    Num1 = Num1 * ((Pi) / 180);
                    Num2 *= Math.Tan(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                

            }
            else if (Op == "cot")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                    Num1 = Num1 * ((Pi) / 180);
                    Num2 *= 1 / Math.Tan(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                }
            }
            else if (Op == "sec")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                    Num1 = Num1 * ((Pi) / 180);
                    Num2 *= 1 / Math.Cos(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                }

            }
            else if (Op == "cosec")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(5, CalculateTextBlock.Text.Length - 5));
                    Num1 = Num1 * ((Pi) / 180);
                    Num2 *= 1 / Math.Sin(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                }

            }
            else if (Op == "asin")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                    Num2 *= Math.Asin(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                }
            }
            else if (Op == "acos")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                    Num2 *= Math.Acos(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                }
            }
            else if (Op == "atan")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                    Num2 *= Math.Atan(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                }

            }
            else if (Op == "acot")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                    Num2 *= 1 / Math.Atan(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                }
            }
            else if (Op == "asec")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                    Num2 *= 1 / Math.Acos(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                }
            }
            else if (Op == "acosec")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6));
                    Num2 *= 1/Math.Asin(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "mul";
                }
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
                    ShowTextBlock.Text += "+";
                    Num1 = 0;
                    Log = "mul";
                }
            }
            else if (Op == "loge")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                    Num2 *= Math.Log(Num1);
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "+";
                    Num1 = 0;
                    Log = "mul";
                }
            }
            else if (Op == "n")
            {
                if (Num2 == 0)
                    Num2 = 1;
                else
                {
                    Operand = CalculateTextBlock.Text.Substring(2, CalculateTextBlock.Text.Length - 2);
                    Num3 = Convert.ToDouble(Operand);
                    ShowTextBlock.Text = "";
                    Num2 *= Math.Log(Num1, Num3);
                    Log = "mul";
                }
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
            else if (Op == "sin")
            {
                if (Num3 == 0)
                {
                    Num3 = 
                           Math.Sin((
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3))) * (Pi / 180));
                    
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = Math.Sin(Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)) * (Pi / 180));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }
            }
            else if (Op == "cos")
            {
                if (Num3 == 0)
                {
                    Num3 = Math.Cos(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)) * (Pi / 180));
                    Num3 = Num3 * ((Pi) / 180);
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = Math.Cos(Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)) * (Pi / 180));
                    Num1 = Num1 * ((Pi) / 180);
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }

            }
            else if (Op == "tan")
            {
                if (Num3 == 0)
                {
                    Num3 = Math.Tan(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)) * (Pi / 180));
                    Num3 = Num3 * ((Pi) / 180);
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = Math.Tan(Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)) * (Pi / 180));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }
            }
            else if (Op == "cot")
            {
                if (Num3 == 0)
                {
                    Num3 = 1 /
                           Math.Tan(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)) * (Pi / 180));
                    Num3 = Num3 * ((Pi) / 180);
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = 1 / Math.Tan(Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)) * (Pi / 180));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }
            }
            else if (Op == "sec")
            {
                if (Num3 == 0)
                {
                    Num3 = 1 /
                           Math.Cos(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)) * (Pi / 180));
                    Num3 = Num3 * ((Pi) / 180);
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = 1 / Math.Cos(Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)) * (Pi / 180));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }

            }
            else if (Op == "cosec")
            {
                if (Num3 == 0)
                {
                    Num3 = 1 /
                           Math.Sin(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(5, CalculateTextBlock.Text.Length - 5)) * (Pi / 180));
                    Num3 = Num3 * ((Pi) / 180);
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = 1 / Math.Sin(Convert.ToDouble(CalculateTextBlock.Text.Substring(5, CalculateTextBlock.Text.Length - 5)) * (Pi / 180));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }

            }
            else if (Op == "asin")
            {
                if (Num3 == 0)
                {
                    Num3 = 
                           Math.Asin(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = Math.Asin(Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }
            }
            else if (Op == "acos")
            {
                if (Num3 == 0)
                {
                    Num3 = Math.Acos(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = Math.Acos(Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }
            }
            else if (Op == "atan")
            {
                if (Num3 == 0)
                {
                    Num3 = Math.Atan(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = Math.Atan(Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }

            }
            else if (Op == "acot")
            {
                if (Num3 == 0)
                {
                    Num3 = 1 /
                           Math.Atan(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = 1 / Math.Atan(Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }
            }
            else if (Op == "asec")
            {
                if (Num3 == 0)
                {
                    Num3 = 1 /
                           Math.Acos(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = 1 / Math.Acos(Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4)));
                    Num2 = Num3 / Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }
            }
            else if (Op == "acosec")
            {
                if (Num3 == 0)
                {
                    Num3 = 1/
                           Math.Asin(
                               Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6)));
                    CalculateTextBlock.Text = "";
                }
                 else
                {
                    Num1 = 1/Math.Asin(Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6)));
                    Num2 = Num3/Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "*";
                    Num1 = 0;
                    Trig = "div";
                }
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
                    Num2 = Num3/Num1;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "+";
                    Num1 = 0;
                    Log = "div";
                }
            }
            else if (Op == "loge")
            {
                if (Num3 == 0)
                {
                    Num3 =
                        Math.Log10(
                            Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)));
                    CalculateTextBlock.Text = "";
                }
                else
                {
                    Num1 = Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                    Num2 = Num3/Num2;
                    Num3 = Num2;
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "+";
                    Num1 = 0;
                    Log = "div";
                }
            }
            else if (Op == "n")
            {
                Num2 = 1;
                Operand = CalculateTextBlock.Text.Substring(2, CalculateTextBlock.Text.Length - 2);
                Num3 = Convert.ToDouble(Operand);
                ShowTextBlock.Text = "";
                Num2 /= Math.Log(Num1, Num3);
                Log = "div";
            }
            if (Op == "plus")
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
                        Num1 = Num3 / Num1;
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
        #endregion

        private void Buttonfact_OnClick(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text != "" & Op!="brac")
            {
                Num2 = 1;
                Fact = int.Parse(CalculateTextBlock.Text);
                for (I = Fact; I > 1; I--)
                {
                    Num2 = Num2*Fact;
                    Fact--;
                }
                CalculateTextBlock.Text = "";
                CalculateTextBlock.Text = Num2.ToString();
                ShowTextBlock.Text = "";
            }
            else
            {
                if (Op == "brac")
                {
                    CalculateTextBlock.Text += "";
                    ShowTextBlock.Text += "";
                }
                else
                {
                    CalculateTextBlock.Text = "";
                    ShowTextBlock.Text += "";
                }
            }
        }

     

        private void ButtonBase_OnClickequal(object sender, RoutedEventArgs e)
        {
            if (CalculateTextBlock.Text == "")
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

                    case "n":
                        Operand = CalculateTextBlock.Text.Substring(2, CalculateTextBlock.Text.Length - 2);
                        Num3 = Convert.ToDouble(Operand);
                        ShowTextBlock.Text = "";
                        Num2 = Math.Pow(Num1, Num3);

                        ShowTextBlock.Text = "";
                        break;

                    case "e":
                        Operand = CalculateTextBlock.Text.Substring(2, CalculateTextBlock.Text.Length - 2);
                        Num3 = Convert.ToDouble(Operand);
                        ShowTextBlock.Text = "";
                        Num2 = Math.Log(Num1, Num3);
                        break;

                    case "rootn":
                        Operand = CalculateTextBlock.Text.Substring(2, CalculateTextBlock.Text.Length - 2);
                        Num3 = Convert.ToDouble(Operand);
                        ShowTextBlock.Text = "";
                        Num2 = Math.Pow(Num1, 1/Num3);
                        break;

                    case "sin":
                        switch (Trig)
                        {
                            case "plus":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num1 = Num1 * ((Pi) / 180);
                                Num2 += Math.Round(Math.Sin(Num1),10);
                                ShowTextBlock.Text = "";
                                break;
                            case "minus":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num1 = Num1 * ((Pi) / 180);
                                Num2 += Math.Round(Math.Sin(Num1), 10);
                                ShowTextBlock.Text = "";
                                break;
                            case "mul":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num1 = Num1 * ((Pi) / 180);
                                Num2 *= Math.Round(Math.Sin(Num1), 10);
                                ShowTextBlock.Text = "";
                                break;
                            case "div":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num2 = Num3/Num1;
                                ShowTextBlock.Text = "";
                                break;
                            default:
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num1 = Num1 * ((Pi) / 180);
                                Num2 += Math.Round(Math.Sin(Num1), 10);
                                ShowTextBlock.Text = "";
                                break;
                        }
                       break;

                    case "cos": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 += Math.Round(Math.Cos(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 -= Math.Round(Math.Cos(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 *= Math.Round(Math.Cos(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                           Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                           Num1 = Num1 * ((Pi) / 180);
                               Num2 += Math.Round(Math.Cos(Num1),10);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "tan": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 += Math.Round(Math.Tan(Num1),10);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 -= Math.Round(Math.Tan(Num1),10);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 *= Math.Round(Math.Tan(Num1),10);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 += Math.Round(Math.Tan(Num1),10);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "cot": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 += Math.Round(1/Math.Tan(Num1),10);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 -= Math.Round(1 / Math.Tan(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 *= Math.Round(1 / Math.Tan(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 += Math.Round(1 / Math.Tan(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "sec": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 += Math.Round(1 / Math.Cos(Num1),10);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 -= Math.Round(1 / Math.Cos(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 *= Math.Round(1 / Math.Cos(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                                Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num1 = Num1 * ((Pi) / 180);
                                Num2 += Math.Round(1 / Math.Cos(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "cosec": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 5));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 += Math.Round(1 / Math.Sin(Num1),10);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 5));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 -= Math.Round(1 / Math.Sin(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 5));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 *= Math.Round(1 / Math.Sin(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 5));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 5));
                               Num1 = Num1 * ((Pi) / 180);
                               Num2 += Math.Round(1 / Math.Sin(Num1), 10);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "asin": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += Math.Asin(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 = Math.Asin(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 *= Math.Asin(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += Math.Asin(Num1);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "acos": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += Math.Acos(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 -= Math.Acos(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 *= Math.Acos(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += Math.Acos(Num1);
                               Num2 = Num2 * (180 / Pi);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "atan": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += Math.Atan(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 -= Math.Atan(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 *=  Math.Atan(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                                Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += Math.Atan(Num1);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "acot": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += 1 / Math.Atan(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 -= 1 / Math.Atan(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 *= 1 / Math.Atan(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                              Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += 1 / Math.Atan(Num1);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "asec": switch (Trig)
                       {
                           case "plus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += 1 / Math.Acos(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "minus":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 -= 1 / Math.Acos(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "mul":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 *= 1 / Math.Acos(Num1);
                               ShowTextBlock.Text = "";
                               break;
                           case "div":
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 = Num3 / Num1;
                               ShowTextBlock.Text = "";
                               break;
                           default:
                               Num1 =
                                   Convert.ToDouble(CalculateTextBlock.Text.Substring(4, CalculateTextBlock.Text.Length - 4));
                               Num2 += 1 / Math.Acos(Num1);
                               ShowTextBlock.Text = "";
                               break;
                       }
                       break;

                    case "acosec":
                        switch (Trig)
                        {
                            case "plus":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6));
                                Num2 += 1/Math.Asin(Num1);
                                ShowTextBlock.Text = "";
                                break;
                            case "minus":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6));
                                Num2 -= 1 / Math.Asin(Num1);
                                ShowTextBlock.Text = "";
                                break;
                            case "mul":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6));
                                Num2 *= 1 / Math.Asin(Num1);
                                ShowTextBlock.Text = "";
                                break;
                            case "div":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6));
                                Num2 = Num3/Num1;
                                ShowTextBlock.Text = "";
                                break;
                            default:
                                 Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(6, CalculateTextBlock.Text.Length - 6));
                                Num2 += 1/Math.Asin(Num1);
                                ShowTextBlock.Text = "";
                                break;
                        }
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

                    case"loge":
                        switch (Log)
                        {
                            case "plus":

                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num2 += Math.Log(Num1);
                                ShowTextBlock.Text = "";
                                break;
                            case "minus":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num2 -= Math.Log(Num1);
                                ShowTextBlock.Text = "";
                                break;
                            case "mul":
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num2 *= Math.Log(Num1);
                                ShowTextBlock.Text = "";
                                break;
                            case "div":
                                Num1 =
                                    Math.Log(Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3)));
                                Num2 = Num3 / Num1;
                                ShowTextBlock.Text = "";
                                break;
                            default:
                                Num1 =
                                    Convert.ToDouble(CalculateTextBlock.Text.Substring(3, CalculateTextBlock.Text.Length - 3));
                                Num2 += Math.Log(Num1);
                                ShowTextBlock.Text = "";
                                break;
                        }
                        break;
                    

                    
                }
                if (Op == "brac")
                {
                    Op = "";
                    Num1 = 0;
                    Num3 = 0;
                    Trig = "";
                }
                else
                {
                    CalculateTextBlock.Text = Num2.ToString();
                    Num1 = 0;
                    Num3 = 0;
                    ShowTextBlock.Text = "";
                    Op = "";
                    Trig = ""; 
                }
               
            }
        }

        private void ButtonBase_OnClickclear(object sender, RoutedEventArgs e)
        {
            Num1 = 0;
            Num2 = 0;
            ShowTextBlock.Text = "";
            CalculateTextBlock.Text = "";
            Op = "";
            Trig = "";
            Num3 = 0;
        }


     
     private void Buttonswitch_Checked(object sender, RoutedEventArgs e)
     {
         Buttonsin.Visibility = Visibility.Collapsed;
         Buttoncos.Visibility = Visibility.Collapsed;
         Buttontan.Visibility = Visibility.Collapsed;
         Buttoncot.Visibility = Visibility.Collapsed;
         Buttonsec.Visibility = Visibility.Collapsed;
         Buttoncosec.Visibility = Visibility.Collapsed;
         Buttonasin.Visibility = Visibility.Visible;
         Buttonacos.Visibility = Visibility.Visible;
         Buttonatan.Visibility = Visibility.Visible;
         Buttonacot.Visibility = Visibility.Visible;
         Buttonasec.Visibility = Visibility.Visible;
         Buttonacosec.Visibility = Visibility.Visible;
         Buttonasin.IsEnabled = true;
         Buttonacos.IsEnabled = true;
         Buttonatan.IsEnabled = true;
         Buttonacot.IsEnabled = true;
         Buttonasec.IsEnabled = true;
         Buttonacosec.IsEnabled = true;
     }

     private void Buttonswitch_Unchecked(object sender, RoutedEventArgs e)
     {
         Buttonsin.Visibility = Visibility.Visible;
         Buttoncos.Visibility = Visibility.Visible;
         Buttontan.Visibility = Visibility.Visible;
         Buttoncot.Visibility = Visibility.Visible;
         Buttonsec.Visibility = Visibility.Visible;
         Buttoncosec.Visibility = Visibility.Visible;
         Buttonasin.Visibility = Visibility.Collapsed;
         Buttonacos.Visibility = Visibility.Collapsed;
         Buttonatan.Visibility = Visibility.Collapsed;
         Buttonacot.Visibility = Visibility.Collapsed;
         Buttonasec.Visibility = Visibility.Collapsed;
         Buttonacosec.Visibility = Visibility.Collapsed;
         Buttonasin.IsEnabled = false;
         Buttonacos.IsEnabled = false;
         Buttonatan.IsEnabled = false;
         Buttonacot.IsEnabled = false;
         Buttonasec.IsEnabled = false;
         Buttonacosec.IsEnabled = false;
     }

     private void ButtonBase_OnClickplusminus(object sender, RoutedEventArgs e)
     {
         CalculateTextBlock.Text = Convert.ToString(-Convert.ToDouble(CalculateTextBlock.Text));
     }

     private void SimpleButton_OnClick(object sender, RoutedEventArgs e)
     {
         Frame.Navigate(typeof (MainPage));
     }


        private void UnitButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (UnitConverter));
        }

        private void SettingsButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (SettingsPage));
        }

        private void AboutButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (AboutPage));
        }

       
    }
}
