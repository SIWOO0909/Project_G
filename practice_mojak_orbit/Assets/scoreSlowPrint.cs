using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class scoreSlowPrint : MonoBehaviour
{
    public TextMeshProUGUI gameOverTotalScoreTxt;
    public TextMeshProUGUI gameOverBestScoreTxt;

    private void Start()
    {
        // 점수 느리게 하는 시스템
        float floata = ScoreManager.a;
        floata += 1000 * Time.deltaTime * 0.8f;
        // 게임오버시 현점수 텍스트
        gameOverTotalScoreTxt.text = floata.ToString();
    }
}
