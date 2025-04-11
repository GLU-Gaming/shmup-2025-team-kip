using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthBar : MonoBehaviour
{
    [SerializeField] public float HealthSize = 1.9f;

    GameManager game;

    void Start ()
    {
        game = FindFirstObjectByType<GameManager>();
    }

    void Update ()
    {
        transform.localScale = new Vector3( HealthSize, transform.localScale.y, transform.localScale.z );

        if ( HealthSize <= 0 )
        {
            SceneManager.LoadScene("GameOver");
        }

    }

    public void PlayerDamage ()
    {
        HealthSize = HealthSize - 0.19f;
    }

}
