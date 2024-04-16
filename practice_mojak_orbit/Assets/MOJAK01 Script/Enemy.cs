using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform; // 따라갈 player의 Transform
    public float moveSpeed = 5f; // 기본 이동 속도
    public float boostedSpeed = 10f; // 가속된 이동 속도
    public float distanceThreshold = 20f; // 속도를 가속할 거리 임계값

    public float delayTime = 10f; // 출발까지의 딜레이 시간

    private bool isFollowing = false; // 출발 여부를 나타내는 변수
    private float startTime; // 출발 시간

    void Start()
    {
        startTime = Time.time + delayTime; // 시작 시간 설정
    }

    void FixedUpdate()
    {
        if (Time.time >= startTime && !isFollowing)
        {
            isFollowing = true; // 출발 시작
        }

        if (isFollowing)
        {
            // Player와의 X축 거리 계산
            float distanceToPlayerX = Mathf.Abs(transform.position.x - playerTransform.position.x);

            // 거리에 따라 속도 결정
            float speed = distanceToPlayerX >= distanceThreshold ? boostedSpeed : moveSpeed;

            // 속도에 따라 이동
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
