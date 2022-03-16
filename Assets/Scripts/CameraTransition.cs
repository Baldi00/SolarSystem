using UnityEngine;

public class CameraTransition : MonoBehaviour
{

    public int speed;
    private bool isMoving;
    private Transform toReach;
    public float stopDistance;

    // Use this for initialization
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.Lerp(transform.position, toReach.position, Time.deltaTime * speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, toReach.rotation, Time.deltaTime * speed);
            if (HasFinishedMovement())
            {
                isMoving = false;
                enabled = false;
            }
        }
    }

    public void MoveTo(Transform toReach)
    {
        isMoving = true;
        this.toReach = toReach;
        enabled = true;
    }

    public bool HasFinishedMovement()
    {
        return Vector3.Distance(transform.position, toReach.position) < stopDistance;
    }
}
