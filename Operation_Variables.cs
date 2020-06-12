using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations_Variables : Monobehavior {

    void Start(){
        /*
        Calculation ezpz:
            Addition        '+'
            Substitution    '-'
            Multiplication  '*'
            Division        '/'
        eg,
        */
        float a = 2.5f + 3.4f; //variable之间可以做calculation
        double b = 3.7 * 3.6d  //float and double 不用Casting 因为都是点数

        int sum = (int)a / (int)b; //this is <Casting>
        //put ‘float’ to see decimals, put ‘int’ to see whole numbers
        //float 可以变 int；int 不能变 float/double

        /*
        Output Variables:
        you can use,
            (1) print();
            (2) Debug.Log(); - 必须大字母，不然会error
        eg,
        */
        print (a); //output variable 不需要放 quotes“”
        Debug.Log("The sum is " + (sum)); 
        //^^这个叫String Concatenation，string加variable，一起放之间要 “+”
    }
    
    void Update(){

    }
}