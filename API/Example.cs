using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest {
    class MainClass {
        public static void Main(string[] args) {
            var url = "http://www.wschaijk.nl/api/api.php/SELECT-*-FROM-test";
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

            Console.WriteLine(content);
        }
    }
}