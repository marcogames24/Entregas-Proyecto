using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class WinMagicZone : MonoBehaviour
{
    public Animator animador ; 
    public LifeController Controlvida;
    private void OnTriggerEnter2D(Collider2D other)
    {
        animador.SetTrigger("Victory");

        Controlvida.Invoke("Reset",3);
    }
    public AudioSource victorySound; // Asigna el GameObject con el Audio Source para la victoria
    public AudioSource defeatSound; // Asigna el GameObject con el Audio Source para la derrota

    // Llama a estos métodos cuando ocurra la victoria o la derrota
    public void PlayVictorySound()
    {
        victorySound.Play();
    }
}
