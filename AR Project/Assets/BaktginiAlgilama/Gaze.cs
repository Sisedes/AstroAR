using UnityEngine;

public class Gaze : MonoBehaviour
{
    void Update()
    {
        Vector3 targetPosition = new Vector3(Camera.main.transform.position.x,
                                             transform.position.y,
                                             Camera.main.transform.position.z);
        transform.LookAt(targetPosition);
    }


}
