using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterstitialAds : MonoBehaviour
{
    // �ֵ�� �Ŵ��� ��������
    public GameObject admobManager;

    // Start is called before the first frame update
    void Start()
    {
        admobManager.GetComponent<AdmobAds>().LoadInterstitalAd();
        admobManager.GetComponent<AdmobAds>().ShowInterstitialAd();
    }

}
