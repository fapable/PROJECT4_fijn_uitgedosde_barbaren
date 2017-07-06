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
using Jaar_1_Project_4_Messages;
using Jaar_1_Project_4.QuestionSystem;

//The answer page, only teachers can access this page

namespace Jaar_1_Project_4 {
    public sealed partial class Answer : Page {
        public Answer() {
            this.InitializeComponent();
            vraagBox.Text = QuestionExtender.TheQuestion; //The textbox of the question section gets changed into the question
        }
        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage)); //sends user back to main question page
        }      
        private void Send_message(object sender, RoutedEventArgs e)
        {
            var syncClient = new HttpClient(); //allow internet acces for api interaction

            int question_id = Int32.Parse(QuestionExtender.CurrentSelectedQuestionID); //id of the question that is currently being answered

            string who_to_mail = string.Format("http://www.wschaijk.nl/api/api.php/SELECT-email-FROM-questions-WHERE-question_id-=-{0};", question_id); //email adress to notify the person who asked the question
            string person_name = string.Format("http://www.wschaijk.nl/api/api.php/SELECT-name-FROM-questions-WHERE-question_id-=-{0};", question_id); //name of the person who asked the question
            var emailCall = syncClient.GetStringAsync(who_to_mail);
            var emailResult = emailCall.Result; //executes query
            var nameCall = syncClient.GetStringAsync(person_name);
            var nameResult = nameCall.Result; //executes query
            var gimmeResult = new PrepareForScreenQueryHandler();
            var email = gimmeResult.ResultOnly(emailResult); //removes unnecessary string elements from the result
            var name = gimmeResult.ResultOnly(nameResult); //removes unnecessary dtring elements from the result

            string updatequery = TextToURL.text_to_string(string.Format("http://www.wschaijk.nl/api/api.php/UPDATE-answer-SET-teacher_id-=-\'{0}\',-answer-=-\'{1}\'-WHERE-question_id-=-{2};", DatabaseLoginCheck.LoggedInTeacherName, answerBox.Text, question_id));
            var updateanswer = syncClient.GetAsync(updatequery); //upload answer to database

            string notification = TextToURL.text_to_string(string.Format("http://www.wschaijk.nl/api/api.php/MAIL={0}=Your-question-has-been-answered!=Dear-{1},-your-question-regarding-the-open-day-has-been-answered.-Check-the-Q-and-A-page-for-the-answer.", email, name));
            var sendmail = syncClient.GetAsync(notification); //notify the person who asked the question via email

            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage)); //sends user back to the main question page
        }
    }
}
