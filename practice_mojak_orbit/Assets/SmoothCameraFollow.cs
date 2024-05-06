using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target; // ī�޶� ���� ��� (�÷��̾�)
    public float smoothSpeed = 0.125f; // �̵� �ӵ� (0�� �������� �ε巯��)

    void LateUpdate()
    {
        // �÷��̾��� ���� ��ġ
        Vector3 targetPosition = target.position;

        // �÷��̾��� x��ǥ�� ��������, ī�޶��� ���� y�� z ��ǥ�� ����
        Vector3 desiredPosition = new Vector3(targetPosition.x - 3, transform.position.y, targetPosition.z);

        // �ε巯�� �̵��� ���� Lerp �Լ� ���
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // �ε巯�� �̵��� �����Ͽ� ī�޶� �̵�
        transform.position = smoothedPosition;
    }
}
