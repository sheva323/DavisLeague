using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadProfileScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadA0Scene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadA1Scene()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadA2Scene()
    {
        SceneManager.LoadScene(3);
    }
}
