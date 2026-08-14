using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    private readonly float spawnRangeX = 20.0f;
    private readonly float spawnPosZ = 20.0f;

    void OnEnable()
    {
        spawnAction.Enable();   
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnAction.triggered)
        {
            var animalIndex = Random.Range(0, animalPrefabs.Length);
            var animal = animalPrefabs[animalIndex];
            var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX + 1), 0, spawnPosZ);

            Instantiate(animal, spawnPos, animal.transform.rotation);
        }
    }
}
