using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    private int num1= 1;

    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {

        //es mas util el + que el ++ 

        if (num1 <= 100)
        {
            
           print(num1);
        }

        num1 = num1+1;


    }
}
