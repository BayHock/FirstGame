using UnityEngine;

public class SawMove : MonoBehaviour
{

    void FixedUpdate()
    {
        Quaternion rotationZ = Quaternion.AngleAxis(8, Vector3.forward);
        transform.rotation *= rotationZ;
    }
}
