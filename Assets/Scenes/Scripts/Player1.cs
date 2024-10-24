using UnityEngine;

public class Player1 : MonoBehaviour
{
    BoxCollider2D collider;
    public float BallxMax;
    public float BallxMin;
    public float BallyMax;
    public float BallyMin;

    Vector2 directionX = Vector2.right;
    Vector2 directionY = Vector2.up;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }


        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }

        float dt = Time.deltaTime;
        float speed = 8.0f;
        Vector3 change = direction * speed * dt;
        transform.position = transform.position + change;

        float x = transform.position.x;
        float y = transform.position.y;
        float hw = collider.size.x * transform.localScale.x * 0.5f;
        float hh = collider.size.y * transform.localScale.y * 0.5f;

        float xMin1 = x - hw;
        float xMax1 = x + hw;
        float yMin1 = y - hh;
        float yMax1 = y + hh;
        
        if (BallxMin >= xMin1 && BallxMax <= xMax1 && BallyMin >= yMin1 && BallyMax <= yMax1)
        {
            directionX = -directionX;
        }
    }
}
