using UnityEngine;
using System.Collections;

public class DeactivateAfterTime : MonoBehaviour
{
    public float delayTime = 3f; // 3초 후에 비활성화할 시간

    private void OnEnable()
    {
        // 코루틴 시작
        StartCoroutine(DeactivateAfterDelay());
    }

    private IEnumerator DeactivateAfterDelay()
    {
        // 대기 시간만큼 대기
        yield return new WaitForSeconds(delayTime);

        // 현재 게임 오브젝트 비활성화
        gameObject.SetActive(false);
    }
}
