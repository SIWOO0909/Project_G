using UnityEngine;

public class UIManager : MonoBehaviour
{
    public RectTransform uiElement; // ������ ������ UI ���
    public RectTransform uiElement2;
    public RectTransform uiElement3;

    // UI ��Ҹ� ���� ���� �ø��� �޼���
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

    // UI ��Ҹ� ���� �Ʒ��� ������ �޼���
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

    // UI ��Ҹ� Ư�� �ε����� �̵���Ű�� �޼���
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
