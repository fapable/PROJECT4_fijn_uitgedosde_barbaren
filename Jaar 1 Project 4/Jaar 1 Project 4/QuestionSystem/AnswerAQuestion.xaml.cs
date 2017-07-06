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

//The answer page, only teachers can access this page

namespace Jaar_1_Project_4 {
    public sealed partial class Answer : Page {
        public Answer() {
            this.InitializeComponent();
            vraagBox.Text = QuestionExtender.TheQuestion; //The textbox of the question section gets changed into the question
        }
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            if (DatabaseLoginCheck.IsTeacherLoggedInGetAndSettter == true) {
                this.Frame.Navigate(typeof(MainMenu));

            }
            else {
                this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage));
            }
        }      
        private void Send_message(object sender, RoutedEventArgs e)
        {
            //TODO
            //upload answer to database + send email to person that asked the answered question
            var syncClient = new HttpClient();

            int question_id = Int32.Parse(QuestionExtender.CurrentSelectedQuestionID);

            string who_to_mail = string.Format("http://www.wschaijk.nl/api/api.php/SELECT-email-FROM-questions-WHERE-question_id-=-{0};", question_id);
            string person_name = string.Format("http://www.wschaijk.nl/api/api.php/SELECT-name-FROM-questions-WHERE-question_id-=-{0};", question_id);
            var gimmeResult = new PrepareForScreenQueryHandler();
            var email = gimmeResult.ResultOnly(who_to_mail);
            var name = gimmeResult.ResultOnly(person_name);

            string updatequery = string.Format("http://www.wschaijk.nl/api/api.php/UPDATE-answer-SET-teacher_id-=-\'{0}\',-answer-=-\'{1}\'-WHERE-question_id-=-{2};", DatabaseLoginCheck.LoggedInTeacherName, answerBox.Text, question_id);
            var updateanswer = syncClient.GetAsync(updatequery);

            string notification = string.Format("http://www.wschaijk.nl/api/api.php/MAIL={0}=Your-question-has-been-answered!=Dear-{0},-your-question-regarding-the-open-day-has-been-answered.-Check-the-Q-and-A-page-for-the-answer.", name);
            var sendmail = syncClient.GetAsync(notification);

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
                double height = pnlClient.ActualHeight;
                return (int)Height;
            }
            return 0;
        }
    }
}
