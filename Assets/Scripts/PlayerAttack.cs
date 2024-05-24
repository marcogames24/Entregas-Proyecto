using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float velocidad, ether, tiempoDesdeUltimoAtaque, cooldown = 1, costeEther = 10, etherMaximo = 100;
    public GameObject prefabProyectil;
    public Transform puntoCreacion, barra;
    // Start is called before the first frame update
    void Start()
    {
        ether = etherMaximo;
        ActualizarBarra();
    }

    // Update is called once per frame
    void Update()
    {
        tiempoDesdeUltimoAtaque += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && tiempoDesdeUltimoAtaque > cooldown && ether >= costeEther)
        {
            Proyectil proyectil = Instantiate(prefabProyectil).GetComponent<Proyectil>();

            proyectil.transform.position = puntoCreacion.transform.position;

            proyectil.rigidbody.velocity = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - proyectil.transform.position).normalized * velocidad;

            ether -= costeEther;
            ActualizarBarra();
            tiempoDesdeUltimoAtaque = 0;
        }
    }

    public void ActualizarBarra()
    {
        barra.localScale = new Vector2(ether / etherMaximo, 1);
    }
}
