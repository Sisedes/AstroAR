using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target; 
    public float orbitDistance = 5.0f; 
    public float orbitDegreesPerSec = 90.0f;
    public Vector3 selfRotateSpeed = new Vector3(0f, 30f, 0f);

    void Update()
    {
        if (target != null)
        {
            OrbitAround();
            SelfRotate();
        }
    }

    void OrbitAround()
    {
        transform.RotateAround(target.position, Vector3.up, orbitDegreesPerSec * Time.deltaTime);
        Vector3 desiredPosition = (transform.position - target.position).normalized * orbitDistance + target.position;
        transform.position = desiredPosition;
    }
    void SelfRotate()
    {
        transform.Rotate(selfRotateSpeed * Time.deltaTime);
    }
}
