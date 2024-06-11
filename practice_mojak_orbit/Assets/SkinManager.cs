using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    #region 선언
    // 캐릭터 게임오브젝트 가져오기
    public GameObject Main;
    public GameObject sub1;
    public GameObject sub2;
    public GameObject WR;
    public GameObject WO;
    public GameObject WY;
    public GameObject WB;
    public GameObject WPu;
    public GameObject WPi;
    public GameObject WG;
    public GameObject WW;
    public GameObject HD;

    // 민수 변수
    public int minsu;
    #endregion

    #region  매 프레임 마다 기기에 저장된 캐릭터 번호대로 캐릭터 불러오기
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
        else if (PlayerPrefs.GetInt("Character") == 3)
        {
            DestroyAllCharacter();
            WR.SetActive(true);
            minsu = 3;
            PlayerPrefs.SetInt("Character", 3);
        }
        else if (PlayerPrefs.GetInt("Character") == 4)
        {
            DestroyAllCharacter();
            WO.SetActive(true);
            minsu = 4;
            PlayerPrefs.SetInt("Character", 4);
        }
        else if (PlayerPrefs.GetInt("Character") == 5)
        {
            DestroyAllCharacter();
            WY.SetActive(true);
            minsu = 5;
            PlayerPrefs.SetInt("Character", 5);
        }
        else if (PlayerPrefs.GetInt("Character") == 6)
        {
            DestroyAllCharacter();
            WB.SetActive(true);
            minsu = 6;
            PlayerPrefs.SetInt("Character", 6);
        }
        else if (PlayerPrefs.GetInt("Character") == 7)
        {
            DestroyAllCharacter();
            WPu.SetActive(true);
            minsu = 7;
            PlayerPrefs.SetInt("Character", 7);
        }
        else if (PlayerPrefs.GetInt("Character") == 8)
        {
            DestroyAllCharacter();
            WPi.SetActive(true);
            minsu = 8;
            PlayerPrefs.SetInt("Character", 8);
        }
        else if (PlayerPrefs.GetInt("Character") == 9)
        {
            DestroyAllCharacter();
            WG.SetActive(true);
            minsu = 9;
            PlayerPrefs.SetInt("Character", 9);
        }
        else if (PlayerPrefs.GetInt("Character") == 10 )
        {
            DestroyAllCharacter();
            WW.SetActive(true);
            minsu = 10;
            PlayerPrefs.SetInt("Character", 10);
        }
        else if (PlayerPrefs.GetInt("Character") == 11)
        {
            DestroyAllCharacter();
            HD.SetActive(true);
            minsu = 11;
            PlayerPrefs.SetInt("Character", 11);
        }
    }
#endregion

    #region 캐릭터 선택 함수
    // 위글리 캐릭터
    public void MainC()
    {
        minsu = 0;
        PlayerPrefs.SetInt("Character", 0);
    }

    // 박스 캐릭터 1
    public void SubC1()
    {
        minsu = 1;
        PlayerPrefs.SetInt("Character", 1);
    }

    // 크랩 캐릭터 2
    public void SubC2()
    {
        minsu = 2;
        PlayerPrefs.SetInt("Character", 2);
    }

    // 빨강 캐릭터 3
    public void WRC()
    {
        minsu = 3;
        PlayerPrefs.SetInt("Character", 3);
    }

    // 주황 캐릭터 4
    public void WOC()
    {
        minsu = 4;
        PlayerPrefs.SetInt("Character", 4);
    }
    // 노랑 캐릭터 5
    public void WYC()
    {
        minsu = 5;
        PlayerPrefs.SetInt("Character", 5);
    }
    // 파랑 캐릭터 6
    public void WBC()
    {
        minsu = 6;
        PlayerPrefs.SetInt("Character", 6);
    }
    // 보라 캐릭터 7
    public void WPuC()
    {
        minsu = 7;
        PlayerPrefs.SetInt("Character", 7);
    }
    // 핑크 캐릭터 8
    public void WPiC()
    {
        minsu = 8;
        PlayerPrefs.SetInt("Character", 8);
    }
    // 그레이 캐릭터 9
    public void WGC()
    {
        minsu = 9;
        PlayerPrefs.SetInt("Character", 9);
    }
    // 화이트 캐릭터 10
    public void WWC()
    {
        minsu = 10;
        PlayerPrefs.SetInt("Character", 10);
    }

    public void Hdg()
    {
        minsu = 11;
        PlayerPrefs.SetInt("Character", 11);
    }

    #endregion

    #region 모든 캐릭터 안보이게하는 함수
    public void DestroyAllCharacter()
    {
        Main.SetActive(false);
        sub1.SetActive(false);
        sub2.SetActive(false);
        WR.SetActive(false);
        WO.SetActive(false);
        WY.SetActive(false);
        WB.SetActive(false);
        WPu.SetActive(false);
        WPi.SetActive(false);
        WG.SetActive(false);
        WW.SetActive(false);
        HD.SetActive(false);
    }
    #endregion

    #region 강제적으로 위글리 캐릭터로 시작하게 하는 함수
    public void WigleyHaJiMaru()
    {
        // 위글리로 강제 적용되게 기기에 저장
        PlayerPrefs.SetInt("Character", 0);
    }
    #endregion
}
