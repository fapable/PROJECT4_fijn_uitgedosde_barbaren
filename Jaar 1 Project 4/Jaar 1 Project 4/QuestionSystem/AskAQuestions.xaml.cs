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
using Jaar_1_Project_4.QuestionSystem;

//The page where an question can be asked

namespace Jaar_1_Project_4 {
    public sealed partial class Questions : Page {
        public Questions() {
            this.InitializeComponent();
        }
        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage)); //send user back to main question page
        }
        private void Send_message(object sender, RoutedEventArgs e)
        {
            var syncClient = new HttpClient(); //allow api connection
            //variables that need to be uploaded to the database
            string email = E_mail.Text;
            try
            {
                var eduselect = Opleiding.Items[Opleiding.SelectedIndex] as ComboBoxItem;
                string education = eduselect.Content.ToString();
                string name = Naam.Text;
                string question = Vraag.Text;
                string qid = "http://www.wschaijk.nl/api/api.php/SELECT-question_id-FROM-questions-ORDER-BY-question_id-DESC-LIMIT-1;"; //query for current highest question id
                var qidCall = syncClient.GetStringAsync(qid);
                var qidResult = qidCall.Result; //result for the query
                var gimmeResult = new PrepareForScreenQueryHandler();
                var tempid = gimmeResult.ResultOnly(qidResult); //remove unnecessary string elements from result
                int id = Int32.Parse(tempid); //go from string result to int result
                id = id + 1; //increment current highest id by one because youre adding a new question
                string qupload = TextToURL.text_to_string(string.Format("http://www.wschaijk.nl/api/api.php/INSERT-INTO-questions-VALUES({0},-\'{1}\',-\'{2}\',-\'{3}\',-\'{4}\');", id, education, email, name, question)); //upload the question
                var uploadstuff = syncClient.GetAsync(qupload);
                string tempanswer = TextToURL.text_to_string(string.Format("http://www.wschaijk.nl/api/api.php/INSERT-INTO-answer-VALUES({0},-\'{1}\',-\'place\',-\'This-question-is-not-yet-answered.\');", id, education)); //upload a dummy answer
                var uploadta = syncClient.GetAsync(tempanswer);
                this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage)); //send user back to main question page
            }
            catch (System.ArgumentOutOfRangeException)
            {
                this.Frame.Navigate(typeof(Questions));
            }
        }
    }
}