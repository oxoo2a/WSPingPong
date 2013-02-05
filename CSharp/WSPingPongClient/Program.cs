namespace WSPingPongCSClient
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Using C# service...");
            var csService = new PingPongServiceReference.PingPongServiceClient();
            
            string ball = "C#_Ball";
            // send a ball to the C# service
            Console.WriteLine("Send the ball ({0}) to the C# service.", ball);
            csService.Ball_In(ball);

            Thread.Sleep(1000);

            Console.WriteLine("Check whether ball exists.");
            Console.WriteLine(csService.Ball_Available()
                                  ? "Ball exists on the server!"
                                  : "Ball does NOT exist on the server!");

            Thread.Sleep(1000);

            Console.WriteLine("Get the ball from the C# service.");
            ball = csService.Ball_Out();
            Console.WriteLine("Got the ball: {0}", ball);

            Console.WriteLine("Press 'ANY KEY' to terminate...");
            Console.ReadKey();

            //while (true)
            //{
            //ball = javaClient.Ball_Out();
            //if (ball != "" && ball.Length > 0)
            //{

            //while (true) //warten, bis kein Ball auf dem Server liegt.
            //{
            //if (csService.Ball_Available())
            //{
            //    csService.Ball_In(ball);
            //    ball = "";
            //    break;
            //}
            //Thread.Sleep(1000);
            //    }
            //}

            //Thread.Sleep(1000);
            //}

        }
    }
}
