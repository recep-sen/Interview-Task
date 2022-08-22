using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 3f;

    private Vector2 movementVector = Vector2.zero;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = movementVector * movementSpeed;
    }
    public void GetMovementInput(CallbackContext context)
    {
        movementVector = context.ReadValue<Vector2>();
    }

    public void Interact(CallbackContext context)
    {
        if (context.performed)
        {
            //interact
        }
    }
}