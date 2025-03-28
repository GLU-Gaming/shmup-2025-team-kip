using UnityEditor.Timeline;
using UnityEngine;

public class BoomScroller : MonoBehaviour
{
    [SerializeField] float fenceSpeed = 3;
    private Rigidbody rb;
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update ()
    {
        rb.linearVelocity = transform.forward * fenceSpeed;

        if ( transform.position.x <= -108 )
        {
            transform.position = new Vector3( 116, transform.position.y, transform.position.z );
        }
    }
}