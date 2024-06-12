using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gachaManager : MonoBehaviour
{
    // 뽑기 버튼
    public GameObject gachaBtn;

    // 뽑기 성공시 보여주는 이미지
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
    public GameObject HotDog; // 핫도그
    public GameObject DBLUE; // 
    public GameObject KrabRedimg; //
    public GameObject HotDogGreen; //


    // 해금
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


        // 박스 2
        if (PlayerPrefs.GetInt("BoxCharacter") == 1) // 박스캐릭터가 한번 이상 뽑힐시
        {
            BoxLocked.SetActive(false); // 박스캐릭터 잠금해제
        }
        else if (PlayerPrefs.GetInt("BoxCharacter") == 0) // 박스캐릭터가 한번도 안뽑혔다면
        {
            BoxLocked.SetActive(true); // 박스 캐릭터 잠금
        }

        // 크랩 3
        if (PlayerPrefs.GetInt("KrabCharacter") == 1) // 크랩캐릭터가 한번 이상 뽑힐시
        {
            KrabLocked.SetActive(false); // 크랩 잠금해제
        }
        else if (PlayerPrefs.GetInt("KrabCharacter") == 0) // 크랩캐릭터가 한번도 안뽑혔다면
        {
            KrabLocked.SetActive(true); // 크랩 캐릭터 잠금 
        }

        // 위글리 빨강 4
        if (PlayerPrefs.GetInt("WRC") == 1)
        {
            WRLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WRC") == 0)
        {
            WRLocked.SetActive(true);
        }

        // 위글리 주황 5 
        if (PlayerPrefs.GetInt("WOC") == 1)
        {
            WOLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WOC") == 0)
        {
            WOLocked.SetActive(true);
        }
        // 위글리 노랑 6
        if (PlayerPrefs.GetInt("WYC") == 1)
        {
            WYLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WYC") == 0)
        {
            WYLocked.SetActive(true);
        }
        // 위글리 파랑 7
        if (PlayerPrefs.GetInt("WBC") == 1)
        {
            WBLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WBC") == 0)
        {
            WBLocked.SetActive(true);
        }
        // 위글리 보라 8
        if (PlayerPrefs.GetInt("WPuC") == 1)
        {
            WPuLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WPuC") == 0)
        {
            WPuLocked.SetActive(true);
        }
        // 위글리 핑크 9 
        if (PlayerPrefs.GetInt("WPiC") == 1)
        {
            WPiLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WPiC") == 0)
        {
            WPiLocked.SetActive(true);
        }
        // 위글리 그레이10
        if (PlayerPrefs.GetInt("WGC") == 1)
        {
            WGLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WGC") == 0)
        {
            WGLocked.SetActive(true);
        }
        // 위글리 화이트 11
        if (PlayerPrefs.GetInt("WWC") == 1)
        {
            WWLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("WWC") == 0)
        {
            WWLocked.SetActive(true);
        }

        // 핫도그 12
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

        // 크랩 레드
        if (PlayerPrefs.GetInt("KrabRed") == 1)
        {
            KrabRedLocked.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("KrabRed") == 0)
        {
            KrabRedLocked.SetActive(true);
        }

        // 플랭크톤
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
        Debug.Log("뽑기 확률" + GachaResult);
        // 위글리1
        if (GachaResult >= 0 && GachaResult < w) // 0이상 9 미만 //1
        {
            Debug.Log("위글리 획득!");
            Wigley.SetActive(true);
        }
        // 박스2
        else if (GachaResult >= w && GachaResult < w + b) // 9이상 18 미만 
        {
            Debug.Log("박스 획득!");
            Box.SetActive(true); // 뽑기 결과화면에 박스가 보여집니다.
            BoxLocked.SetActive(false); // 박스 캐릭터 잠금해제
            PlayerPrefs.SetInt("BoxCharacter", 1); // 박스 캐릭터 잠금해제 된것을 기기에 저장
        }
        // 크랩3
        else if (GachaResult >= w + b && GachaResult < w + b + k) // 18이상 27 미만
        {
            Debug.Log("크랩 획득!");
            Krab.SetActive(true); // 뽑기 결과화면에 크랩이 보여집니다.
            KrabLocked.SetActive(false); // 크랩 캐릭터 잠금해제
            PlayerPrefs.SetInt("KrabCharacter", 1); // 크랩 캐릭터 잠금해제된것을 기기에 저장
        }
        // 위글리 빨강4
        else if (GachaResult >= w + b + k && GachaResult < w + b + k + wr)
        {
            WR.SetActive(true);
            WRLocked.SetActive(false);
            PlayerPrefs.SetInt("WRC", 1);
        }
        // 위글리 주황5
        else if (GachaResult >= w + b + k + wr && GachaResult < w + b + k + wr + wo)
        {
            WO.SetActive(true);
            WOLocked.SetActive(false);
            PlayerPrefs.SetInt("WOC", 1);
        }
        // 위글리 노랑6
        else if (GachaResult >= w + b + k + wr + wo && GachaResult < w + b + k + wr + wo + wy)
        {
            WY.SetActive(true);
            WYLocked.SetActive(false);
            PlayerPrefs.SetInt("WYC", 1);
        }
        // 위글리 파랑7
        else if (GachaResult >= w + b + k + wr + wo + wy && GachaResult < w + b + k + wr + wo + wy + wb)
        {
            WB.SetActive(true);
            WBLocked.SetActive(false);
            PlayerPrefs.SetInt("WBC", 1);
        }
        // 위글리 보라8
        else if (GachaResult >= w + b + k + wr + wo + wy + wb && GachaResult < w + b + k + wr + wo + wy + wb + wpu)
        {
            WPu.SetActive(true);
            WPuLocked.SetActive(false);
            PlayerPrefs.SetInt("WPuC", 1);
        }
        // 위글리 핑크9
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu && GachaResult < w + b + k + wr + wo + wy + wb + wpu + wpi)
        {
            WPi.SetActive(true);
            WPiLocked.SetActive(false);
            PlayerPrefs.SetInt("WPiC", 1);
        }
        // 위글리 그레이10
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu + wpi && GachaResult < w + b + k + wr + wo + wy + wb + wpu + wpi + wg)
        {
            WG.SetActive(true);
            WGLocked.SetActive(false);
            PlayerPrefs.SetInt("WGC", 1);
        }
        // 위글리 화이트
        else if (GachaResult >= w + b + k + wr + wo + wy + wb + wpu + wpi + wg && GachaResult < w + b + k + wr + wo + wy + wb + wpu + wpi + wg + ww)
        {
            WW.SetActive(true);
            WWLocked.SetActive(false);
            PlayerPrefs.SetInt("WWC", 1);
        }
        // 핫도그
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
        PlayerPrefs.SetInt("BoxCharacter", 0); // 박스 캐릭터 잠금
        PlayerPrefs.SetInt("KrabCharacter", 0); // 크랩 캐릭터 잠금
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