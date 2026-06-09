using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolAndante : MonoBehaviour
{
    public Rigidbody2D body;
    public float velocity;
    public GameObject raiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        
    }
    public void Movimiento()
    {
        body.velocity = new Vector3(velocity*Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject.layer== LayerMask.NameToLayer("Enemigos"))
        //{
        //    Debug.Log("toca a un duende cochino");
        //    velocity = 0;


        //}
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
      //  velocity = 20;
    }


}
