using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{ 

    // Start is called before the first frame update
    void Start()
    {
        Saludo("Alexis",29);
       
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Saludo(string nombre,int edad)
    {
        
        print("hola "+ nombre + ". Tu edad es de " + edad + " años");

    }
   

    


}
