using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Events;

public class EnemigoBase : MonoBehaviour
{
    
    public PoweController Pcontroller;
    public int dañoRecibido;
    public int dañoTotal;
    public int maximoVida,vida1,vida2,vida3,vida4;// lo maximo que puede ser golpeado el duende

    public Rigidbody2D RBD2D;
    public float velocity;
    public float normalVelocity;
    public GameObject ImagenBase;

    public GameObject[] Flor;
    public bool puedeCronometroNormalidad = false;
    public float maxCronometroNormalidad;
    public float cronometroNormalidad;



    public float spawnY, MinY, MaxY;
    public float spawnX, MinX, MaxX;

    public LevelController Lcontroller;

    [SerializeField] UnityEvent onClick;
     void Awake()
    {

        Pcontroller = FindObjectOfType<PoweController>();
        Lcontroller=FindObjectOfType<LevelController>();

    }
    void Start()
    {
        cronometroNormalidad = maxCronometroNormalidad;
    }
  

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        if(puedeCronometroNormalidad)
        {
           cronometroNormalidad-=Time.deltaTime ;
            if(cronometroNormalidad<=0)
            {
                VuelveNormalidad();
            }
        }
    }
    public void Movimiento()
    {
        RBD2D.velocity = new Vector3(-velocity * Time.deltaTime, 0, 0);
    }
    public void VuelveNormalidad()
    {
        dañoTotal = 0;
        velocity = normalVelocity;
        puedeCronometroNormalidad = false;
        cronometroNormalidad = maxCronometroNormalidad;   
        ImagenBase.SetActive(true);
        for(int i = 0; i < Flor.Length; i++) 
        {
            Flor[i].SetActive(false);
        }
        
    }
    private void OnMouseDown()
    {
        SeClcicka();
        //if(ImagenBase.activeSelf)
        //{
        //    ImagenBase.SetActive(false);
        //    Flor[0].SetActive(true);
        //    velocity = 0;
        //    puedeCronometroNormalidad = true;
        //}
        //else if (Flor[0].activeSelf)
        //{
        //    Flor[0].SetActive(false);
        //    Flor[1].SetActive(true);
        //    cronometroNormalidad = maxCronometroNormalidad;
        //}
        //else if (Flor[1].activeSelf)
        //{
        //    Flor[1].SetActive(false);
        //    Flor[2].SetActive(true);
        //    cronometroNormalidad = maxCronometroNormalidad;
        //}
        //else if (Flor[2].activeSelf)
        //{
        //    Flor[2].SetActive(false);
        //    Flor[3].SetActive(true);
        //    cronometroNormalidad = maxCronometroNormalidad;
        //}
        //else if (Flor[3].activeSelf)
        //{
        //    MuerteEnemigo();
        //}


    }
    public void MuerteEnemigo()
    {
        
        puedeCronometroNormalidad = false;
        spawnX = Random.Range(MinX, MaxX);
        spawnY = Random.Range(MinY, MaxY);
      //  transform.position = new Vector2(spawnX, spawnY); lo que hacia que quede de forma random

        Lcontroller.VerificaFlores();
        Destroy(gameObject);
    }

    //nueva forma para abajo
    public void Forma1()
    {
        ImagenBase.SetActive(false);
        Flor[0].SetActive(true);
        velocity = 0;
        puedeCronometroNormalidad = true;

    }
    public void Forma2()
    {
        Flor[0].SetActive(false);
        Flor[1].SetActive(true);
        cronometroNormalidad = maxCronometroNormalidad;
    }
    public void Forma3()
    {
        Flor[1].SetActive(false);
        Flor[2].SetActive(true);
        cronometroNormalidad = maxCronometroNormalidad;
    }
    public void Forma4()
    {
        Flor[2].SetActive(false);
        Flor[3].SetActive(true);
        cronometroNormalidad = maxCronometroNormalidad;
    }
    public void Muerte()
    {
        
        MuerteEnemigo();
    }
    public void SeClcicka()
    {
        dañoRecibido = Pcontroller.nivelAtaqueFlores;
        dañoTotal = dañoTotal + dañoRecibido;

        if (dañoTotal >= vida1 && dañoTotal < vida2) //entre 20 y40
        {
            Forma1();
        }
        else if (dañoTotal >= vida2 && dañoTotal < vida3)// entre 40 y 60
        {
            Forma2();
        }
        else if (dañoTotal >= vida3 && dañoTotal <vida4)
        {
            Forma3();
        }
        else if (dañoTotal >= vida4 && dañoTotal < maximoVida)
        {
            Forma4();
        }
        else if (dañoTotal >= maximoVida)
        {
            Muerte();
            
        }
        onClick.Invoke();
    }



}
