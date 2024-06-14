using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recovery : MonoBehaviour
{
    public int valor;
    public AudioSource sonidoSalud;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Reproduce el sonido de cuando rellena la salud
        AudioSource.PlayClipAtPoint(sonidoSalud.clip, transform.position);
        LifeController lifeControl = FindAnyObjectByType<LifeController>();
        lifeControl.vida += valor;
        if (lifeControl.vida>lifeControl.vidaMaxima) 
        {
            lifeControl.vida = lifeControl.vidaMaxima;
        }
        Destroy(gameObject);
    }
}
