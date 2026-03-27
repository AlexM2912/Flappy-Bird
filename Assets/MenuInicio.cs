using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    public GameObject panelInicio;
    public GameObject panelInstrucciones;

    void Start()
    {
        if (panelInicio != null) panelInicio.SetActive(true);
        if (panelInstrucciones != null) panelInstrucciones.SetActive(false);
    }

    public void IniciarJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void MostrarInstrucciones()
    {
        if (panelInicio != null) panelInicio.SetActive(false);
        if (panelInstrucciones != null) panelInstrucciones.SetActive(true);
    }

    public void VolverAlInicio()
    {
        if (panelInicio != null) panelInicio.SetActive(true);
        if (panelInstrucciones != null) panelInstrucciones.SetActive(false);
    }

    public void SalirJuego()
    {
        Application.Quit();
    }
}