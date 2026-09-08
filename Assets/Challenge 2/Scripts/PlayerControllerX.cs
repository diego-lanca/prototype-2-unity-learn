using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;

    public float spawnDelay = 1f;
    private float spawnTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime;

        // On spacebar press, send dog
        if (fireAction.triggered && spawnTime >= spawnDelay)
        {
            spawnTime = 0f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
