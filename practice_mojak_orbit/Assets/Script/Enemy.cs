using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform; // 따라갈 player의 Transform
    public float smoothSpeed = 0.125f; // 따라가는 속도
    public float offsetX = 0f; // player와의 x축 거리를 조절하기 위한 오프셋
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
            // player의 x 좌표에 offsetX를 더한 위치로 이동
            Vector3 desiredPosition = new Vector3(playerTransform.position.x + offsetX, transform.position.y, transform.position.z);
            // 부드러운 이동을 위해 현재 위치에서 목표 위치까지 보간
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            // 보간된 위치로 이동
            transform.position = smoothedPosition;
        }
    }
}
