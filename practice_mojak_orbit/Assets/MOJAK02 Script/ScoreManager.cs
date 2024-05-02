using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text text;
    public int scoreValue;
    public Transform trackedObject;
    private float previousXPosition;

    private void Start()
    {
        // �ʱ� X ��ġ ����
        previousXPosition = trackedObject.position.x;

        // ���� �ʱ�ȭ
        scoreValue = 0;

        // Text ������Ʈ ��������
        text = GetComponent<Text>();
    }

    private void Update()
    {
        // ���� X ��ġ ��������
        float currentXPosition = trackedObject.position.x;

        // X ��ġ�� �����ߴ��� Ȯ��
        if (currentXPosition > previousXPosition)
        {
            // X ��ġ�� �����ϸ� ���� ����
            scoreValue += 1;
        }

        // ���� X ��ġ ������Ʈ
        previousXPosition = currentXPosition;

        // UI �ؽ�Ʈ ������Ʈ
        text.text = "Score  " + (scoreValue/10)*10;
    }
}
