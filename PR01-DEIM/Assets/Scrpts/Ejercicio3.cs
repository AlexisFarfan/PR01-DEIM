using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{

    public string saludo;

    // Start is called before the first frame update
    void Start()
    {
      
        Saludo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Saludo()
    {
        var nombre = "Alvaro";
        saludo = "hola";
        print(saludo+" "+nombre);

    }
}
