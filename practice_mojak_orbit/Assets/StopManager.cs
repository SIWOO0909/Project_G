using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopManager : MonoBehaviour
{
    public GameObject stopWindow;

    public void OnclickStopBtn()
    {
        Time.timeScale = 0;
        stopWindow.SetActive(true);
    }

    public void OnClickContinBtn()
    {
        Time.timeScale = 1;
        stopWindow.SetActive(false);
    }
}
