using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MundoController : MonoBehaviour
{
    public BotonNivel[] botonesNiveles;

    public int nivelMaximo;

    private void Awake()
    {
        nivelMaximo = PlayerPrefs.GetInt("nivelMaximo");
        if (nivelMaximo == 0 )
        {
            nivelMaximo = 1;
            PlayerPrefs.SetInt("nivelMaximo", 1);
        }
    }
    void Start()
    {

        for(int i = 1;i<=nivelMaximo;i++)
        {
            botonesNiveles[i].ActivaNivel();
        }
    }

   
}
