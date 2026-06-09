using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raiz : MonoBehaviour
{
    public Rigidbody2D body;
    public float velocity;
    public bool Adelante;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (Adelante)
        {
            MovimientoAdelante();
        }
    else
        {
            MovimientoAtras();
        }
        if (transform.localPosition.x >= 2.54)
        {
            Adelante = false;
        }
       if (transform.localPosition.x <= 0.43)
        {
           Adelante=true;
        }

    }
    public void MovimientoAdelante()
    {
        body.velocity = new Vector3(velocity * Time.deltaTime, 0, 0);
    }
    public void MovimientoAtras()
    {
        body.velocity = new Vector3(-velocity * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer== LayerMask.NameToLayer("Enemigos"))
            
        {
            EnemigoBase scriptEnemigo = collision.GetComponent<EnemigoBase>();
            if (scriptEnemigo != null)
            {
                
               scriptEnemigo.MuerteEnemigo();
                

            }

        }
    }
}
