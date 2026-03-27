using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float fuerzaSalto = 5f;
    private Rigidbody2D rb;
    private bool estaVivo = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!estaVivo) return;
        if (ControlJuego.instancia != null && ControlJuego.instancia.juegoPausado) return;
        if (ControlJuego.instancia != null && ControlJuego.instancia.juegoTerminado) return;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Choqué con: " + collision.gameObject.name);

        if (!estaVivo) return;

        estaVivo = false;

        if (ControlJuego.instancia != null)
        {
            ControlJuego.instancia.GameOver();
        }
    }
}