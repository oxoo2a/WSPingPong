namespace WSPingPongClient
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Using C# service...");
            var csService = new CSharpPingPongService.PingPongServiceClient();
            
            string ball = "C#_Ball";
            // send a ball to the C# service
            Console.WriteLine("Send the ball ({0}) to the C# service.", ball);
            csService.Ball_In(ball);

            Thread.Sleep(1000);

            Console.WriteLine("Get the ball from the C# service.");
            ball = csService.Ball_Out();
            Console.WriteLine("Got the ball: {0}", ball);

            Console.WriteLine("Press 'ANY KEY' to terminate...");
            Console.ReadKey();

            //Console.WriteLine("Using Java service...");
            //var javaService = new JavaPingPongService.WSPingPongClient();

            //ball = "Java_Ball";
            //// send a ball to the Java service
            //Console.WriteLine("Send the ball ({0}) to the Java service.", ball);
            //javaService.Ball_In(ball);

            //Thread.Sleep(1000);

            //Console.WriteLine("Get the ball from the Java service.");
            //ball = javaService.Ball_Out();
            //Console.WriteLine("Got the ball: {0}", ball);

            //Console.WriteLine("Press 'ANY KEY' to terminate...");
            //Console.ReadKey();
        }
    }
}
