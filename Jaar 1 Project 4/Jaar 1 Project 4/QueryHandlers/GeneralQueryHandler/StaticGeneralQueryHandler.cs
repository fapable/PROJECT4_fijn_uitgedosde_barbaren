using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Text;

//All classes that use queries will come into in these methods

namespace Jaar_1_Project_4 {
    public class PrepareForScreenQueryHandler : IPrepareQueryForScreenDisplay {
                /* Converts the query result from the method: MakeQueries, and makes the text more human readable.
         the query result have brackets and other things in them, but that is not so nice on the screen
         so that's why they are converted with this method to a more readable text */
        public  string ConvertRawQueryResultToNormalText(string rawQueryText) {
            string queryTextConverted = "";
            foreach (char character in rawQueryText) {
                if (character.ToString() == "{" || character.ToString() == "}") {
                    queryTextConverted += "";
                }
                else if (character.ToString() == "\"") {
                    queryTextConverted += " ";
                }
                else if (character.ToString() == "_") {
                    queryTextConverted += " ";
                }
                else {
                    queryTextConverted += character.ToString();
                }
            }
            return (queryTextConverted);
        }
                /* To create the text (query results) that will appear on the screen
        As paramaters is given the grid (page) where it will be drawn on,
        the result of the query, and in which row the textblock will apppear
        */
        public  void CreateTextBlock(dynamic gridPage, string queryResult, int gridRow) {
            TextBlock textblock = new TextBlock();
            textblock.Text = queryResult;
            Grid.SetColumn(textblock, 0);
            Grid.SetRow(textblock, gridRow);
            textblock.VerticalAlignment = VerticalAlignment.Center; //Without this the application freezes
            textblock.TextWrapping = TextWrapping.Wrap; //this way the text won't go out of the screen
            textblock.FontSize = 20;
            textblock.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
            textblock.FontWeight = FontWeights.Bold;
            gridPage.Children.Add(textblock); //Adds textblock to the given page
        }
    }
}
