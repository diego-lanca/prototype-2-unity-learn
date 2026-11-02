using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private readonly float topBound = 30.0f;
    private readonly float bottomBound = -10.0f;
    private readonly float sidesBound = 35.0f;
    private Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        // Checa se o objeto saiu da tela e o destrói. Caso seja um animal passando pelo player, termina o jogo.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            player.DecreaseLives();
            Destroy(gameObject);
        }
        else if (transform.position.x > sidesBound || transform.position.x < -sidesBound)
        {
            player.DecreaseLives();
            Destroy(gameObject);
        }
    }
}
