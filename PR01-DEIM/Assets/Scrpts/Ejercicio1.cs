using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public int num1;
    [SerializeField] float num2;
   [SerializeField] bool alive;
    public string saludo;


    // Start is called before the first frame update
    void Start()
    {
        print(num1);
        print(num2);
        print(alive);
        print(saludo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
