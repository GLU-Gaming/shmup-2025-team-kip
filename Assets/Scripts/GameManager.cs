using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject bgPlane_1; // zodat je de een en ander kan respawnen aan de linker kant
    [SerializeField] GameObject bgPlane_2;
    [SerializeField] GameObject bgPlane_3;
    void Start ()
    {
        bgPlane_1.transform.rotation = Quaternion.Euler( 90, -180, 0 );
        bgPlane_2.transform.rotation = Quaternion.Euler( 90, -180, 0 );
    }


    void Update ()
    {

        if ( bgPlane_1.transform.position == new Vector3( -209, 0, 102 ) )
        {
            Instantiate( bgPlane_2, new Vector3( -209, 0, 102 ), Quaternion.identity );
            Destroy( bgPlane_1 );
        }

        if ( bgPlane_2.transform.position == new Vector3( 0, 0, 102 ) )
        {
            Instantiate( bgPlane_3, new Vector3( 209, 0, 102 ), Quaternion.identity );
            
        }

    }
}