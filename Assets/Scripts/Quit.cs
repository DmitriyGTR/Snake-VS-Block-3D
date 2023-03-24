using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void menuu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exitgame()
    {
        Application.Quit();
    }
}
