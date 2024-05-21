using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public int minsu;

    public GameObject Main;
    public GameObject sub1;
    public GameObject sub2;

    private void Update()
    {
        // 만약 캐릭터 번호가 0번이면 메인(위글리) 캐릭터가 나옵니다.
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

    // 위글리 캐릭터
    public void MainC()
    {
        minsu = 0;
        PlayerPrefs.SetInt("Character", 0);
    }

    // 박스 캐릭터
    public void SubC1()
    {
        minsu = 1;
        PlayerPrefs.SetInt("Character", 1);
    }

    // 크랩 캐릭터
    public void SubC2()
    {
        minsu = 2;
        PlayerPrefs.SetInt("Character", 2);
    }

    // 모든 캐릭터 안보이게하는 함수
    public void DestroyAllCharacter()
    {
        Main.SetActive(false);
        sub1.SetActive(false);
        sub2.SetActive(false);
    }

    // 강제적으로 위글리 캐릭터로 시작하게 하는 함수
    public void WigleyHaJiMaru()
    {
        // 위글리로 강제 적용되게 기기에 저장
        PlayerPrefs.SetInt("Character", 0);
    }
}
