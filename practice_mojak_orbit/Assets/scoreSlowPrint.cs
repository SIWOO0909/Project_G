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
        // ���� ������ �ϴ� �ý���
        float floata = ScoreManager.a;
        floata += 1000 * Time.deltaTime * 0.8f;
        // ���ӿ����� ������ �ؽ�Ʈ
        gameOverTotalScoreTxt.text = floata.ToString();
    }
}
