using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    public void Skin()
    {
        SceneManager.LoadScene("Skin");
    }
    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}



