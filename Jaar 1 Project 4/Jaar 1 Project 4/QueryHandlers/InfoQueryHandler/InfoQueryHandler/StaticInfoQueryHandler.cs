using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Text;

namespace Jaar_1_Project_4 {
    public class StaticInfoQueryHandler : IQueryHandler {
        public static string wijnhaven;
        private static string mondayOpening;
        private static string tuesdayOpening;
        private static string wednesdayOpening;
        private static string thursdayOpening;
        private static string fridayOpening;
        private static string adres;

        public static string MondayOpening { get => mondayOpening; set => mondayOpening = value; }
        public static string TuesdayOpening { get => tuesdayOpening; set => tuesdayOpening = value; }
        public static string WednesdayOpening { get => wednesdayOpening; set => wednesdayOpening = value; }
        public static string ThursdayOpening { get => thursdayOpening; set => thursdayOpening = value; }
        public static string FridayOpening { get => fridayOpening; set => fridayOpening = value; }
        public static string Adres { get => adres; set => adres = value; }
        public static string Wijnhaven { get => wijnhaven; set => wijnhaven = value; }

        IPrepareQueryForScreenDisplay displayOnScreenObject;
        public StaticInfoQueryHandler() {
            this.displayOnScreenObject = new PrepareForScreenQueryHandler();
        }
        public void MakeQueries(string wijnhaven) {
            var syncClient = new HttpClient(); //To make connection with the API
            string mondayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-maandagopenning-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string tuesdayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-dinsdagopening-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string wednesdayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-woensdagopening-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string thursdayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-donderdagopening-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string fridayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-vrijdagopening-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string adres = "http://www.wschaijk.nl/api/api.php/SELECT-adres-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";

            var mondayOpenCall = syncClient.GetStringAsync(mondayOpening);
            var mondayOpenResult = mondayOpenCall.Result;

            var tuesdagOpenCall = syncClient.GetStringAsync(tuesdayOpening);
            var tuesdagOpenResult = tuesdagOpenCall.Result;

            var wednesdayOpenCall = syncClient.GetStringAsync(wednesdayOpening);
            var wednesdayOpenResult = wednesdayOpenCall.Result;

            var thursdayOpenCall = syncClient.GetStringAsync(thursdayOpening);
            var thursdayOpenResult = thursdayOpenCall.Result;

            var fridayOpenCall = syncClient.GetStringAsync(fridayOpening);
            var fridayOpenResult = fridayOpenCall.Result;

            var adresCall = syncClient.GetStringAsync(adres);
            var adresResult = adresCall.Result;

            StaticInfoQueryHandler.MondayOpening = mondayOpenResult;
            StaticInfoQueryHandler.TuesdayOpening = tuesdagOpenResult;
            StaticInfoQueryHandler.WednesdayOpening = wednesdayOpenResult;
            StaticInfoQueryHandler.ThursdayOpening = thursdayOpenResult;
            StaticInfoQueryHandler.FridayOpening = fridayOpenResult;
            StaticInfoQueryHandler.Adres = adresResult;

        }
        public string ChangeMainAttributeName(object sender) {
            Button clickedOnButton = (Button) sender;
            string emptyButtonName = ""; //to store the buttonname
            /*
            The foreach loop is here because you can't have object names with dots in UWP
            Since the database tables need to match the buttonname, the foreach loop is made to change (convert)
            the buttoname to match the DB tables
             */
            foreach (var letter in clickedOnButton.Name.ToString()) {
                if (letter.ToString() == "_") { //for event buttons
                    emptyButtonName += "%";
                }
                else if(letter.ToString() == "4") {
                    emptyButtonName += "_";
                }
                else {
                    emptyButtonName += letter.ToString();
                }
            }
            return emptyButtonName; //Buttoname gets SET so it can reached within SecondFloorPopup class                
        }
        public void SetTextOnScreen(dynamic gridPage) {
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(StaticInfoQueryHandler.MondayOpening), 1);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(StaticInfoQueryHandler.TuesdayOpening), 2);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(StaticInfoQueryHandler.WednesdayOpening), 3);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(StaticInfoQueryHandler.ThursdayOpening), 4);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(StaticInfoQueryHandler.FridayOpening), 5);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(StaticInfoQueryHandler.Adres), 6);
        }
    }

}
