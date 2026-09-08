using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move o objeto para frente a uma velocidade constante.
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
