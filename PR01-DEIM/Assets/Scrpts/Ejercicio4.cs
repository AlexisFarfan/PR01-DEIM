using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float moverY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * moverY * Time.deltaTime);


        float moverX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.left * moverX * Time.deltaTime);

        float moverZ = Input.GetAxis("Profundidad") * speed;
        transform.Translate(Vector3.back * moverZ * Time.deltaTime);


        if (Input.GetMouseButtonDown(0))
        {
            print("disparo");
        }

    }
}
