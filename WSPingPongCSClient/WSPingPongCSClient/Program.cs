using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WSPingPongCSClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            WSPingPongCSService.WSPingPongCSServiceSoapClient csClient = new WSPingPongCSService.WSPingPongCSServiceSoapClient();
            WSPingPongJavaService.WSPingPongJavaServiceClient javaClient = new WSPingPongJavaService.WSPingPongJavaServiceClient();
            string ball = "C#_Ball";
            csClient.Ball_In(ball);
            ball = "";
            while (true)
            {
                ball = javaClient.Ball_Out();
                if (ball != "" && ball.Length > 0)
                {
                    System.Console.WriteLine(ball);
                    while (true) //warten, bis kein Ball auf dem Server liegt.
                    {
                        if (csClient.Ball_Check())
                        {
                            csClient.Ball_In(ball);
                            ball = "";
                            break;
                        }
                        Thread.Sleep(300);
                    }
                }

                Thread.Sleep(1000);

            }

        }
    }
}
