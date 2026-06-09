using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscilacionEnemigo : MonoBehaviour
{
    public float maxAdelante;
    public float maxAtras;
    public bool Adelante;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
       Adelante = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (Adelante)
        {

            transform.Rotate(0, 0, velocidad * Time.deltaTime);
            if (transform.eulerAngles.z >= maxAdelante&& transform.eulerAngles.z <= 180f)
            {
                Adelante = false;
              //  Debug.Log("maximoAdelante");
            }

          
        }
        else
        {
            transform.Rotate(0, 0, -velocidad * Time.deltaTime);
          
            if (transform.eulerAngles.z <= maxAtras&& transform.eulerAngles.z >=180f)
            {
                Adelante = true;
             //   Debug.Log("maximoAtras");
            }
        }
    }
}
