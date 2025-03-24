using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;

public class SceneSys : MonoBehaviour
{
    public void GoToGame ()
    {
        SceneManager.LoadScene( "MainScene" );
    }
}
