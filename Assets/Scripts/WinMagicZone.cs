using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator animador ; 
    public LifeController Controlvida;
    private void OnTriggerEnter2D(Collider2D other)
    {
        animador.SetTrigger("Victory");

        Controlvida.Invoke("Reiniciar",1);
    }
}
