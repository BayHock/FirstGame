using UnityEngine;

public class DeathLine : MonoBehaviour
{
    public Vector2 direction;

    void FixedUpdate()
    {
        transform.Translate(direction);
    }
}
