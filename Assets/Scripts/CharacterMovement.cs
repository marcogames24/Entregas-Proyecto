using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [Header("Estadisticas")]
    public float velocidadDeMovimiento = 10;
    public float fuerzaDeSalto = 3;
    private Vector2 direccion;

    [Header("Colisiones")]
    public Vector2 abajo;
    public float radioDeColision;
    public LayerMask layerpiso;


    [Header("Booleanos")]
    public bool puedoMover = true;
    public bool enSuelo = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Agarres();
    }

    private void Movimiento()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        direccion = new Vector2(x, y);

        Caminar(direccion);

        MejorarSalto();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (enSuelo)
            {
                Saltar();

            }
        }



    }
    private void MejorarSalto()
    {


        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (2.5f - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {

            rb.velocity += Vector2.up * Physics2D.gravity.y * (2.0f - 1) * Time.deltaTime;


        }


    }
    private void Agarres()
    {

        enSuelo = Physics2D.OverlapCircle((Vector2)transform.position + abajo, radioDeColision, layerpiso);
    }
    private void Saltar()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += Vector2.up * fuerzaDeSalto;

    }
    private void Caminar(Vector2 direccion)
    {
        if(puedoMover)
        {
            rb.velocity = new Vector2(direccion.x * velocidadDeMovimiento, rb.velocity.y);
            if (direccion != Vector2.zero) 
            { 
            if(direccion.x<0 && transform.localScale.x > 0) 
                {
                    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                
                }
            else if(direccion.x>0 && transform.localScale.x<0)
                {
                    transform.localScale = new Vector3(Mathf.Abs(-transform.localScale.x), transform.localScale.y, transform.localScale.z);
                }
            }
        }
    }









}

