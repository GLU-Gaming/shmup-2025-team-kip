using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] float HealthSize = 1.9f;
    void Start ()
    {
        transform.localScale = new Vector3( HealthSize, transform.localScale.y, transform.localScale.z );
    }

    void Update ()
    {
       
    }

    public void PlayerDamage ()
    {
        HealthSize = HealthSize - 1.9f;
    }
}
