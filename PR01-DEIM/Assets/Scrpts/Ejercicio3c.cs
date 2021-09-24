using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio3c : MonoBehaviour
{
    [SerializeField] Text contador;
  

    // Start is called before the first frame update
    void Start()
    {

       //StartCoroutine("Contador");
       
    }

    // Update is called once per frame
     void Update()
    {
        /*
       
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine("Contador");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            StopCoroutine("Contador");
        }
        */

        if  (Input.GetKey("space"))
        {
            StartCoroutine("Contador");
                   
        }
       /* else
        {
            StopCoroutine("Contador");
        }
*/
    }
    IEnumerator Contador()
    {
       
        
        for (int h = 0; h<=60 ; h++)
        {
        
            for (int m =0; m<=60; m++)
            {
                for(int s=0; s<=60; s++)
                {
                    contador.text = h + ":" + m + ":" + s;
                    yield return new WaitForSeconds(1f);
                }
            }
        }

    }
}
