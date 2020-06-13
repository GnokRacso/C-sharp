using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {
    //不明白是你的事，反正这个我做的 我自然明白我写了什么
    /*
    不要怀疑，什么error都没有
    如果你想到更好的方法code，你牛逼
    */
    // Start is called before the first frame update
    void Start()
    {
        float a = 2f + 3.5f; 
        float b = 3f + 5.2f;
        int sum = (int)CalculateTwoNum(a, b);
        string str = "The sum is ";

        Debug.Log(str + sum );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float CalculateTwoNum ( float a, float b){
        return a + b;
    }
}
