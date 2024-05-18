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

    public void Volver()
    {
        SceneManager.LoadScene("MenuPrincipal");

    }
    public IEnumerator ReinciciarCorrutiva()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);

    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
