using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recovery : MonoBehaviour
{
    public int valor;
    private void OnTriggerEnter2D(Collider2D other)
    {

        LifeController lifeControl = FindAnyObjectByType<LifeController>();
        lifeControl.vida += valor;
        if (lifeControl.vida>lifeControl.vidaMaxima) 
        {
            lifeControl.vida = lifeControl.vidaMaxima;
        }
        Destroy(gameObject);
    }
}
