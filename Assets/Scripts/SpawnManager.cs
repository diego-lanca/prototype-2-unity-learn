using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    private readonly float spawnRangeX = 20.0f;
    private readonly float spawnPosZ = 20.0f;

    private readonly float spawnDelay = 2.0f;
    private readonly float spawnInterval = 1.5f;

    void OnEnable()
    {
        spawnAction.Enable();   
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Inicia a repetição do método SpawnRandomAnimal após um atraso inicial e com um intervalo definido.
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnAction.triggered)
        {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        // Gera um animal aleatório a partir do array de prefabs e o instancia em uma posição aleatória dentro do intervalo definido.
        var animal = animalPrefabs[Random.Range(0, animalPrefabs.Length)];
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX + 1), 0, spawnPosZ);

        Instantiate(animal, spawnPos, animal.transform.rotation);
    }
}
