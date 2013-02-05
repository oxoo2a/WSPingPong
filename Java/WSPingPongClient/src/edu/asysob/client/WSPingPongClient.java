/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.asysob.client;

import edu.asysob.servicereference.WSPingPong;
import edu.asysob.servicereference.WSPingPong_Service;

/**
 *
 * @author kauk, devinmotion
 */
public class WSPingPongClient {

    /**
     * Aufruf von Tester und wsdl File:
     * http://localhost:8080/WSPingPong/WSPingPong?Tester
     * http://localhost:8080/WSPingPong/WSPingPong?WSDL
     */
    
    public static void main(String[] args) {
        WSPingPong_Service service = new WSPingPong_Service();
        WSPingPong pingpong = service.getWSPingPongPort();

        String ball = "ball";
        String ball2;

        for (int i = 0; i < 5; i++) {
            pingpong.ballIn(ball);
            ball = pingpong.ballOut();
            System.out.println("Hier ist der Ball: " + ball);

            ball2 = pingpong.ballOut();
            System.out.println("Jetzt ist der Ball weg: " + ball2);
        }
    }
}
