namespace WSPingPong
{
    using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPingPongService" in both code and config file together.
    [ServiceContract]
    public interface IPingPongService
    {
        [OperationContract]
        void Ball_In(string ball);

        [OperationContract]
        string Ball_Out(); // no ball arrived if the empty string is returned.
    }

}
