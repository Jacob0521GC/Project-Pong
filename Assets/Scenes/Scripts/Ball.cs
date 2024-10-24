using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector2 directionX = Vector2.right;
    Vector2 directionY = Vector2.up;
    float speed = 3.0f;

    BoxCollider2D collider;

    void Start()
    {
      collider = GetComponent<BoxCollider2D>();
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

        //

        float x = transform.position.x;
        float y = transform.position.y;
        float hw = collider.size.x * transform.localScale.x * 0.5f;
        float hh = collider.size.y * transform.localScale.y * 0.5f;

        float BallxMin = x - hw;
        float BallxMax = x + hw;
        float BallyMin = y - hh;
        float BallyMax = y + hh;


    }
}
