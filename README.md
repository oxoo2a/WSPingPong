WSPingPong
==========

Central source code and document hub for our group exercise "web services".

The goal of this project is to implemented different parts of a distributed application that communicate a virtual ball using web service technologies.

The following for parts have to be implemented:

1. A stateless session bean running in some application server with a simple entity bean or singleton instance for keeping state. The session bean offers a web service endpoint.
2. A self-hosted C# web service
3. A Java client accessing both web services
4. A C# client accessing the two web services.

The two web services define appropriate WSDL documents with the following two methods:

1. void Ball_In ( string ball); 
2. string Ball_Out (); // no ball arrived if the empty string is returned.

Have fun!
