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


        if (PlayerPrefs.GetInt("BoxCharacter") == 1) // 박스캐릭터가 한번 이상 뽑힐시
        {
            BoxLocked.SetActive(false); // 박스캐릭터 잠금해제
        }
        else if (PlayerPrefs.GetInt("BoxCharacter") == 0) // 박스캐릭터가 한번도 안뽑혔다면
        {
            BoxLocked.SetActive(true); // 박스 캐릭터 잠금
        }

        if (PlayerPrefs.GetInt("KrabCharacter") == 1) // 크랩캐릭터가 한번 이상 뽑힐시
        {
            KrabLocked.SetActive(false); // 크랩 잠금해제
        }
        else if (PlayerPrefs.GetInt("KrabCharacter") == 0) // 크랩캐릭터가 한번도 안뽑혔다면
        {
            KrabLocked.SetActive(true); // 크랩 캐릭터 잠금 
        }
    }

    public void GachaStart()
    {
        int result = Random.Range(0, 100);
        Debug.Log(result);

        if (result >= 0 && result < 30) // 0이상 30 미만
        {
            Debug.Log("위글리 획득!");
            Wigley.SetActive(true);
        }
        else if(result >= 30 && result < 60) // 30이상 60 미만 
        {
            Debug.Log("박스 획득!");
            Box.SetActive(true); // 뽑기 결과화면에 박스가 보여집니다.
            BoxLocked.SetActive(false); // 박스 캐릭터 잠금해제
            PlayerPrefs.SetInt("BoxCharacter", 1); // 박스 캐릭터 잠금해제 된것을 기기에 저장
        }
        else if(result >=60 && result <= 100) // 60이상 100 미만
        {
            Debug.Log("크랩 획득!");
            Krab.SetActive(true); // 뽑기 결과화면에 크랩이 보여집니다.
            KrabLocked.SetActive(false); // 크랩 캐릭터 잠금해제
            PlayerPrefs.SetInt("KrabCharacter", 1); // 크랩 캐릭터 잠금해제된것을 기기에 저장
        }
    }

    // 뽑기시 보여질 이미지 다시 없애는 함수
    public void UnShowGachaPopUpImage()
    {
        Wigley.SetActive(false);
        Box.SetActive(false);
        Krab.SetActive(false);
    }

    // 소유 캐릭터 목록 초기화해주는 함수
    public void CharacterUnGetted()
    {
        PlayerPrefs.SetInt("BoxCharacter", 0); // 박스 캐릭터 잠금
        PlayerPrefs.SetInt("KrabCharacter", 0); // 크랩 캐릭터 잠금
    }
}
