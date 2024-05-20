using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public int minsu;

    public GameObject Main;
    public GameObject sub1;
    public GameObject sub2;
    void Start()
    {
        //if (minsu == null)
        //{
        //    DestroyAllCharacter();
        //    Main.SetActive(true);
        //}
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Character") == 0)
        {
            DestroyAllCharacter();
            Main.SetActive(true);
            minsu = 0;
            PlayerPrefs.SetInt("Character", 0);
        }
        else if (PlayerPrefs.GetInt("Character") == 1)
        {
            DestroyAllCharacter();
            sub1.SetActive(true);
            minsu = 1;
            PlayerPrefs.SetInt("Character", 1);
        }
        else if (PlayerPrefs.GetInt("Character") == 2)
        {
            DestroyAllCharacter();
            sub2.SetActive(true);
            minsu = 2;
            PlayerPrefs.SetInt("Character", 2);
        }
    }

    public void MainC()
    {
        minsu = 0;
        PlayerPrefs.SetInt("Character", 0);
    }
    public void SubC1()
    {
        minsu = 1;
        PlayerPrefs.SetInt("Character", 1);
    }
    public void SubC2()
    {
        minsu = 2;
        PlayerPrefs.SetInt("Character", 2);
    }

    public void DestroyAllCharacter()
    {
        Main.SetActive(false);
        sub1.SetActive(false);
        sub2.SetActive(false);
    }

}
