using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource victorySound; // Asigna el GameObject con el Audio Source para la victoria
    public AudioSource defeatSound; // Asigna el GameObject con el Audio Source para la derrota

    // Llama a estos métodos cuando ocurra la victoria o la derrota
    public void PlayVictorySound()
    {
        victorySound.Play();
    }

    public void PlayDefeatSound()
    {
        defeatSound.Play();
    }
}
