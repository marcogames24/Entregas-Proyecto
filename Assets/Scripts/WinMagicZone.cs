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
}
