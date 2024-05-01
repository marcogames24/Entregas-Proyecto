using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{
    
    public float vida = 100, vidaMaxima = 100;
    public Image barraVida;
    public Animator animador;
    
    void Update()
    {
        barraVida.transform.localScale = new Vector2(vida / vidaMaxima, 1);
        if (vida > vidaMaxima)
        {
            vida = vidaMaxima;
        }
        else if (vida > 67)
        {
            barraVida.color = Color.magenta;
        }
        else if (vida > 33)
        {
            barraVida.color = Color.yellow;
        }
        else
        {
            barraVida.color = Color.red;
           
        }
        if (vida <= 0)
        {
            vida = 0;

            animador.SetTrigger("muerte");
            //StartCoroutine(ReinciciarCorrutiva());
            //SceneManager.LoadScene(0);
        }
    }
    public IEnumerator ReinciciarCorrutiva()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);

    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}