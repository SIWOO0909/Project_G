using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelController : MonoBehaviour
{
    public GameObject animatedImage; // �ִϸ��̼��� ����� �̹���
    public GameObject nextPanel; // 5�� �Ŀ� Ȱ��ȭ�� �г�
    public float delayTime = 5f; // ��� �ð�

    private void OnEnable()
    {
        // �г��� Ȱ��ȭ�Ǹ� �ڷ�ƾ ����
        StartCoroutine(ShowNextPanelAfterDelay());
    }

    private IEnumerator ShowNextPanelAfterDelay()
    {
        // ��� �ð���ŭ ���
        yield return new WaitForSeconds(delayTime);

        // ���� �г� ��Ȱ��ȭ
        animatedImage.SetActive(false);

        // ���� �г� Ȱ��ȭ
        nextPanel.SetActive(true);
    }
}