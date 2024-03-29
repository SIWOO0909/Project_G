using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform; // ���� player�� Transform
    public float smoothSpeed = 0.125f; // ���󰡴� �ӵ�
    public float offsetX = 0f; // player���� x�� �Ÿ��� �����ϱ� ���� ������
    public float delayTime = 10f; // ��߱����� ������ �ð�

    private bool isFollowing = false; // ��� ���θ� ��Ÿ���� ����
    private float startTime; // ��� �ð�

    void Start()
    {
        startTime = Time.time + delayTime; // ���� �ð� ����
    }

    void FixedUpdate()
    {
        if (Time.time >= startTime && !isFollowing)
        {
            isFollowing = true; // ��� ����
        }

        if (isFollowing)
        {
            // player�� x ��ǥ�� offsetX�� ���� ��ġ�� �̵�
            Vector3 desiredPosition = new Vector3(playerTransform.position.x + offsetX, transform.position.y, transform.position.z);
            // �ε巯�� �̵��� ���� ���� ��ġ���� ��ǥ ��ġ���� ����
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            // ������ ��ġ�� �̵�
            transform.position = smoothedPosition;
        }
    }
}
