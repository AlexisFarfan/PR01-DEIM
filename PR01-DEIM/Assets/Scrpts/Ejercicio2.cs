 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // private int num1= 1;


    //private bool t;

    // Start is called before the first frame update
    void Start()
    {
        
        /*
       while(num1<=10)
        {
            print(num1);
            num1++;
        }
        */
        /*
        for (int num2 = 1;num2<=10;num2++)
        {

            print(num2);
        }
        */
        /*
        for (int n = 1; n <= 10; n++)
        {
            if (n <= 5)
            {
                t = true;
                print(t);
            }

           else
            {
                t = false;
                print(t);

            }
       
        */

        for (int n =1; n<=10; print (n))
        {
            n = Random.Range(1, 10);

            if (n==4)
            {
                print(n);
                print("enhorabuena");
                break;
            }
        }



       


    }

    // Update is called once per frame
    void Update()
    {

    

    }
}
