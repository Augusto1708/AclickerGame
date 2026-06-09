using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolitoCae : MonoBehaviour
{
    public float velocidad;
    public bool puedeCaer=true;
    public float maxAdelante;
  // public GameObject ArbolPadre;

    private void Update()
    {
        if(puedeCaer)
        {
            transform.Rotate(0, 0, -velocidad * Time.deltaTime);
            if (transform.eulerAngles.z <= maxAdelante && transform.eulerAngles.z >= 180f)
            {
                puedeCaer = false;
                Invoke("DestruyeArbol",2.0f);
                //  Debug.Log("maximoAdelante");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==LayerMask.NameToLayer("Enemigos"))
        {
            EnemigoBase scriptEnemigo = collision.GetComponent<EnemigoBase>();
            if(scriptEnemigo != null) 
            {
                if(puedeCaer)
                {
                    scriptEnemigo.MuerteEnemigo();//solo mata mientras esta cayendo
                }
               
            }
        }
    }
    
    public void DestruyeArbol()
    {
        gameObject.SetActive(false);
    }

}

