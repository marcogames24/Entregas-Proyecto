using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public float profundidad = -10, minXPos, maxXPos, velocidadCamara, suavidad = 0.3f;
    public Transform objetivo;
    private Vector3 velocidad;

    // Update is called once per frame
    void Update()
    {
        float nuevaPosX = objetivo.position.x;
        nuevaPosX = Mathf.Clamp(nuevaPosX, minXPos, maxXPos);
        Vector3 posObjetivo = new Vector3(nuevaPosX, objetivo.position.y, profundidad);
        Vector3 diferenciaPosicion = posObjetivo - transform.position;
        Vector3 movimientoCamara = diferenciaPosicion * velocidadCamara * Time.deltaTime;
        Vector3 nuevaPos = transform.position + movimientoCamara;

        transform.position = Vector3.SmoothDamp(transform.position,nuevaPos,ref velocidad,suavidad);
            
            










    }
}
