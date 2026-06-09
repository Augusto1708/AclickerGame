using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoweController : MonoBehaviour
{
    public int NvCastores;
    public int NvConvertirFlores;
    public int nivelAtaqueFlores;
    public int NvArbolesAndantes;
    public int NvMejoraCasa;
    public GameObject IconFlores, IconArbolesAndantes, IconCastores;
    public Button IconFloresB,IconArbolesAndantesB,IconCastoresB;

    public bool ActivaFLoresPower=true, ActivaArbolAndantePower=false,ActivaCastoresPower=false;
    


    // Start is called before the first frame update
    void Start()
    {
        NvCastores = PlayerPrefs.GetInt("NivelCastores");
        NvConvertirFlores = PlayerPrefs.GetInt("NivelConvertirFlores");
        NvArbolesAndantes = PlayerPrefs.GetInt("NivelArbolesAndantes");
        NvMejoraCasa = PlayerPrefs.GetInt("NivelMejorarCasa");
        if (NvConvertirFlores == 0) 
        {
            NvConvertirFlores = 1;
        }

        if (NvCastores == 0)
        {
            IconCastores.gameObject.SetActive(false);
        }
        else
        {
            IconCastores.gameObject.SetActive(true);
        }
        if (NvArbolesAndantes == 0)
        {
            IconArbolesAndantes.gameObject.SetActive(false);
        }
        else
        {
            IconArbolesAndantes.gameObject.SetActive(true);
        }
        ActivaFlores();


    }
   public void ActivaFlores()
    {
      ActivaFLoresPower = true;
      ActivaArbolAndantePower = false;
      ActivaCastoresPower = false;
      IconFloresB.image.color= Color.red;
      IconArbolesAndantesB.image.color = Color.white;
      IconCastoresB.image.color= Color.white;
        EstableceAtaque();
    }
    public void ActivaArbolesAndates()
    {
        ActivaFLoresPower = false;
        ActivaArbolAndantePower = true;
        ActivaCastoresPower = false;
        IconFloresB.image.color = Color.white;
        IconArbolesAndantesB.image.color = Color.red;
        IconCastoresB.image.color = Color.white;

        nivelAtaqueFlores = 0;// signicia que no puede atacar
    }
    public void ActivaCastores()
    {
        ActivaFLoresPower = false;
        ActivaArbolAndantePower = false;
        ActivaCastoresPower = true;
        IconFloresB.image.color = Color.white;
        IconArbolesAndantesB.image.color = Color.white;
        IconCastoresB.image.color = Color.red;
        nivelAtaqueFlores = 0;// signicia que no puede atacar
    }

    // Update is called once per frame
    public void EstableceAtaque()
    {
        nivelAtaqueFlores = NvConvertirFlores * 10;// siendo maximo el nivel5
    }

}
