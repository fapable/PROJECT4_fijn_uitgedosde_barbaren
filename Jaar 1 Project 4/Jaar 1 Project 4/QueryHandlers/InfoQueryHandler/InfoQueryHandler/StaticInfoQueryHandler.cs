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

//The main job of this class is to create queries and manipulate it, it also gives commandos to display the text (query result) on screen

namespace Jaar_1_Project_4 {
    public class StaticInfoQueryHandler : IQueryHandler {
        public static string wijnhaven; //This is the main attribute, the last clicked on button is stored, based on the button name the queries are made
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

        IPrepareQueryForScreenDisplay displayOnScreenObject;  //To display the query results on the screen
        public StaticInfoQueryHandler() {
            this.displayOnScreenObject = new PrepareForScreenQueryHandler();
        }
        //The job of this method is to create queries, as paramters is the last clicked on info button
        //Based on the button, the queries are made
        public void MakeQueries(string wijnhaven) {
            var syncClient = new HttpClient(); //To make connection with the API
            string mondayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-maandagopenning-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string tuesdayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-dinsdagopening-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string wednesdayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-woensdagopening-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string thursdayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-donderdagopening-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string fridayOpening = "http://www.wschaijk.nl/api/api.php/SELECT-vrijdagopening-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";
            string adres = "http://www.wschaijk.nl/api/api.php/SELECT-adres-FROM-openingstijden_locatie-WHERE-adres-LIKE-" + "'" + wijnhaven + "'; ";

            var mondayOpenCall = syncClient.GetStringAsync(mondayOpening); //Query gets done
            var mondayOpenResult = mondayOpenCall.Result; //Query result is saved

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

            //The attributes are set to the result of the query's, this is so that the result of the query can be shown on screen
            StaticInfoQueryHandler.MondayOpening = mondayOpenResult;
            StaticInfoQueryHandler.TuesdayOpening = tuesdagOpenResult;
            StaticInfoQueryHandler.WednesdayOpening = wednesdayOpenResult;
            StaticInfoQueryHandler.ThursdayOpening = thursdayOpenResult;
            StaticInfoQueryHandler.FridayOpening = fridayOpenResult;
            StaticInfoQueryHandler.Adres = adresResult;

        }
        //Method changed the main attribute name to the last clicked on info button, based on this main attribute the quries are made
        //This method is used because you cant have an object name with dots, but since the attributes in the DB do have dots
        //The object name is then converted first
        //This method is called when an info button is clicked
        public string ChangeMainAttributeName(object sender) {
            Button clickedOnButton = (Button) sender;
            string emptyButtonName = ""; //to store the buttonname
            foreach (var letter in clickedOnButton.Name.ToString()) {
                if (letter.ToString() == "_") {
                    emptyButtonName += "%";
                }
                else if(letter.ToString() == "4") {
                    emptyButtonName += "_";
                }
                else {
                    emptyButtonName += letter.ToString();
                }
            }
            return emptyButtonName;            
        }
        //This methods creates the textblock, and also calls a method that converts the raw query result to a better looking text
        //As parameter is the grid (page) on which the text (query results) should be drawn on
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
