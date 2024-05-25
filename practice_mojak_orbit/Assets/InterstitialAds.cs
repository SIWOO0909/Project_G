using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterstitialAds : MonoBehaviour
{
    // 애드몹 매니저 가져오기
    public GameObject admobManager;

    // Start is called before the first frame update
    void Start()
    {
        admobManager.GetComponent<AdmobAds>().LoadInterstitalAd();
        admobManager.GetComponent<AdmobAds>().ShowInterstitialAd();
    }

}
