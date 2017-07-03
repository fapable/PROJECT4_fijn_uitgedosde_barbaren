using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net.Http;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Jaar_1_Project_4 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Questions : Page
    {
        public Questions()
        {
            this.InitializeComponent();
        }

        private void mainTitle_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage));
        }

        private void send_message(object sender, RoutedEventArgs e)
        {
            var syncClient = new HttpClient();
            string email = E_mail.Text;
            var eduselect = Opleiding.Items[Opleiding.SelectedIndex] as ComboBoxItem;
            string education = eduselect.Content.ToString();
            string name = Naam.Text;
            string question = Vraag.Text;
            string qid = "http://www.wschaijk.nl/api/api.php/SELECT-question_id-FROM-questions-ORDER-BY-question_id-DESC-LIMIT-1;";
            var qidCall = syncClient.GetStringAsync(qid);
            var qidResult = qidCall.Result;
            var gimmeResult = new PrepareForScreenQueryHandler();
            var tempid = gimmeResult.resultOnly(qidResult);
            int id = Int32.Parse(tempid);
            id = id + 1;
            string qupload = string.Format("http://www.wschaijk.nl/api/api.php/INSERT-INTO-questions-VALUES({0},-\'{1}\',-\'{2}\',-\'{3}\',-\'{4}\');", id, education.Replace(" ", "-"), email.Replace("@", "%40"), name.Replace(" ", "-"), question.Replace("?", "").Replace(" ", "-"));
            var uploadstuff = syncClient.GetAsync(qupload);
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage));
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private int getWidth()
        {
            FrameworkElement pnlClient = this.Content as FrameworkElement;
            if (pnlClient != null)
            {
                double Width = pnlClient.ActualWidth;
                return (int)Width;
            }
            return 0;
        }
        private int getHeight()
        {
            FrameworkElement pnlClient = this.Content as FrameworkElement;
            if (pnlClient != null)
            {
                double Height = pnlClient.ActualHeight;
                return (int)Height;
            }
            return 0;
        }

        private void Opleiding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}