using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform; // ���� player�� Transform
    public float moveSpeed = 5f; // �⺻ �̵� �ӵ�
    public float boostedSpeed = 10f; // ���ӵ� �̵� �ӵ�
    public float distanceThreshold = 20f; // �ӵ��� ������ �Ÿ� �Ӱ谪

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
            // Player���� X�� �Ÿ� ���
            float distanceToPlayerX = Mathf.Abs(transform.position.x - playerTransform.position.x);

            // �Ÿ��� ���� �ӵ� ����
            float speed = distanceToPlayerX >= distanceThreshold ? boostedSpeed : moveSpeed;

            // �ӵ��� ���� �̵�
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
