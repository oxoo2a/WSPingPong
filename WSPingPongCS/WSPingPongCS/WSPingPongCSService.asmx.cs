using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSPingPongCS
{
    /// <summary>
    /// Summary description for WSPingPongCSService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSPingPongCSService : System.Web.Services.WebService
    {
        static string ball;
        static int round = 0;
        [WebMethod]
        public void Ball_In(string ball_)
        {
            ball = ball_;
        }
        [WebMethod]
        public string Ball_Out()
        {
            string ret=ball;
            ball = "";
            return ret;
        }

        // Wenn false, bedeutet, ein Ball ist noch da.
        [WebMethod]
        public bool Ball_Check()
        {
            if (ball != "" && ball.Length > 0)
                return false;
            else
                return true;
        }
    }
}
