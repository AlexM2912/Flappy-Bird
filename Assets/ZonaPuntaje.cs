using UnityEngine;

public class ZonaPuntaje : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Algo entró al trigger: " + collision.name);

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Entró el jugador");
            ControlJuego.instancia.SumarPunto();
        }
    }
}