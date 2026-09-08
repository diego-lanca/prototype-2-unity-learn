using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public InputAction fireAction;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectilePrefab;
    private Vector2 moveInput;
    

    void OnEnable()
    {
        moveAction.Enable();
        fireAction.Enable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Limites da tela para o player, caso atinja o limite ele não pode mais se mover para aquele lado.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Lê o input do jogador para movimentação horizontal.
        moveInput = moveAction.ReadValue<Vector2>();
        transform.Translate(moveInput.x * speed * Time.deltaTime * Vector3.right);

        // Dispara o projétil caso o botão de disparo seja pressionado.
        if (fireAction.triggered)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
