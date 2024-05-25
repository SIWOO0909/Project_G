using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gachaManager : MonoBehaviour
{
    //public int wigleyStart;
    //public int wigleyEnd;

    public GameObject gachaBtn;

    public GameObject Wigley;
    public GameObject Box;
    public GameObject Krab;

    // public GameObject WigleyLocked;
    public GameObject BoxLocked;
    public GameObject KrabLocked;





    private void Update()
    {
        if (PlayerPrefs.GetInt("totalCoins") < 2000)
        {
            gachaBtn.SetActive(false);
        }
        else
        {
            gachaBtn.SetActive(true);
        }


        if (PlayerPrefs.GetInt("BoxCharacter") == 1) // �ڽ�ĳ���Ͱ� �ѹ� �̻� ������
        {
            BoxLocked.SetActive(false); // �ڽ�ĳ���� �������
        }
        else if (PlayerPrefs.GetInt("BoxCharacter") == 0) // �ڽ�ĳ���Ͱ� �ѹ��� �Ȼ����ٸ�
        {
            BoxLocked.SetActive(true); // �ڽ� ĳ���� ���
        }

        if (PlayerPrefs.GetInt("KrabCharacter") == 1) // ũ��ĳ���Ͱ� �ѹ� �̻� ������
        {
            KrabLocked.SetActive(false); // ũ�� �������
        }
        else if (PlayerPrefs.GetInt("KrabCharacter") == 0) // ũ��ĳ���Ͱ� �ѹ��� �Ȼ����ٸ�
        {
            KrabLocked.SetActive(true); // ũ�� ĳ���� ��� 
        }
    }

    public void GachaStart()
    {
        int result = Random.Range(0, 100);
        Debug.Log(result);

        if (result >= 0 && result < 30) // 0�̻� 30 �̸�
        {
            Debug.Log("���۸� ȹ��!");
            Wigley.SetActive(true);
        }
        else if(result >= 30 && result < 60) // 30�̻� 60 �̸� 
        {
            Debug.Log("�ڽ� ȹ��!");
            Box.SetActive(true); // �̱� ���ȭ�鿡 �ڽ��� �������ϴ�.
            BoxLocked.SetActive(false); // �ڽ� ĳ���� �������
            PlayerPrefs.SetInt("BoxCharacter", 1); // �ڽ� ĳ���� ������� �Ȱ��� ��⿡ ����
        }
        else if(result >=60 && result <= 100) // 60�̻� 100 �̸�
        {
            Debug.Log("ũ�� ȹ��!");
            Krab.SetActive(true); // �̱� ���ȭ�鿡 ũ���� �������ϴ�.
            KrabLocked.SetActive(false); // ũ�� ĳ���� �������
            PlayerPrefs.SetInt("KrabCharacter", 1); // ũ�� ĳ���� ��������Ȱ��� ��⿡ ����
        }
    }

    // �̱�� ������ �̹��� �ٽ� ���ִ� �Լ�
    public void UnShowGachaPopUpImage()
    {
        Wigley.SetActive(false);
        Box.SetActive(false);
        Krab.SetActive(false);
    }

    // ���� ĳ���� ��� �ʱ�ȭ���ִ� �Լ�
    public void CharacterUnGetted()
    {
        PlayerPrefs.SetInt("BoxCharacter", 0); // �ڽ� ĳ���� ���
        PlayerPrefs.SetInt("KrabCharacter", 0); // ũ�� ĳ���� ���
    }
}
