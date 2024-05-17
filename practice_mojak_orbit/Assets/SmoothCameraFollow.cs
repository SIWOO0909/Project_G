using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target; // 카메라가 따라갈 대상 (플레이어)
    public float smoothSpeed = 0.125f; // 이동 속도 (0에 가까울수록 부드러움)

    void LateUpdate()
    {
        // 플레이어의 현재 위치
        Vector3 targetPosition = target.position;

        // 플레이어의 x좌표만 가져오고, 카메라의 현재 y와 z 좌표를 유지
        Vector3 desiredPosition = new Vector3(targetPosition.x - 3, transform.position.y, targetPosition.z);

        // 부드러운 이동을 위해 Lerp 함수 사용
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 부드러운 이동을 적용하여 카메라 이동
        transform.position = smoothedPosition;
    }
}
