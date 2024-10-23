using UnityEngine;

public class Scoring : MonoBehaviour
{
    // Two seperate scoring integers
    int playerOneScore = 1;
    int playerTwoScore = 1;

    int scoreAdd = 1;

    // Ball game object reference
    public GameObject Ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 8.7f)
            {
                Debug.Log("Player 1 Score: " + playerOneScore);
                playerOneScore = playerOneScore + scoreAdd;
            }

        if (transform.position.x < -8.7f)
        {
            Debug.Log("Player 2 Score: " + playerTwoScore);
            playerTwoScore = playerTwoScore + scoreAdd;
        }
    }
}
