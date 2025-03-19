using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody  rb;
    private float verticalSpeed = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        verticalSpeed = Input.GetAxisRaw("Vertical");
        rb.AddRelativeForce(new Vector3(0, verticalSpeed, 0 ));
    }
}
