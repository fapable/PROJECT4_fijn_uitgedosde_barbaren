using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Saves the buttonname and the result of the query's
//Then these attributes get approached to draw it to the screen (text)
namespace Jaar_1_Project_4 {
    public class StaticButtonName {
        private static string buttonName;
        private static string description;
        private static string eventResult;
        private static string classroomIDResult;
        private static string opleidingNaamResult;
        private static string durationResult;
        private static string startTimeResult;
        private static string endTimeResult;
        public static string ButtonName { get => buttonName; set => buttonName = value; }
        public static string Description { get => description; set => description = value; }
        public static string EventResult { get => eventResult; set => eventResult = value; }
        public static string ClassroomIDResult { get => classroomIDResult; set => classroomIDResult = value; }
        public static string OpleidingNaamResult { get => opleidingNaamResult; set => opleidingNaamResult = value; }
        public static string DurationResult { get => durationResult; set => durationResult = value; }
        public static string StartTimeResult { get => startTimeResult; set => startTimeResult = value; }
        public static string EndTimeResult { get => endTimeResult; set => endTimeResult = value; }
    }
}
