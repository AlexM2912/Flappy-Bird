using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ControlJuego : MonoBehaviour
{
    public static ControlJuego instancia;

    public TextMeshProUGUI textoPuntaje;
    public GameObject panelPausa;
    public GameObject panelDerrota;

    private int puntaje = 0;
    public bool juegoPausado = false;
    public bool juegoTerminado = false;

    void Awake()
    {
        instancia = this;
    }

    void Start()
    {
        Time.timeScale = 1f;
        puntaje = 0;
        ActualizarPuntaje();

        if (panelPausa != null) panelPausa.SetActive(false);
        if (panelDerrota != null) panelDerrota.SetActive(false);
    }

    void Update()
    {
        if (juegoTerminado) return;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
                ReanudarJuego();
            else
                PausarJuego();
        }
    }

    public void SumarPunto()
    {
        if (juegoTerminado) return;

        puntaje++;
        ActualizarPuntaje();
    }

    void ActualizarPuntaje()
    {
        if (textoPuntaje != null)
            textoPuntaje.text = "Puntaje\n" + puntaje;
    }

    public void PausarJuego()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        if (panelPausa != null) panelPausa.SetActive(true);
    }

    public void ReanudarJuego()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        if (panelPausa != null) panelPausa.SetActive(false);
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER");

        juegoTerminado = true;
        Time.timeScale = 0f;

        if (panelDerrota != null)
            panelDerrota.SetActive(true);
    }

    public void ReiniciarJuego()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void IrAlInicio()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Inicio");
    }
}