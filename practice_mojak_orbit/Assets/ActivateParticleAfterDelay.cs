using UnityEngine;
using System.Collections;

public class ActivateParticleAfterDelay : MonoBehaviour
{
    public float delayTime = 3f; // 3초 후에 동작할 시간

    private ParticleSystem particleSystem;

    private void Start()
    {
        // 파티클 시스템 컴포넌트를 가져옴
        particleSystem = GetComponent<ParticleSystem>();
        if (particleSystem == null)
        {
            Debug.LogError("ParticleSystem component not found on this GameObject.");
        }
    }

    private void OnEnable()
    {
        // 코루틴 시작
        StartCoroutine(ActivateParticleSystemAfterDelay());
    }

    private IEnumerator ActivateParticleSystemAfterDelay()
    {
        // 대기 시간만큼 대기
        yield return new WaitForSeconds(delayTime);

        // 파티클 시스템 재생
        if (particleSystem != null)
        {
            particleSystem.Play();
        }
    }
}