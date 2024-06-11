using UnityEngine;
using System.Collections;

public class DeactivateAfterTime : MonoBehaviour
{
    public float delayTime = 3f; // 3�� �Ŀ� ��Ȱ��ȭ�� �ð�

    private void OnEnable()
    {
        // �ڷ�ƾ ����
        StartCoroutine(DeactivateAfterDelay());
    }

    private IEnumerator DeactivateAfterDelay()
    {
        // ��� �ð���ŭ ���
        yield return new WaitForSeconds(delayTime);

        // ���� ���� ������Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}
