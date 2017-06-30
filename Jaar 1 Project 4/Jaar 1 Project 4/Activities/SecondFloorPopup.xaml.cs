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
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Jaar_1_Project_4 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecondFloorPopup : Page {
        public SecondFloorPopup() {
            this.InitializeComponent();
            
        }
        public void DrawQueries(string description, string eventName, string classroomID, string opleidingnaam, string duration, string startTime, string endTime ) {


        }
        public void Draw(string tableName) {
            Jaar_1_Project_4_Messages.EasyLabel easyLabel = new Jaar_1_Project_4_Messages.EasyLabel(10, 50, 500, 30, tableName);
            secondFloorPopupGrid.Children.Add(easyLabel.Draw());

        }
        //Creates queries
        //TODO classroom numbers to the parameter: ClassroomId
        public static void EventFromDB(string classroomId) {
            var syncClient = new HttpClient(); //Webclient does not work for windows universal platform
            var description = "http://www.wschaijk.nl/api/api.php/SELECT-description-FROM-events-WHERE-classroom_ID-=-'H.02.403';";
            var eventName = "http://www.wschaijk.nl/api/api.php/SELECT-event_name-FROM-events-WHERE-classroom_ID-=-'H.02.403';";
            var classRoomID = "http://www.wschaijk.nl/api/api.php/SELECT-class_id-FROM-events-WHERE-classroom_ID-=-'H.02.403';";
            var opleidingNaam = "http://www.wschaijk.nl/api/api.php/SELECT-opleiding_naam-FROM-events-WHERE-classroom_ID-=-'H.02.403';";
            var duration = "http://www.wschaijk.nl/api/api.php/SELECT-duration-FROM-events-WHERE-classroom_ID-=-'H.02.403';";
            var startTime = "http://www.wschaijk.nl/api/api.php/SELECT-start_time-FROM-events-WHERE-classroom_ID-=-'H.02.403';";
            var endTime = "http://www.wschaijk.nl/api/api.php/SELECT-end_time-FROM-events-WHERE-classroom_ID-=-'H.02.403';";


            var descriptionCall = syncClient.GetStringAsync(description);
            var eventCall = syncClient.GetStringAsync(eventName);
            var classroomidCall = syncClient.GetStringAsync(classRoomID);
            var opleidingnaamCall = syncClient.GetStringAsync(opleidingNaam);
            var durationCall = syncClient.GetStringAsync(duration);
            var startTimeCall = syncClient.GetStringAsync(startTime);
            var endTimeCall = syncClient.GetStringAsync(endTime);

            var descriptionResult = descriptionCall.Result;
            //var eventResult = eventCall.Result;
            //var classroomIDResult = classroomidCall.Result;
            //var opleidingNaamResult = opleidingnaamCall.Result;
            //var durationResult = durationCall.Result;
            //var startTimeResult = startTimeCall.Result;
            //var endTimeResult = endTimeCall.Result;

            //TODO set the attributes above
            StaticButtonName.Description = descriptionResult;




        }

        private void clickMe(object sender, RoutedEventArgs e) {
            EventFromDB(StaticButtonName.ButtonName);
            this.Draw(StaticButtonName.Description);
        }
    }
}
