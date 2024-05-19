using UnityEngine;

public class FloorCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody>() != null) Destroy(collision.gameObject);
    }
}