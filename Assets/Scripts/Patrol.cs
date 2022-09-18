using UnityEngine;

public class Patrol : MonoBehaviour
{
    float dirx;
    float speed = 50f;
    bool moveRight = true;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 50f)
        {
            moveRight = false;
        }
        else if (transform.position.x < -50f)
        {
            moveRight = true;
        }
        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
