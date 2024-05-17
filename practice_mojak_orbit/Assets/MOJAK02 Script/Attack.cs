using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public float cooltime = 5f;
    public Collider hit;
    public Text text;
    public GameObject targetObject; // Ȱ��ȭ/��Ȱ��ȭ�� ���� ������Ʈ
    bool isOn;
    public Button targetButton; // ��Ȱ��ȭ�� ��ư

    public void Hit()
    {
        if (!isOn)
            StartCoroutine(DelayAndStartColliderOn(0.2f)); // ���� �� ColliderOn ����
    }

    private IEnumerator DelayAndStartColliderOn(float delay)
    {
        yield return new WaitForSeconds(delay);
        StartCoroutine(ColliderOn());
    }

    IEnumerator ColliderOn()
    {
        hit.enabled = true;
        yield return new WaitForSeconds(0.1f);
        hit.enabled = false;
    }


    public void ToggleActiveState()
    {
        if (targetObject != null)
        {
            // ���� ������Ʈ�� Ȱ��ȭ ���¸� ����մϴ�.
            targetObject.SetActive(!targetObject.activeSelf);

            // ���� ���� ������Ʈ�� Ȱ��ȭ�Ǿ��ٸ�, ���� �ð��� ���� �� ��Ȱ��ȭ�մϴ�.
            if (targetObject.activeSelf)
            {
                StartCoroutine(DeactivateAfterDelay());
            }
        }
        else
        {
            Debug.LogWarning("TargetObject�� �������� �ʾҽ��ϴ�.");
        }
    }

    public void DisableButtonTemporarily()
    {
        if (targetButton != null)
        {
            StartCoroutine(DisableButtonForSeconds()); // 5�ʰ� ��ư ��Ȱ��ȭ
        }
        else
        {
            Debug.LogWarning("TargetButton�� �������� �ʾҽ��ϴ�.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
           Hit();
        }
    }

    private IEnumerator DisableButtonForSeconds()
    {
        targetButton.interactable = false; // ��ư ��Ȱ��ȭ
        yield return new WaitForSeconds(cooltime);
        targetButton.interactable = true; // ��ư �ٽ� Ȱ��ȭ
    }

    private IEnumerator DeactivateAfterDelay()
    {
        yield return new WaitForSeconds(0.3f);
        targetObject.SetActive(false);
    }
}
