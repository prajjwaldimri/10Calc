using System;
using Windows.Security.Cryptography.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Navigation;
using _10Calc.Common;
using _10Calc.Pages;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace _10Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Programmer_s_Calculator : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public Programmer_s_Calculator()
        {
            InitializeComponent();
            
            navigationHelper = new NavigationHelper(this);
            navigationHelper.LoadState += NavigationHelper_LoadState;
            navigationHelper.SaveState += NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return defaultViewModel; }
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
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private int Deci { get; set; }
        private string Hexa { get; set; }
        private string Op { get; set; }
        
        


        #region Buttons and Switches

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += Button1.Content.ToString();
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += Button2.Content.ToString();
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += Button3.Content.ToString();
        }

        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
           ShowTextBlock.Text += Button4.Content.ToString();
        }

        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += Button5.Content.ToString();
        }

        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += Button6.Content.ToString();
        }

        private void ButtonBase_OnClick7(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += Button7.Content.ToString();
        }

        private void ButtonBase_OnClick8(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += Button8.Content.ToString();
        }

        private void ButtonBase_OnClick9(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += Button9.Content.ToString();
        }

        private void ButtonBase_OnClick0(object sender, RoutedEventArgs e)
        {
           ShowTextBlock.Text += Button0.Content.ToString();
        }

        private void ButtonBase_OnClickdot(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += Buttondot.Content.ToString();
            Op = "dot";
        }

        private void ButtonBase_OnClickclear(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text = "";
            Deci = 0;
            Op = "";
            BinTextBlock.Text = "";
            DeciTextBlock.Text = "";
            OctalTextBlock.Text = "";
            HexTextBlock.Text = "";

        }

        private void ButtonBase_OnClickbackspace(object sender, RoutedEventArgs e)
        {
            if (ShowTextBlock.Text == "")
            {
                ShowTextBlock.Text = "";
            }
            else
            {
                string showstring = ShowTextBlock.Text;
                ShowTextBlock.Text = showstring.Substring(0, showstring.Length - 1);
                
            }
        }

        private void ButtonBase_OnClickA(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += "A";
        }

        private void ButtonBase_OnClickB(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += "B";
        }

        private void ButtonBase_OnClickC(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += "C";
        }

        private void ButtonBase_OnClickD(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += "D";
        }

        private void ButtonBase_OnClickE(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += "E";
        }

        private void ButtonBase_OnClickF(object sender, RoutedEventArgs e)
        {
            ShowTextBlock.Text += "F";
        }

        private void Decimal_Checked(object sender, RoutedEventArgs e)
        {
            if (Decimal == null)
            {

            }
            else
            {
                if (Binary.IsChecked == true)
                    Binary.IsChecked = false;
                else if (Octal.IsChecked == true)
                    Octal.IsChecked = false;
                else if (Hex.IsChecked == true)
                    Hex.IsChecked = false;
                
                    Button0.IsEnabled = true;
                    Button1.IsEnabled = true;
                    Button2.IsEnabled = true;
                    Button3.IsEnabled = true;
                    Button4.IsEnabled = true;
                    Button5.IsEnabled = true;
                    Button6.IsEnabled = true;
                    Button7.IsEnabled = true;
                    Button8.IsEnabled = true;
                    Button9.IsEnabled = true;
                    ButtonA.IsEnabled = false;
                    ButtonB.IsEnabled = false;
                    ButtonC.IsEnabled = false;
                    ButtonD.IsEnabled = false;
                    ButtonE.IsEnabled = false;
                    ButtonF.IsEnabled = false;
                }
            
        }

        private void Binary_Checked(object sender, RoutedEventArgs e)
        {
            if (Decimal.IsChecked == true)
                Decimal.IsChecked = false;
            else if (Octal.IsChecked == true)
                Octal.IsChecked = false;
            else if (Hex.IsChecked == true)
                Hex.IsChecked = false;

            Button0.IsEnabled = true;
            Button1.IsEnabled = true;
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;
            Button9.IsEnabled = false;
            ButtonA.IsEnabled = false;
            ButtonB.IsEnabled = false;
            ButtonC.IsEnabled = false;
            ButtonD.IsEnabled = false;
            ButtonE.IsEnabled = false;
            ButtonF.IsEnabled = false;

        }

        private void Octal_Checked(object sender, RoutedEventArgs e)
        {
            if (Binary.IsChecked == true)
                Binary.IsChecked = false;
            else if (Decimal.IsChecked == true)
                Decimal.IsChecked = false;
            else if (Hex.IsChecked == true)
                Hex.IsChecked = false;

            Button0.IsEnabled = true;
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = false;
            Button9.IsEnabled = false;
            ButtonA.IsEnabled = false;
            ButtonB.IsEnabled = false;
            ButtonC.IsEnabled = false;
            ButtonD.IsEnabled = false;
            ButtonE.IsEnabled = false;
            ButtonF.IsEnabled = false;
        }

        private void Hex_Checked(object sender, RoutedEventArgs e)
        {
            if (Binary.IsChecked == true)
                Binary.IsChecked = false;
            else if (Octal.IsChecked == true)
                Octal.IsChecked = false;
            else if (Decimal.IsChecked == true)
                Decimal.IsChecked = false;

            Button0.IsEnabled = true;
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            Button9.IsEnabled = true;
            ButtonA.IsEnabled = true;
            ButtonB.IsEnabled = true;
            ButtonC.IsEnabled = true;
            ButtonD.IsEnabled = true;
            ButtonE.IsEnabled = true;
            ButtonF.IsEnabled = true;
        }

        private void Decimal_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Binary.IsChecked == false && Octal.IsChecked == false && Hex.IsChecked == false)
            {
                Decimal.IsChecked = true;
            }
        }

        private void Binary_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Decimal.IsChecked == false && Octal.IsChecked == false && Hex.IsChecked == false)
            {
                Binary.IsChecked = true;
            }
        }

        private void Octal_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Binary.IsChecked == false && Decimal.IsChecked == false && Hex.IsChecked == false)
            {
                Octal.IsChecked = true;
            }
        }

        private void Hex_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Binary.IsChecked == false && Octal.IsChecked == false && Decimal.IsChecked == false)
            {
                Hex.IsChecked = true;
            }
        }

        #endregion

        private void ShowTextBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ShowTextBlock.Text != "")
            {
                if (Op=="dot")
                {
                    Op = "";
                    DeciTextBlock.Text += "";
                    BinTextBlock.Text += "";
                    OctalTextBlock.Text += "";
                    HexTextBlock.Text += "";
                }
                
                else if (Decimal.IsChecked == true)
                {
                    Deci = Convert.ToInt32(ShowTextBlock.Text, 10); 
                    DeciTextBlock.Text = Convert.ToString(Deci);
                    BinTextBlock.Text = Convert.ToString(Deci, 2);
                    OctalTextBlock.Text = Convert.ToString(Deci, 8);
                    Hexa = Convert.ToString(Deci, 16);
                    HexTextBlock.Text = Hexa.ToUpper();

                }
                else if (Binary.IsChecked == true)
                {
                    Deci = Convert.ToInt32(ShowTextBlock.Text, 2);
                    DeciTextBlock.Text = Convert.ToString(Deci);
                    BinTextBlock.Text = Convert.ToString(Deci, 2);
                    OctalTextBlock.Text = Convert.ToString(Deci, 8);
                    Hexa = Convert.ToString(Deci, 16);
                    HexTextBlock.Text = Hexa.ToUpper();
                }
                else if (Octal.IsChecked == true)
                {
                    Deci = Convert.ToInt32(ShowTextBlock.Text, 8);
                    DeciTextBlock.Text = Convert.ToString(Deci);
                    BinTextBlock.Text = Convert.ToString(Deci, 2);
                    OctalTextBlock.Text = Convert.ToString(Deci, 8);
                    Hexa = Convert.ToString(Deci, 16);
                    HexTextBlock.Text = Hexa.ToUpper();
                }
                else if (Hex.IsChecked == true)
                {
                    Deci = Convert.ToInt32(ShowTextBlock.Text, 16);
                    DeciTextBlock.Text = Convert.ToString(Deci);
                    BinTextBlock.Text = Convert.ToString(Deci, 2);
                    OctalTextBlock.Text = Convert.ToString(Deci, 8);
                    Hexa = Convert.ToString(Deci, 16);
                    HexTextBlock.Text = Hexa.ToUpper();
                }
            }
            else
            {
                ShowTextBlock.Text = "";
                BinTextBlock.Text = "";
                DeciTextBlock.Text = "";
                OctalTextBlock.Text = "";
                HexTextBlock.Text = "";
            }
        }

        private void ScientificButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (Scientific));
        }

        private void SimpleButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (MainPage));
        }

        private void UnitButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (UnitConverter));
        }

        private void AboutButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (AboutPage));
        }

        private void SettingsButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (SettingsPage));
        }

    }
}
