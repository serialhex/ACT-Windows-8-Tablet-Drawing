using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ACT_Windows_8_Tablet_Drawing
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        
        private PersonInfo info = new PersonInfo();
        private void grep_info() {
            info.FirstName = FirstName.Text;
            info.LastName = LastName.Text;
            info.Phone = Phone.Text;
            info.EMail = Email.Text;
            info.Address1 = Address1.Text;
            info.Address2 = Address2.Text;
            info.City = City.Text;
            info.State = State.SelectionBoxItem.ToString();
            info.Zip = Zip.Text;
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            grep_info();
            info.writeFile();
            // Add this code.
            if (this.Frame != null) {
                this.Frame.Navigate(typeof(ThankYou));
            }
        }

        #region stupidland
        // this is a WTF!  i tried making just one function that you could pass
        // the object to and have it set the text property for........
        //   this is fucking stupid!
        private void FirstName_GotFocus_1(object sender, RoutedEventArgs e) {
            FirstName.Text = "";
        }

        private void LastName_GotFocus_1(object sender, RoutedEventArgs e) {
            LastName.Text = "";
        }

        private void Phone_GotFocus_1(object sender, RoutedEventArgs e) {
            Phone.Text = "";
        }

        private void Email_GotFocus_1(object sender, RoutedEventArgs e) {
            Email.Text = "";
        }

        private void Address1_GotFocus_1(object sender, RoutedEventArgs e) {
            Address1.Text = "";
        }

        private void Address2_GotFocus_1(object sender, RoutedEventArgs e) {
            Address2.Text = "";
        }

        private void City_GotFocus_1(object sender, RoutedEventArgs e) {
            City.Text = "";
        }

        private void Zip_GotFocus_1(object sender, RoutedEventArgs e) {
            Zip.Text = "";
        }
        #endregion of stupidness!
    }
}
