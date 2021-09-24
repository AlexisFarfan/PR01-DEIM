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

        StartCoroutine("Cronometro");
       
    }

    // Update is called once per frame
   
    IEnumerator Cronometro()
    {
        for (int n = 0; n <= 20; n++)
        {
            contador.text = " " + n;
            yield return new WaitForSeconds(1f);
        }
    }
}
