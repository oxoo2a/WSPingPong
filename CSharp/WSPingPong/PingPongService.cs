namespace WSPingPong
{
    using System.Diagnostics;

    public class PingPongService : IPingPongService
    {
    
        public void Ball_In(string ball)
        {
            Debug.WriteLine("I got a ball: ({0})", ball);
        }

        public string Ball_Out()
        {
            const string ball = "BALL";
            Debug.WriteLine("Here is your ball: ({0})", ball);
            return ball;
        }
    }
}
