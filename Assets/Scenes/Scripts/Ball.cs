using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector2 directionX = Vector2.right;
    Vector2 directionY = Vector2.up;
    float speed = 3.0f;

    void Start()
    {
     
    }

    void Update()
    {
        float dt = Time.deltaTime;
        Vector3 changeX = directionX * speed * dt;
        Vector3 changeY = directionY * speed * dt;
        transform.position = transform.position + changeX + changeY;

        // If the ball hits the top it bounces off
        if (transform.position.y > 4.4f)
        {
            directionY = -directionY;
        }

        // If the ball hits the bottom it bounces off
        if (transform.position.y < -4.4f)
        {
            directionY = -directionY;
        }


        if (transform.position.x > 8.7f)
        {
            directionX = -directionX;
        }


        if (transform.position.x < -8.7f)
        {
            directionX = -directionX;
        }

    }
}
