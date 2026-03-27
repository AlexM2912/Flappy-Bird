using UnityEngine;

public class MovimientoObstaculo : MonoBehaviour
{
    public float velocidad = 2f;

    void Update()
    {
        if (ControlJuego.instancia != null && ControlJuego.instancia.juegoPausado) return;
        if (ControlJuego.instancia != null && ControlJuego.instancia.juegoTerminado) return;

        transform.Translate(Vector2.left * velocidad * Time.deltaTime);

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}