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

//Main job is to prepare the queries to display on the screen
//All classes that use queries will come into in these methods

namespace Jaar_1_Project_4 {
    public class PrepareForScreenQueryHandler : IPrepareQueryForScreenDisplay {
         //Removes ther brackets from the query results and make the text more readable
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
         //Creates the textblocks (query results) that will appear on the screen, the textblock have as text an query result
         //As parameter, gridpage: the page it will get drawn on, queryresult: the result from the query, and gridrow: in which row to draw
        public  void CreateTextBlock(dynamic gridPage, string queryResult, int gridRow) {
            TextBlock textblock = new TextBlock();
            textblock.Text = queryResult;
            Grid.SetColumn(textblock, 0);
            Grid.SetRow(textblock, gridRow);
            textblock.VerticalAlignment = VerticalAlignment.Center; //Without this the application freezes
            textblock.TextWrapping = TextWrapping.Wrap; //this way the text won't go out of the screen
            textblock.FontSize = 20;
            textblock.Foreground = new SolidColorBrush(Windows.UI.Colors.Black); //background colour
            textblock.FontWeight = FontWeights.Bold; //font style
            gridPage.Children.Add(textblock); //Adds textblock to the given page
        }
        //Removes ther brackets from the query results and make the text more readable
        //The difference with the other method is that this method does not have the text and the DB attribute name together
        public string ResultOnly(string queryResult) {
            string queryTextConverted = "";
            foreach (char character in queryResult.Reverse())
            {
                if (character.ToString() == "{" || character.ToString() == "}")
                {
                    queryTextConverted += "";
                }
                else if (character.ToString() == "\"")
                {
                    queryTextConverted += "";
                }
                else if (character.ToString() == ":")
                {
                    break;
                }
                else
                {
                    queryTextConverted = character.ToString() + queryTextConverted;
                }
            }
            return (queryTextConverted);
        }
    }
}
