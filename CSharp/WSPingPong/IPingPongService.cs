namespace WSPingPong
{
    using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPingPongService" in both code and config file together.
    [ServiceContract]
    public interface IPingPongService
    {
        /// <summary>
        /// Receives a ball and sets the server-side ball to it.
        /// </summary>
        /// <param name="ball">The ball to receive.</param>
        [OperationContract]
        void Ball_In(string ball);

        /// <summary>
        /// Gives the server-side ball to the client asking for it and empties the local variable.
        /// </summary>
        /// <returns>The ball as string.</returns>
        [OperationContract]
        string Ball_Out(); // no ball arrived if the empty string is returned.

    }

}
