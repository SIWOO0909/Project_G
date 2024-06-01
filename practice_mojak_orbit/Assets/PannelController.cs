using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelController : MonoBehaviour
{
    public GameObject animatedImage; // 애니메이션이 적용된 이미지
    public GameObject nextPanel; // 5초 후에 활성화될 패널
    public float delayTime = 5f; // 대기 시간

    private void OnEnable()
    {
        // 패널이 활성화되면 코루틴 시작
        StartCoroutine(ShowNextPanelAfterDelay());
    }

    private IEnumerator ShowNextPanelAfterDelay()
    {
        // 대기 시간만큼 대기
        yield return new WaitForSeconds(delayTime);

        // 현재 패널 비활성화
        animatedImage.SetActive(false);

        // 다음 패널 활성화
        nextPanel.SetActive(true);
    }
}