using UnityEngine;

public class Player : MonoBehaviour
{
    private int lives;
    private int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lives = 3;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseLives()
    {
        lives--;
        if (lives <= 0)
        {
            Debug.Log("Game Over!");
            lives = 0;
        }
        else
        {
            Debug.Log("Lives: " + lives);
        }
    }

    public void IncreaseScore()
    {
        score++;
    }

    public int GetLives() { return lives; }
    public int GetScore() { return score; }
}
