using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Here are the interfaces of the application

namespace Jaar_1_Project_4 {
    //Main job is to create queries
    public interface  IQueryHandler {
        void MakeQueries(string itemForQuery); //Creates queries, and an example for parameter: event room: H.202.00
        void SetTextOnScreen(dynamic gridPage); //Sets the queries results on the screen, as paramter the grid on which it must be painted on
        string ChangeMainAttributeName(Object sender); //Changes the main attribute name, it most of the times become a page name
    }
    //Main job is to send commando to create queries and textblocks
    public interface IPagePopup {
        void MakeQueriesAndTextBlocks();
    }
    //Main job is to prepare the quries for 
    public interface IPrepareQueryForScreenDisplay {
        string ConvertRawQueryResultToNormalText(string rawQueryText); //Converts the querty result to a human readably text
        void CreateTextBlock(dynamic gridPage, string queryResult, int gridRow); //Creates the textblocks for the screen
    }
    //Main Job is to give the concrete classes the methods for them to be able to be visited
    public interface IUserNameAndPasswordVisit<T> { //Interfaces offers the classic to visit and lambda way
        void NoLamdaVisit(ILoginVisitor<T> visitor);
        U LambdaVisit<U>(Func<U> onNone, Func<T, U> OnSomeUsernameLogin, Func<T, U> onSomePasswordLogin);
        T GetLoginInformationValue();
    }
    public interface ILoginVisitor<T> {
        bool OnLoginCheck();
        void OnPassword(IUserNameAndPasswordVisit<string> IUserNameAndPassWordObject);
        void OnUsername(IUserNameAndPasswordVisit<string> IUserNameAndPassWordObject);
        void OnNone();
    }
}
