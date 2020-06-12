using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : Monobehavior {

    void Start (){
        /*
        Variables for decimals:
        -Float (float)  = 32-bit number
        -Double (double)= 64-bit number (more precise, 更多小数点)

        Variable for whole number:
        -Integer (int) = output 出来的number 不会有小数点
            eg，
            int num = 123;
        */
        int a = 1;
        float b = 2.4f; //must have 'f' behind the number, number can without decimals
        double c = 2.5d; /*can without d, 不用吃饱没事做就放一个*/

        /*
        Variable for Sentences:
        -String (string) = character based variables
            eg，
        */
        string name = "Hehe My name is Kong Mun Jun";
        
        /*
        Variables for statements:
        -Boolean = normally used in conditional statement
            eg,
        */
        boolean t = true;
        boolean f = false;
    }

    void Update(){

    }
}