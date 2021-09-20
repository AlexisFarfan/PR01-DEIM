using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{

    int vidas;

    // Start is called before the first frame update
    void Start()
    {
        // Saludo("Alexis",29);

        //peraciones(24,74);

        //par e impar

        vidas = 10;
        print(Espar(vidas));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void Saludo(string nombre,int edad)
    {
        
        print("hola "+ nombre + ". Tu edad es de " + edad + " años");

    }*//*
   
    void operaciones(int num1 , int num2 )
    {
        var resta = num2 - num1;
        bool t;
        if (resta == 98)
        {
            print(t = true);

        }
        else if  (resta > 98)
        {
            print(t = false);
        }

        else 
        {
            print(t = false);
        }
     */

     bool Espar(int numero)
    {
        bool esNumeroPar;

        if (numero % 2 == 0)
        {
            esNumeroPar = true;
        }
        else 
        {
            esNumeroPar = false;
        }

         return esNumeroPar;
    }

    }
    



