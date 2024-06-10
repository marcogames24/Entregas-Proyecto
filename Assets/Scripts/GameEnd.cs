using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public void Salir()
    {
        Application.Quit();

    }
    /*
    public void Volver()
    {
        SceneManager.LoadScene("MenuPrincipal");

    }
    */
    public IEnumerator ReinciciarCorrutiva()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);

    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
    public AudioSource victorySound; // Asigna el GameObject con el Audio Source para la victoria
    public AudioSource defeatSound; // Asigna el GameObject con el Audio Source para la derrota

    // Llama a estos métodos cuando ocurra la victoria o la derrota
    public void PlayDefeatSound()
    {
        defeatSound.Play();
    }
}
