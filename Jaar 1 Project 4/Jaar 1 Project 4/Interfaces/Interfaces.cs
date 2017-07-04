using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

//Here are the interfaces of the application

namespace Jaar_1_Project_4 {
    //Main job is to send commandos to create queries and textblocks
    public interface IPagePopup {
        void MakeQueriesAndTextBlocks();
    }
    //Main job is to create queries
    public interface IQueryHandler {
        void MakeQueries(string itemForQuery); //Creates queries, and gets the name of the object on which the queries must be made
        void SetTextOnScreen(dynamic gridPage); //Sets the queries results (text) on the screen, as parameter the grid on which it must be drawn on
        string ChangeMainAttributeName(Object sender); //Converts the object name (most of the times an button) if needed to match the DB attributes
    }
    //Main job is to make the raw SQL query result more prettier and to create the text blocks in which the query result text will be shown
    public interface IPrepareQueryForScreenDisplay {
        string ConvertRawQueryResultToNormalText(string rawQueryText); //Converts the querty result to a more pretty, human readably text
        void CreateTextBlock(dynamic gridPage, string queryResult, int gridRow); //Creates the textblocks for the screen
    }
    //Main Job is to give the concrete classes the methods for them to be able to be visited
    public interface IUserNameAndPasswordVisit<T> { 
        void VisitTheLoginInformation(ILoginVisitor<T> visitor); //Method for the concrete classes to be able to be visited
        T GetLoginInformationValue(); //To get the username or password
    }
    //Main Job is to store the username and password (in an array) and then calls a method from another class that checks the username and password
    public interface ILoginVisitor<T> {
        bool IsLoginInSucceded(); //Returns whetever the login is a success
        void OnPassword(IUserNameAndPasswordVisit<string> userNameOrPassWord); //Stores the username in an array
        void OnUsername(IUserNameAndPasswordVisit<string> userNameOrPassWord); //stores the password in an array
        void OnNone(); //To avoid null objects
    }
}

