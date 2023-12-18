using UnityEngine;

public class Orbit : MonoBehaviour
{
    private GameObject mainSystem;
    float hehe = 1f;
    float realOrbitDistance;

    public Transform target; 
    public float orbitDistance = 5.0f; 
    public float orbitDegreesPerSec = 90.0f;
    public Vector3 selfRotateSpeed = new Vector3(0f, 30f, 0f);

    bool scaleLock=false;
    private void Start()
    {
        if (mainSystem == null)
        {
            mainSystem = GameObject.FindGameObjectWithTag("gezegenler");
            hehe=mainSystem.transform.localScale.x;
        }
        realOrbitDistance = orbitDistance;
    }

    void Update()
    {
        if (mainSystem == null)
        {
            mainSystem = GameObject.FindGameObjectWithTag("gezegenler");
        }
        else
        {
            hehe = mainSystem.transform.localScale.x;
            
        }

        if (target != null)
        {
            OrbitAround();
            SelfRotate();
        }
        
            orbitDistance = realOrbitDistance * hehe;
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
