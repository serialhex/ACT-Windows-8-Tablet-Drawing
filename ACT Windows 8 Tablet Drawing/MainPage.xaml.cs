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
    public sealed partial class MainPage : Page
    {
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
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            grep_info();
            stupid_text.Text = info.ToString();
            info.writeFile();
        }
    }
}
