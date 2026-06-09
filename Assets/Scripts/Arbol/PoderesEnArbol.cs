using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderesEnArbol : MonoBehaviour
{
    public PoweController PC;
   // public Rigidbody2D RBArbolitoCae;
    public float fuerza;
    public GameObject Castorsito,ArbolitoNormal,ArbolitoCae,ArbolAndante;
  
    public bool ArbolNormal = true;//es el arbol sin ponerle poderes

    private Coroutine rotacionActiva;
    //  public bool florPower, andantePower, castorPower;
    // Start is called before the first frame update
    void Start()
    {
        PC = FindObjectOfType<PoweController>();
   ;
        

        //florPower = PC.ActivaFLoresPower;
        //andantePower= PC.ActivaArbolAndantePower;
        //castorPower = PC.ActivaCastoresPower;
    }

    // Update is called once per frame
    void Update()
    {
      
       
    }
    void OnMouseDown()
    {
        if(ArbolNormal)
        {
            if (PC.ActivaCastoresPower)
            {
                Castorsito.SetActive(true);
       
                Invoke("ApareceArbolCae", 1.0f);
                ArbolNormal= false;

            }
            else if (PC.ActivaArbolAndantePower)
            {
             
                ApareceArbolAndante();
                ArbolNormal = false;
            }
            else if (PC.ActivaFLoresPower)
            {
              
            }
        }
      
        

    }
   public void ApareceArbolCae()
    {
        Castorsito.SetActive(false);
        ArbolitoNormal.SetActive(false);
        ArbolitoCae.SetActive(true);
        //   RBArbolitoCae.AddForce(Vector3.forward * fuerza, ForceMode2D.Impulse);
        // Destroy(gameObject);
    
    }

    public void ApareceArbolAndante()
    {
        ArbolAndante.SetActive(true);
        ArbolitoNormal.SetActive(false);
    }

   

}
