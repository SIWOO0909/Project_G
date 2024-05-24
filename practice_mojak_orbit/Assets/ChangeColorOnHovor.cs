using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeColorOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image uiImage;  // 색상을 변경할 UI Image
    public Color hoverColor = Color.red;  // 마우스 오버 시 변경할 색상
    private Color originalColor;  // 원래 색상 저장

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
