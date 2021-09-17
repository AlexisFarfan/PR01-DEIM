using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public int num1 = 3;
    [SerializeField] float num2;
   [SerializeField] bool alive=true;
    public string saludo = "hola";


    // Start is called before the first frame update
    void Start()
    {
        print(saludo + alive);
        print(num2 + " " + saludo);
        print(num1 + num2);
        print(saludo + " " +num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
