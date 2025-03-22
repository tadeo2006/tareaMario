using UnityEngine;
using UnityEngine.InputSystem;

public class MueveAccionPersonaje : MonoBehaviour
{

    public float velocidadX;

    [SerializeField]   // Permite al editor de Unity acceder a la var
    private float velocidadY;

    // Necesito que el personaje se mueva
    private Rigidbody2D rb;

    // InputAction
    [SerializeField]
    private InputAction leftAction; // Tecla izquierda

    // Movimiento en las 4 direcciones
    [SerializeField]
    private InputAction moveAction;

    private const float SPEED = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leftAction.Enable();
        moveAction.Enable();
        // Inicializar rb
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = moveAction.ReadValue<Vector2>();
        transform.position = (Vector2)transform.position + SPEED * Time.deltaTime * move;
    }
}
