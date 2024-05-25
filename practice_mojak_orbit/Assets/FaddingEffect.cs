using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadingEffect : MonoBehaviour
{
    public Image uiImage;  // 투명도를 조절할 UI Image
    public float duration = 1.0f;  // 투명도가 변하는데 걸리는 시간

    private void Start()
    {
        if (uiImage == null)
        {
            uiImage = GetComponent<Image>();
        }
        StartCoroutine(FadeInOut());
    }

    private IEnumerator FadeInOut()
    {
        while (true)
        {
            yield return StartCoroutine(FadeTo(0.0f, duration));  // 투명해짐
            yield return StartCoroutine(FadeTo(1.0f, duration));  // 불투명해짐
        }
    }

    private IEnumerator FadeTo(float targetAlpha, float duration)
    {
        float startAlpha = uiImage.color.a;
        float elapsedTime = 0.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / duration);
            Color color = uiImage.color;
            color.a = newAlpha;
            uiImage.color = color;
            yield return null;
        }

        Color finalColor = uiImage.color;
        finalColor.a = targetAlpha;
        uiImage.color = finalColor;
    }
}
