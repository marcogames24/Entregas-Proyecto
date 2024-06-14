using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int valor;
    public AudioSource sonidoMoneda;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Reproduce el sonido de la moneda
        AudioSource.PlayClipAtPoint(sonidoMoneda.clip, transform.position);


        GamePoints controlPuntos = FindAnyObjectByType<GamePoints>();
            controlPuntos.puntos += valor;
            controlPuntos.textoPuntos.text = "Puntos: " + controlPuntos.puntos;
            Destroy(gameObject);


        
    }
}