using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadyScene : MonoBehaviour
{
    float NextScene = 0;
    void Start()
    {
        
    }

   
    void Update()
    {
        NextScene += Time.deltaTime;

        if(NextScene > 3)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
