using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonNivel : MonoBehaviour
{
    public bool sePuedeJugar=false;
    public GameObject activado, desactivado;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivaNivel()
    {
       
            activado.SetActive(true);
            desactivado.SetActive(false);
            sePuedeJugar = true;
        
    }
    public void CambiarEscena(string nivel)
    {
    
        if (sePuedeJugar) 
        {
         
            SceneManager.LoadScene(nivel);
        }
        
    }
}
