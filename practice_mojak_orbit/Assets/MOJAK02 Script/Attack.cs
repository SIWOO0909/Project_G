using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public float cooltime = 5f;
    public Collider hit;
    public Text text;
    public GameObject targetObject; // 활성화/비활성화할 게임 오브젝트
    bool isOn;
    public Button targetButton; // 비활성화할 버튼

    public void Hit()
    {
        if (!isOn)
            StartCoroutine(DelayAndStartColliderOn(0.2f)); // 지연 후 ColliderOn 실행
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
            // 게임 오브젝트의 활성화 상태를 토글합니다.
            targetObject.SetActive(!targetObject.activeSelf);

            // 만약 게임 오브젝트가 활성화되었다면, 일정 시간이 지난 후 비활성화합니다.
            if (targetObject.activeSelf)
            {
                StartCoroutine(DeactivateAfterDelay());
            }
        }
        else
        {
            Debug.LogWarning("TargetObject가 설정되지 않았습니다.");
        }
    }

    public void DisableButtonTemporarily()
    {
        if (targetButton != null)
        {
            StartCoroutine(DisableButtonForSeconds()); // 5초간 버튼 비활성화
        }
        else
        {
            Debug.LogWarning("TargetButton이 설정되지 않았습니다.");
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
        targetButton.interactable = false; // 버튼 비활성화
        yield return new WaitForSeconds(cooltime);
        targetButton.interactable = true; // 버튼 다시 활성화
    }

    private IEnumerator DeactivateAfterDelay()
    {
        yield return new WaitForSeconds(0.3f);
        targetObject.SetActive(false);
    }
}
