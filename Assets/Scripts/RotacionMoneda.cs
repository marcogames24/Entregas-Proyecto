using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMoneda : MonoBehaviour

 
    {
        public float xAngle, yAngle, zAngle;
        public GameObject Moneda;
    

    // Update is called once per frame
    void Update()
    { 
    Moneda.transform.Rotate(xAngle,yAngle,zAngle);
    }
}
