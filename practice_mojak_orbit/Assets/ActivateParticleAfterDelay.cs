using UnityEngine;
using System.Collections;

public class ActivateParticleAfterDelay : MonoBehaviour
{
    public float delayTime = 3f; // 3�� �Ŀ� ������ �ð�

    private ParticleSystem particleSystem;

    private void Start()
    {
        // ��ƼŬ �ý��� ������Ʈ�� ������
        particleSystem = GetComponent<ParticleSystem>();
        if (particleSystem == null)
        {
            Debug.LogError("ParticleSystem component not found on this GameObject.");
        }
    }

    private void OnEnable()
    {
        // �ڷ�ƾ ����
        StartCoroutine(ActivateParticleSystemAfterDelay());
    }

    private IEnumerator ActivateParticleSystemAfterDelay()
    {
        // ��� �ð���ŭ ���
        yield return new WaitForSeconds(delayTime);

        // ��ƼŬ �ý��� ���
        if (particleSystem != null)
        {
            particleSystem.Play();
        }
    }
}