/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.asysob.service;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import javax.ejb.Stateless;
import javax.jws.Oneway;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;

/**
 *
 * @author kauk, devinmotion
 */
@WebService(serviceName = "WSPingPong")
@Stateless()
public class WSPingPong {

    /**
     * Web service operation
     */
    @WebMethod(operationName = "Ball_In")
    @Oneway
    public void Ball_In(@WebParam(name = "ball") String ball) {
        try {
            BufferedWriter bw = new BufferedWriter(new FileWriter("ball"));
            bw.write(ball + "+");   //hier wird Datei-Zeile ueberschrieben, also muss ball auch mit
            bw.flush();
            bw.close();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());       //geht das auf Server? siehe auch in Ball_Out !
        }
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "Ball_Out")
    public String Ball_Out() {
        String ball = "";   //leerer String wird zurueckgegeben, wenn noch kein Ball da bzw. schon wieder weg
        try {
            BufferedReader br = new BufferedReader(new FileReader("ball"));
            ball = br.readLine();
            br.close();

            File ballFile = new File("ball");
            ballFile.delete();  //ball-Datei loeschen, damit spaeter leerer String zurueck kommt
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return ball;
    }
}
