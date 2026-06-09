using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tienda : MonoBehaviour
{
    public int flowers;
    public int NvCastores=0;
    public TextMeshProUGUI textoNvCastores;
    public int NvConvertirFlores=1;
    public TextMeshProUGUI textoNvConvertirFLores;
    public int NvArbolesAndantes = 0;
    public TextMeshProUGUI textoNvArbolesAndantes;
    public int NvMejoraCasa = 1;
    public TextMeshProUGUI textoNvMejoraCasa;

    public GameObject graciasPorComprar, floresInsuficientes;


    public TextMeshProUGUI textoFlores;

  
  
    void Start()
    {
        flowers = PlayerPrefs.GetInt("Flores");
        NvCastores = PlayerPrefs.GetInt("NivelCastores");
        NvConvertirFlores = PlayerPrefs.GetInt("NivelConvertirFlores");
        NvArbolesAndantes = PlayerPrefs.GetInt("NivelArbolesAndantes");
        NvMejoraCasa = PlayerPrefs.GetInt("NivelMejorarCasa");
        

        textoFlores.text = "Flores= " + flowers;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Animales
    public void Castores()
    {
        if(NvCastores==0)
        {
            if(flowers>=15)
            {
                flowers = flowers - 15;
                NvCastores = 1;
                PlayerPrefs.SetInt("NivelCastores", NvCastores);
                textoNvCastores.text = "Castores\n" + "Nvl: " + NvCastores;
                GraciasPorComprar();
            }
            else
            {
                FloresInsuficientes();
            }
           
        }
        else if (NvCastores == 1)
        {
            if(flowers >= 30) 
            {
                flowers-= 30;
                NvCastores = 2;
                PlayerPrefs.SetInt("NivelCastores", NvCastores);
                textoNvCastores.text = "Castores\n" + "Nvl: " + NvCastores;
                GraciasPorComprar();
            }
            else

            {
                FloresInsuficientes();
            }
           
        }
        else if(NvCastores == 2)
        {
            if(flowers>=50)
            {
                flowers -= 50;
                NvCastores = 3;
                PlayerPrefs.SetInt("NivelCastores", NvCastores);
                textoNvCastores.text = "Castores\n" + "Nvl: " + NvCastores;
            }
            else
            {
                FloresInsuficientes();
            }
         
        }
    }
    //Plantas
    public void ConvertirFlor()
    {
        if (NvConvertirFlores == 1)
        {
            NvConvertirFlores = 2;
            PlayerPrefs.SetInt("NivelConverirFlores", NvConvertirFlores);
            textoNvConvertirFLores.text="Convertir Flor\n" + "Nvl: " + NvConvertirFlores;
        }
        else if (NvConvertirFlores == 2)
        {
            NvConvertirFlores = 3;
            PlayerPrefs.SetInt("NivelConverirFlores", NvConvertirFlores);
            textoNvConvertirFLores.text = "Convertir Flor\n" + "Nvl: " + NvConvertirFlores;
        }
    }
    public void ArbolesAndantes()
    {
        if(NvArbolesAndantes==0)
        {
            if(flowers>=20)
            {
                flowers = flowers - 20;
                NvArbolesAndantes = 1;
                PlayerPrefs.SetInt("NivelArbolesAndantes", NvArbolesAndantes);
                textoNvArbolesAndantes.text = "Arboles Andantes \n" + "Nvl: " + NvArbolesAndantes;
                GraciasPorComprar();
            }
            else
            {
                FloresInsuficientes();
            }
       
        }
        else if ( NvArbolesAndantes==1)
        {
            if(flowers>=40)
            {
                flowers = -40;
                NvArbolesAndantes = 2;
                PlayerPrefs.SetInt("NivelArbolesAndantes", NvArbolesAndantes);
                textoNvArbolesAndantes.text = "Arboles Andantes \n" + "Nvl: " + NvArbolesAndantes;
                GraciasPorComprar();
            }
            else
            {
                FloresInsuficientes();
            }
          

        }
        else if (NvArbolesAndantes == 2)
        {
            if(flowers>=60)
            {
                flowers= -60;
                NvArbolesAndantes = 3;
                PlayerPrefs.SetInt("NivelArbolesAndantes", NvArbolesAndantes);
                textoNvArbolesAndantes.text = "Arboles Andantes \n" + "Nvl: " + NvArbolesAndantes;
                GraciasPorComprar();
            }
            else
            {
                FloresInsuficientes();
            }
      

        }
    }
    

    //Mejoras
    public void MejorarCasa()
    {
        if (NvMejoraCasa == 1)
        { 
            if(flowers>=30)
            {
                flowers = flowers - 30;
                NvMejoraCasa = 2;
                PlayerPrefs.SetInt("NivelMejorarCasa", NvMejoraCasa);
                textoNvMejoraCasa.text = " Mejorar Casa \n" + "Nvl:" + NvMejoraCasa;
                GraciasPorComprar();
            }
            else
            {
                FloresInsuficientes();
            }
         
        }
        else if (NvMejoraCasa == 2)
        {
            if(flowers>= 60)
            {
                flowers= -60;
                NvMejoraCasa = 3;
                PlayerPrefs.SetInt("NivelMejorarCasa", NvMejoraCasa);
                textoNvMejoraCasa.text = " Mejorar Casa \n" + "Nvl:" + NvMejoraCasa;
                GraciasPorComprar();
            }
            else
            {
                FloresInsuficientes();
            }
          
        }
    }

    public void GraciasPorComprar()
    {
        graciasPorComprar.SetActive(true);
        Invoke("DesapareceMensaje", 3.0f);
        textoFlores.text = "Flores= " + flowers;
    }
    public void FloresInsuficientes()
    {
        floresInsuficientes.SetActive(true);
        Invoke("DesapareceMensaje", 3.0f);
    }

    public void DesapareceMensaje()
    {
        graciasPorComprar.SetActive(false);
        floresInsuficientes.SetActive(false) ;
    }

    public void SiguienteNivel()
    {

    }
}
