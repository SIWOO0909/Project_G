using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text text;

    // int�� ���� ���� ����
    public int scoreValue;

    // int�� ���� �μ�1 ����
    public int minsu1;

    public Transform trackedObject;
    private float previousXPosition;

    private void Start()
    {
        // �ʱ� X ��ġ ����
        previousXPosition = trackedObject.position.x;

        // ���� �ʱ�ȭ
        scoreValue = 0;

        // �μ� �ʱ�ȭ
        minsu1 = 0;

        // Text ������Ʈ ��������
        text = GetComponent<Text>();
    }

    private void Update()
    {
        // ���� X ��ġ ��������
        float currentXPosition = trackedObject.position.x;

        /* X ��ġ�� �����ߴ��� Ȯ��
        if (currentXPosition > previousXPosition)
        {
            // X ��ġ�� �����ϸ� ���� ����
            scoreValue += 1;
        }

        // X ��ġ�� �����ߴ��� Ȯ�� 
        if (currentXPosition < previousXPosition)
        {
            // X ��ġ�� �����ϸ� ���� ����
            scoreValue -= 1;
        }
        */
        
        // ��� �϶��� ���� ����
        if (scoreValue >= 0)
        {
            if (currentXPosition > previousXPosition)
            {
                // X ��ġ�� �����ϸ� �μ� ����
                minsu1 += 1;
            }

            // X ��ġ�� �����ߴ��� Ȯ�� 
            if (currentXPosition < previousXPosition)
            {
                // X ��ġ�� �����ϸ� �μ� ����
                minsu1 -= 1;
            }

            if (minsu1 > scoreValue)
            {
                scoreValue = minsu1;
            }
        }

        // ���� X ��ġ ������Ʈ
        previousXPosition = currentXPosition;

        // UI �ؽ�Ʈ ������Ʈ
        text.text = "Score  " + (scoreValue/10)*10;
    }
}
