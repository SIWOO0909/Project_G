using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform�� ������ ����

    void Update()
    {
        if (player != null)
        {
            // �÷��̾��� x��ǥ�� ���󰡴� �ڵ�
            Vector3 targetPosition = transform.position;
            targetPosition.x = player.position.x;
            targetPosition.z = player.position.z;
            transform.position = targetPosition;
        }
        else
        {
            Debug.LogWarning("�÷��̾ ã�� �� �����ϴ�!");
        }
    }
}
