using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gachaManager : MonoBehaviour
{
    // �̱� ��ư
    public GameObject gachaBtn;

    // �̱� ������ �����ִ� �̹���
    public GameObject Wigley;
    public GameObject Box;
    public GameObject Krab;
    public GameObject WR;
    public GameObject WO;
    public GameObject WY;
    public GameObject WB;
    public GameObject WPu;
    public GameObject WPi;
    public GameObject WG;
    public GameObject WW;
    public GameObject HotDog; // �ֵ���
    public GameObject DBLUE; // 
    public GameObject KrabRedimg; //
    public GameObject HotDogGreen; //


    // �ر�
    public GameObject BoxLocked;
    public GameObject KrabLocked;
    public GameObject WRLocked;
    public GameObject WOLocked;
    public GameObject WYLocked;
    public GameObject WBLocked;
    public GameObject WPuLocked;
    public GameObject WPiLocked;
    public GameObject WGLocked;
    public GameObject WWLocked;
    public GameObject HDLocked;
    public GameObject DBlueLocked;
    public GameObject KrabRedLocked;
    public GameObject HotDogGreenLocked;

    public static float w;
    public static float b;
    public static float k;
    public static float wr;
    public static float wo;
    public static float wy;
    public static float wb;
    public static float wpu;
    public static float wpi;
    public static float wg;
    public static float ww;
    public static float hotDog;
    public static float Dblue;
    public static float KrabRed;
    public static float hotDogGreen;


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


        // �ڽ� 2
        if (PlayerPrefs.GetInt("BoxCharacter") == 1) // �ڽ�ĳ���Ͱ� �ѹ� �̻� ������
        {
            BoxLocked.SetActive(false); // �ڽ�ĳ���� �������
        }
        else if (PlayerPrefs.GetInt("BoxCharacter") == 0) // �ڽ�ĳ���Ͱ� �ѹ��� �Ȼ����ٸ�
        {
            BoxLocked.SetActive(true); // �ڽ� ĳ���� ���
        }

        // ũ�� 3
        if (PlayerPrefs.GetInt("KrabCharacter") == 1) // ũ��ĳ���Ͱ� �ѹ� �̻� ������
        {
            KrabLocked.SetActive(false); // ũ�� �������
        }
        else if (PlayerPrefs.GetInt("KrabCharacter") == 0) // ũ��ĳ���Ͱ� �ѹ��� �Ȼ����ٸ�
        {
            KrabLocked.SetActive(true); // ũ�� ĳ���� ��� 
        }

        // ���۸� ���� 4
        if (PlayerPrefs.GetInt("WRC") == 1)
        {
            WRLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WRC") == 0)
        {
            WRLocked.SetActive(true);
        }

        // ���۸� ��Ȳ 5 
        if (PlayerPrefs.GetInt("WOC") == 1)
        {
            WOLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WOC") == 0)
        {
            WOLocked.SetActive(true);
        }
        // ���۸� ��� 6
        if (PlayerPrefs.GetInt("WYC") == 1)
        {
            WYLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WYC") == 0)
        {
            WYLocked.SetActive(true);
        }
        // ���۸� �Ķ� 7
        if (PlayerPrefs.GetInt("WBC") == 1)
        {
            WBLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WBC") == 0)
        {
            WBLocked.SetActive(true);
        }
        // ���۸� ���� 8
        if (PlayerPrefs.GetInt("WPuC") == 1)
        {
            WPuLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WPuC") == 0)
        {
            WPuLocked.SetActive(true);
        }
        // ���۸� ��ũ 9 
        if (PlayerPrefs.GetInt("WPiC") == 1)
        {
            WPiLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WPiC") == 0)
        {
            WPiLocked.SetActive(true);
        }
        // ���۸� �׷���10
        if (PlayerPrefs.GetInt("WGC") == 1)
        {
            WGLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WGC") == 0)
        {
            WGLocked.SetActive(true);
        }
        // ���۸� ȭ��Ʈ 11
        if (PlayerPrefs.GetInt("WWC") == 1)
        {
            WWLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WWC") == 0)
        {
            WWLocked.SetActive(true);
        }

        // �ֵ��� 12
        if (PlayerPrefs.GetInt("HD") == 1)
        {
            HDLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("HD") == 0)
        {
            HDLocked.SetActive(true);
        }
        // DBLUE
        if (PlayerPrefs.GetInt("DBlue") == 1)
        {
            DBlueLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("DBlue") == 0)
        {
            DBlueLocked.SetActive(true);
        }

        // ũ�� ����
        if (PlayerPrefs.GetInt("KrabRed") == 1)
        {
            KrabRedLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("KrabRed") == 0)
        {
            KrabRedLocked.SetActive(true);
        }

        // �÷�ũ��
        if (PlayerPrefs.GetInt("Plankton") == 1)
        {
            HotDogGreenLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Plankton") == 0)
        {
            HotDogGreenLocked.SetActive(true);
        }
    }


    public void GachaStart()
    {
        float hap = w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww + hotDog + Dblue + KrabRed + hotDogGreen;
        float GachaResult = Random.Range(0, hap);
        Debug.Log("�̱� Ȯ��" + GachaResult);
        // ���۸�1
        if (GachaResult >= 0 && GachaResult < w) // 0�̻� 9 �̸� //1
        {
            Debug.Log("���۸� ȹ��!");
            Wigley.SetActive(true);
        }
        // �ڽ�2
        else if (GachaResult >= w && GachaResult < w + b) // 9�̻� 18 �̸� 
        {
            Debug.Log("�ڽ� ȹ��!");
            Box.SetActive(true); // �̱� ���ȭ�鿡 �ڽ��� �������ϴ�.
            BoxLocked.SetActive(false); // �ڽ� ĳ���� �������
            PlayerPrefs.SetInt("BoxCharacter", 1); // �ڽ� ĳ���� ������� �Ȱ��� ��⿡ ����
        }
        // ũ��3
        else if (GachaResult >= w + b && GachaResult < w + b + k) // 18�̻� 27 �̸�
        {
            Debug.Log("ũ�� ȹ��!");
            Krab.SetActive(true); // �̱� ���ȭ�鿡 ũ���� �������ϴ�.
            KrabLocked.SetActive(false); // ũ�� ĳ���� �������
            PlayerPrefs.SetInt("KrabCharacter", 1); // ũ�� ĳ���� ��������Ȱ��� ��⿡ ����
        }
        // ���۸� ����4
        else if (GachaResult >= w + b + k && GachaResult < w + b + k + wr)
        {
            WR.SetActive(true);
            WRLocked.SetActive(false);
            PlayerPrefs.SetInt("WRC", 1);
        }
        // ���۸� ��Ȳ5
        else if (GachaResult >= w + b + k + wr && GachaResult < w + b + k + wr + wo)
        {
            WO.SetActive(true);
            WOLocked.SetActive(false);
            PlayerPrefs.SetInt("WOC", 1);
        }
        // ���۸� ���6
        else if (GachaResult >= w + b + k + wr + wo && GachaResult < w + b + k + wr + wo + wy)
        {
            WY.SetActive(true);
            WYLocked.SetActive(false);
            PlayerPrefs.SetInt("WYC", 1);
        }
        // ���۸� �Ķ�7
        else if (GachaResult >= w + b + k + wr + wo + wy && GachaResult < w + b + k + wr + wo + wy + wb)
        {
            WB.SetActive(true);
            WBLocked.SetActive(false);
            PlayerPrefs.SetInt("WBC", 1);
        }
        // ���۸� ����8
        else if (GachaResult >= w + b + k + wr + wo + wy + wb && GachaResult < w + b + k + wr + wo + wy + wb + wpu)
        {
            WPu.SetActive(true);
            WPuLocked.SetActive(false);
            PlayerPrefs.SetInt("WPuC", 1);
        }
        // ���۸� ��ũ9
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu && GachaResult < w + b + k + wr + wo + wy + wb + wpu + wpi)
        {
            WPi.SetActive(true);
            WPiLocked.SetActive(false);
            PlayerPrefs.SetInt("WPiC", 1);
        }
        // ���۸� �׷���10
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu + wpi && GachaResult < w + b + k + wr + wo + wy + wb + wpu + wpi + wg)
        {
            WG.SetActive(true);
            WGLocked.SetActive(false);
            PlayerPrefs.SetInt("WGC", 1);
        }
        // ���۸� ȭ��Ʈ
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu + wpi + wg && GachaResult < w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww)
        {
            WW.SetActive(true);
            WWLocked.SetActive(false);
            PlayerPrefs.SetInt("WWC", 1);
        }
        // �ֵ���
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww && GachaResult < w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww + hotDog) 
        {
            HotDog.SetActive(true);
            HDLocked.SetActive(false);
            PlayerPrefs.SetInt("HD", 1);
        }
        // D blue
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww + hotDog && GachaResult < w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww + hotDog + Dblue)
        {
            DBLUE.SetActive(true);
            DBlueLocked.SetActive(false);
            PlayerPrefs.SetInt("DBlue", 1);
        }
        // Krab Red
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww + hotDog + Dblue && GachaResult < w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww + hotDog + Dblue + KrabRed)
        {
            KrabRedimg.SetActive(true);
            KrabRedLocked.SetActive(false);
            PlayerPrefs.SetInt("KrabRed", 1);
        }
        // plankton
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww + hotDog + Dblue + KrabRed && GachaResult < hap)
        {
            HotDogGreen.SetActive(true);
            HotDogGreenLocked.SetActive(false);
            PlayerPrefs.SetInt("Plankton", 1);
        }
    }

    public void UnShowGachaPopUpImage()
    {
        //Wigley.SetActive(false);
        Box.SetActive(false);
        Krab.SetActive(false);
        WR.SetActive(false);
        WO.SetActive(false);
        WY.SetActive(false);
        WB.SetActive(false);
        WPu.SetActive(false);
        WPi.SetActive(false);
        WG.SetActive(false);
        WW.SetActive(false);
        HotDog.SetActive(false);
        DBLUE.SetActive(false);
        KrabRedimg.SetActive(false);
        HotDogGreen.SetActive(false);
    }

    public void AllCharacterGetto()
    {
        PlayerPrefs.SetInt("BoxCharacter", 1);
        PlayerPrefs.SetInt("KrabCharacter", 1);
        PlayerPrefs.SetInt("WRC", 1);
        PlayerPrefs.SetInt("WYC", 1);
        PlayerPrefs.SetInt("WOC", 1);
        PlayerPrefs.SetInt("WBC", 1);
        PlayerPrefs.SetInt("WPuC", 1);
        PlayerPrefs.SetInt("WPiC", 1);
        PlayerPrefs.SetInt("WGC", 1);
        PlayerPrefs.SetInt("WWC", 1);
        PlayerPrefs.SetInt("HD", 1);
        PlayerPrefs.SetInt("DBlue", 1);
        PlayerPrefs.SetInt("KrabRed", 1);
        PlayerPrefs.SetInt("Plankton", 1);
    }

    public void CharacterUnGetted()
    {
        PlayerPrefs.SetInt("BoxCharacter", 0); // �ڽ� ĳ���� ���
        PlayerPrefs.SetInt("KrabCharacter", 0); // ũ�� ĳ���� ���
        PlayerPrefs.SetInt("WRC", 0);
        PlayerPrefs.SetInt("WYC", 0);
        PlayerPrefs.SetInt("WOC", 0);
        PlayerPrefs.SetInt("WBC", 0);
        PlayerPrefs.SetInt("WPuC", 0);
        PlayerPrefs.SetInt("WPiC", 0);
        PlayerPrefs.SetInt("WGC", 0);
        PlayerPrefs.SetInt("WWC", 0);
        PlayerPrefs.SetInt("HD", 0);
        PlayerPrefs.SetInt("DBlue", 0);
        PlayerPrefs.SetInt("KrabRed", 0);
        PlayerPrefs.SetInt("Plankton", 0);
    }
}