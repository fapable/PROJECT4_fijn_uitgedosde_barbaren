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

//The page where an question can be asked (only for students)

namespace Jaar_1_Project_4 {
    public sealed partial class Questions : Page {
        public Questions() {
            this.InitializeComponent();
        }
        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage));
        }
        private void Send_message(object sender, RoutedEventArgs e)
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
            var tempid = gimmeResult.ResultOnly(qidResult);
            int id = Int32.Parse(tempid);
            id = id + 1;
            string qupload = string.Format("http://www.wschaijk.nl/api/api.php/INSERT-INTO-questions-VALUES({0},-\'{1}\',-\'{2}\',-\'{3}\',-\'{4}\');", id, education.Replace(" ", "-"), email.Replace("@", "%40"), name.Replace(" ", "-"), question.Replace("?", "").Replace(" ", "-"));
            var uploadstuff = syncClient.GetAsync(qupload);
            string tempanswer = string.Format("http://www.wschaijk.nl/api/api.php/INSERT-INTO-answer-VALUES({0},-\'{1}\',-\'place\',-\'This-question-is-not-yet-answered.\');", id, education.Replace(" ", "-"));
            var uploadta = syncClient.GetAsync(tempanswer);
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage));
        }

        private int GetWidth()
        {
            FrameworkElement pnlClient = this.Content as FrameworkElement;
            if (pnlClient != null)
            {
                double Width = pnlClient.ActualWidth;
                return (int)Width;
            }
            return 0;
        }
        private int GetHeight()
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