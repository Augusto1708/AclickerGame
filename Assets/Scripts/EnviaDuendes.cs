using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnviaDuendes : MonoBehaviour
{
    public LevelController controller;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Enemigo") 
        {
            controller.enemigosEnCasa++;
            controller.VerificaGO();
          
            collision.gameObject.SetActive(false);
        }
    }
}
