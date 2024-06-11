using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    #region ����
    // ĳ���� ���ӿ�����Ʈ ��������
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

    // �μ� ����
    public int minsu;
    #endregion

    #region  �� ������ ���� ��⿡ ����� ĳ���� ��ȣ��� ĳ���� �ҷ�����
    private void Update()
    {
        // ���� ĳ���� ��ȣ�� 0���̸� ����(���۸�) ĳ���Ͱ� ���ɴϴ�.
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

    #region ĳ���� ���� �Լ�
    // ���۸� ĳ����
    public void MainC()
    {
        minsu = 0;
        PlayerPrefs.SetInt("Character", 0);
    }

    // �ڽ� ĳ���� 1
    public void SubC1()
    {
        minsu = 1;
        PlayerPrefs.SetInt("Character", 1);
    }

    // ũ�� ĳ���� 2
    public void SubC2()
    {
        minsu = 2;
        PlayerPrefs.SetInt("Character", 2);
    }

    // ���� ĳ���� 3
    public void WRC()
    {
        minsu = 3;
        PlayerPrefs.SetInt("Character", 3);
    }

    // ��Ȳ ĳ���� 4
    public void WOC()
    {
        minsu = 4;
        PlayerPrefs.SetInt("Character", 4);
    }
    // ��� ĳ���� 5
    public void WYC()
    {
        minsu = 5;
        PlayerPrefs.SetInt("Character", 5);
    }
    // �Ķ� ĳ���� 6
    public void WBC()
    {
        minsu = 6;
        PlayerPrefs.SetInt("Character", 6);
    }
    // ���� ĳ���� 7
    public void WPuC()
    {
        minsu = 7;
        PlayerPrefs.SetInt("Character", 7);
    }
    // ��ũ ĳ���� 8
    public void WPiC()
    {
        minsu = 8;
        PlayerPrefs.SetInt("Character", 8);
    }
    // �׷��� ĳ���� 9
    public void WGC()
    {
        minsu = 9;
        PlayerPrefs.SetInt("Character", 9);
    }
    // ȭ��Ʈ ĳ���� 10
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

    #region ��� ĳ���� �Ⱥ��̰��ϴ� �Լ�
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

    #region ���������� ���۸� ĳ���ͷ� �����ϰ� �ϴ� �Լ�
    public void WigleyHaJiMaru()
    {
        // ���۸��� ���� ����ǰ� ��⿡ ����
        PlayerPrefs.SetInt("Character", 0);
    }
    #endregion
}
