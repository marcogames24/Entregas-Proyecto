using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientohorizontal : MonoBehaviour
{


    public float velocidad=2;
    public float salto=4.0f;
    public float gravity = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocidadHorizontal = Vector3.zero;

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.position = transform.position + new Vector3(velocidad, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.position = transform.position - new Vector3(velocidad, 0, 0) * Time.deltaTime;
        }


    }
}
