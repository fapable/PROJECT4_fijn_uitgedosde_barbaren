using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//TODO do info

namespace Jaar_1_Project_4 {
    public abstract class StaticInfoQueryHandler : IQueryHandler {
        private static string mondayOpenTime;
        private static string mondayCloseTime;
        private static string tuedayOpenTime;
        private static string tuesdayCloseTime;
        private static string wednesdayOpenTime;
        private static string wednesdayCloseTime;
        private static string thursdayOpenTime;
        private static string thursdayCloseTime;
        private static string fridayOpenTime;
        private static string fridayCloseTime;
        private static string adres;

        public static string MondayOpenTime { get => mondayOpenTime; set => mondayOpenTime = value; }
        public static string MondayCloseTime { get => mondayCloseTime; set => mondayCloseTime = value; }
        public static string TuedayOpenTime { get => tuedayOpenTime; set => tuedayOpenTime = value; }
        public static string TuesdayCloseTime { get => tuesdayCloseTime; set => tuesdayCloseTime = value; }
        public static string WednesdayOpenTime { get => wednesdayOpenTime; set => wednesdayOpenTime = value; }
        public static string WednesdayCloseTime { get => wednesdayCloseTime; set => wednesdayCloseTime = value; }
        public static string ThursdayOpenTime { get => thursdayOpenTime; set => thursdayOpenTime = value; }
        public static string ThursdayCloseTime { get => thursdayCloseTime; set => thursdayCloseTime = value; }
        public static string FridayOpenTime { get => fridayOpenTime; set => fridayOpenTime = value; }
        public static string FridayCloseTime { get => fridayCloseTime; set => fridayCloseTime = value; }
        public static string Adres { get => adres; set => adres = value; }

        public  void MakeQueries(string wijnhaven) {
            string mondayOpenTime = "http://www.wschaijk.nl/api/api.php/SELECT-maandagopen-FROM-openingstijden_locatie-WHERE-adres-Like-=-" + "'" + wijnhaven + "%';";

        }

        public string ChangeMainAttributeName(object sender) {
            throw new NotImplementedException();
        }

        public void SetTextOnScreen(dynamic gridPage) {
            throw new NotImplementedException();
        }
    }

}
