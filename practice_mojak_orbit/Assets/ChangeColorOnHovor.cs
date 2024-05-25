using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeColorOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image uiImage;  // ������ ������ UI Image
    public Color hoverColor = Color.red;  // ���콺 ���� �� ������ ����
    private Color originalColor;  // ���� ���� ����

    private void Start()
    {
        if (uiImage == null)
        {
            uiImage = GetComponent<Image>();
        }
        originalColor = uiImage.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        uiImage.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        uiImage.color = originalColor;
    }
}
