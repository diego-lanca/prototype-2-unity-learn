using Mono.Cecil.Cil;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {
            player.DecreaseLives();
        }
        else
        {
            // Destrói a comida e o animal quando eles colidem
            Destroy(gameObject);
            Destroy(other.gameObject);
            player.IncreaseScore();
            Debug.Log("Score: " + player.GetScore());
        }
    }
}
