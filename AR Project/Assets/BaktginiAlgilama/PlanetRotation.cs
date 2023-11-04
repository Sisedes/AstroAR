using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; 
    public float rotationSpeed = 10f; 
    public bool rotateClockwise = true; 

    void Update()
    {
        float currentRotationSpeed = rotateClockwise ? rotationSpeed : -rotationSpeed;
        transform.Rotate(rotationAxis, currentRotationSpeed * Time.deltaTime);
    }
}
