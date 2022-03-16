using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotationHours = 24f;
    private float rotationSpeed;

    void Update()
    {
        rotationSpeed = 288 / rotationHours;
        transform.Rotate(new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));
        //transform.SetPositionAndRotation (gameObject.transform.position, new Quaternion(transform.rotation.x, transform.rotation.y+1, transform.rotation.z, transform.rotation.w));
    }
}