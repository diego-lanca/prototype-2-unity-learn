using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    private Vector2 moveInput;
    

    void OnEnable()
    {
        moveAction.Enable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        moveInput = moveAction.ReadValue<Vector2>();
        transform.Translate(moveInput.x * speed * Time.deltaTime * Vector3.right);
    }
}
