using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    public GameObject  Proyectil;
    public float TiempoDisparo = 0;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Disparo", TiempoDisparo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Disparo()
    {
        Instantiate(Proyectil,transform.position,Quaternion.identity);
        Invoke("Disparo",TiempoDisparo);
    }
}
