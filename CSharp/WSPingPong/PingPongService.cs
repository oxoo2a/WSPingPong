namespace WSPingPong
{
    using System;

    public class PingPongService : IPingPongService
    {
        private string _ball;

        /// <summary>
        /// Receives a ball and sets the server-side ball to it.
        /// </summary>
        /// <param name="ball">The ball to receive.</param>
        public void Ball_In(string ball)
        {
            _ball = ball;
            Console.WriteLine("I got a ball: ({0})", _ball);
        }

        /// <summary>
        /// Gives the server-side ball to the client asking for it and empties the local variable.
        /// </summary>
        /// <returns>The ball as string.</returns>
        public string Ball_Out()
        {
            var ret = _ball;
            _ball = String.Empty;
            Console.WriteLine("Here is your ball: ({0})", ret);
            return ret;
        }

        /// <summary>
        /// Checks whether there is a server-side ball available to send out.
        /// </summary>
        /// <returns>Whether there exists a ball on the server.</returns>
        public bool Ball_Available()
        {
            return ((!String.IsNullOrEmpty(_ball)) && (_ball.Length > 0));
        }
    }
}
