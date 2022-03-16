using UnityEngine;

public class GizmosTest : MonoBehaviour
{

    public float lookRadius = 10f;
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
