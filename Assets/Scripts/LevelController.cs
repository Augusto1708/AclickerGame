using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public int enemigosEnCasa;// los que llegaron
    public int enemigosGameOver;//los necesarios para acabar el juego
    public GameObject gameOver;
    public GameObject nextLevel;
    public int flowers;
    public int flowersEsteNivel;// para no confundir con las flores que ya teniamos
    public TextMeshProUGUI textoFlores;
    public TextMeshProUGUI textoDuendes;
    public int enemigosTotales;
    [Header("Siguiente Nivel")]
    public int anteriorNivelMaximo;
    public int nuevoNivelMaximo;


    // Start is called before the first frame update
    public void Awake()
    {
        PausaJuego();
    }
    void Start()
    {
        flowers=PlayerPrefs.GetInt("Flores");
        textoFlores.text = "Flores: " + flowers;
       

    }
   public void IniciaJuego()
    {
        Time.timeScale = 1;
    }
   public  void PausaJuego()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VerificaGO()
    {
        textoDuendes.text = "Duendes En Casa: " + enemigosEnCasa + "/" + enemigosGameOver;
        if(enemigosEnCasa>=enemigosGameOver)
        {
            gameOver.SetActive(true);
        }
        else if(flowersEsteNivel+enemigosEnCasa==enemigosTotales)
        {
            Debug.Log("Pasaste de Nivel");
          //  Debug.Log("Pasaste de Nivel");
            PlayerPrefs.SetInt("Flores", flowers);
            nextLevel.SetActive(true);
            NivelMaximo();

        }
    }
    public void VerificaFlores()
    {
        flowers++;
        flowersEsteNivel++;
        textoFlores.text = "Flores: " + flowers;
        if (flowersEsteNivel + enemigosEnCasa == enemigosTotales)
        {
            Debug.Log("Pasaste de Nivel");
            PlayerPrefs.SetInt("Flores", flowers);
            nextLevel.SetActive(true);
            NivelMaximo();


        }
    }
    public void CambiaEscena()
    {
        SceneManager.LoadScene("Tiendita");
    }
    public void ReiniciaEscena(string Escena)
    {
        SceneManager.LoadScene(Escena);
    }
    public void NivelMaximo()
    {
        PlayerPrefs.GetInt("nivelMaximo", anteriorNivelMaximo);
        
            if(nuevoNivelMaximo>anteriorNivelMaximo)
        {

            PlayerPrefs.SetInt("nivelMaximo", nuevoNivelMaximo);
            PlayerPrefs.Save();
        }
      
    }
}
