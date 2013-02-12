/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.asysob.client;

// c# and java webservice
import edu.asysob.service.csharp.IPingPongService;
import edu.asysob.service.csharp.PingPongService;
import edu.asysob.service.java.WSPingPong;
import edu.asysob.service.java.WSPingPong_Service;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author kauk, devinmotion
 */
public class WSPingPongClient {

    /**
     * Aufruf von Tester und wsdl File:
     * http://localhost:8080/WSPingPong/WSPingPong?WSDL fuer Java
     *
     * und
     *
     * http://localhost:4242/PingPongService/wsdl?wsdl fuer C#
     */
    public static void main(String[] args) {
        WSPingPong_Service javaService = new WSPingPong_Service();
        WSPingPong javaPingPong = javaService.getWSPingPongPort();

        PingPongService csharpService = new PingPongService();
        IPingPongService csharpPingPong = csharpService.getWSHttpBindingIPingPongService();

        String ball = "JavaBall";

        // start throwing ball to java service
        javaPingPong.ballIn(ball);
        while (true) {
            // sent java ball to c#
            csharpPingPong.ballIn(ball);
            // then try to get a ball from c# service
            do {
                ball = csharpPingPong.ballOut();
                sleepSomeTime();
            } while (ball.equals(""));
            // sent c# ball to java
            javaPingPong.ballIn(ball);
            sleepSomeTime();
        }

    }

    private static void sleepSomeTime() {
        try {
            Thread.sleep(1000);
        } catch (InterruptedException ex) {
            Logger.getLogger(WSPingPongClient.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
