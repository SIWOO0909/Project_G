using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    int x = 0;
    //private void Update()
    //{
    //    if (x == 0)
    //    {
    //        TimeStop();
    //    }
    //    //else
    //    //{
    //    //    TimeStart();
    //    //}
    //}

    private void Start()
    {
        TimeStop();
    }
    public void TimeStop()
    {
        Time.timeScale = 0;
        Debug.Log("���� ���Ӽ����� ������ �ֽ��ϴ�.");
    }

    public void TimeStart()
    {
        Time.timeScale = 1;
        Debug.Log("���� ����");
        x += 1;
    }
}
