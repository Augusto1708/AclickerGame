using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{

    public float maxIzqu;
    public float maxDer;
    public float velocidad;
    public Rigidbody2D RB2D;
    public bool presionaLateral;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void MoverIzquierda()
    {
        if(transform.position.x>-2.4)
        {
            RB2D.velocity = new Vector2(-velocidad/**Time.deltaTime*/, RB2D.velocity.y);
            Invoke("DetectaLimite", 0.1f);
        }
      
    }
    public void MoverDerecha()
    {
        if(transform.position.x<40)
        {
            RB2D.velocity = new Vector2(velocidad /** Time.deltaTime*/, RB2D.velocity.y);
            Invoke("DetectaLimite", 0.1f);
        }
       
    }
    public void DetieneCamara()
    {
        RB2D.velocity = new Vector2(0f,0f);
    }
    public void DetectaLimite()
    {
        if(transform.position.x<-2||transform.position.x>40)
        {
            DetieneCamara();
        }
        else
        {
            Invoke("DetectaLimite", 0.1f);
        }
    }
}
