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
    }

    // ���۸� ĳ����
    public void MainC()
    {
        minsu = 0;
        PlayerPrefs.SetInt("Character", 0);
    }

    // �ڽ� ĳ����
    public void SubC1()
    {
        minsu = 1;
        PlayerPrefs.SetInt("Character", 1);
    }

    // ũ�� ĳ����
    public void SubC2()
    {
        minsu = 2;
        PlayerPrefs.SetInt("Character", 2);
    }

    // ��� ĳ���� �Ⱥ��̰��ϴ� �Լ�
    public void DestroyAllCharacter()
    {
        Main.SetActive(false);
        sub1.SetActive(false);
        sub2.SetActive(false);
    }

    // ���������� ���۸� ĳ���ͷ� �����ϰ� �ϴ� �Լ�
    public void WigleyHaJiMaru()
    {
        // ���۸��� ���� ����ǰ� ��⿡ ����
        PlayerPrefs.SetInt("Character", 0);
    }
}
