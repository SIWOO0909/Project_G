using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToSampleScene : MonoBehaviour
{
    // 버튼 클릭 시 호출되는 메서드
    public void ReturnToSampleScenes()
    {
        // SampleScene으로 씬을 전환
        SceneManager.LoadScene("SampleScene");
    }
}
