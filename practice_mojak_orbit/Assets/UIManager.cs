using UnityEngine;

public class UIManager : MonoBehaviour
{
    public RectTransform uiElement; // 순서를 변경할 UI 요소
    public RectTransform uiElement2;
    public RectTransform uiElement3;

    // UI 요소를 가장 위로 올리는 메서드
    public void BringToFront()
    {
        if (uiElement != null)
        {
            uiElement.SetSiblingIndex(uiElement.parent.childCount - 1);
        }
        else
        {
            Debug.LogWarning("UI element is not assigned.");
        }
    }

    // UI 요소를 가장 아래로 내리는 메서드
    public void SendToBack()
    {
        if (uiElement != null)
        {
            uiElement.SetSiblingIndex(0);
        }
        else
        {
            Debug.LogWarning("UI element is not assigned.");
        }
    }

    // UI 요소를 특정 인덱스로 이동시키는 메서드
    public void SetLayerOrder(int index)
    {
        if (uiElement != null)
        {
            int siblingCount = uiElement.parent.childCount;
            uiElement.SetSiblingIndex(Mathf.Clamp(index, 0, siblingCount - 1));
        }
        else
        {
            Debug.LogWarning("UI element is not assigned.");
        }
    }
}
