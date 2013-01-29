namespace WSPingPongHost
{
    using System;
    using System.ServiceModel.Description;
    using System.ServiceModel;

    class Program
    {
        static void Main()
        {
            var baseAddress = new Uri("http://localhost:4242/PingPongService");
            var host = new ServiceHost(typeof (WSPingPong.PingPongService), baseAddress);

            // use MEX to test the WS via browser
            var mexBehavior = new ServiceMetadataBehavior
                                  {
                                      HttpGetEnabled = true,
                                      HttpGetUrl = new Uri("http://localhost:4242/PingPongService/wsdl")
                                  };

            host.Description.Behaviors.Add(mexBehavior);
            var mexBinding = MetadataExchangeBindings.CreateMexHttpBinding();
            host.AddServiceEndpoint(typeof (IMetadataExchange), mexBinding, "mex");
            host.Open();

            Console.WriteLine("PingPong web service started. Press 'ANY KEY' to terminate...");
            Console.ReadKey();

            if(host.State != CommunicationState.Closed)
            {
                host.Close();
            }

        }
    }
}
