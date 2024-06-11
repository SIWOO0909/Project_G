using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform을 저장할 변수

    void Update()
    {
        if (player != null)
        {
            // 플레이어의 x좌표를 따라가는 코드
            Vector3 targetPosition = transform.position;
            targetPosition.x = player.position.x;
            targetPosition.z = player.position.z;
            transform.position = targetPosition;
        }
        else
        {
            Debug.LogWarning("플레이어를 찾을 수 없습니다!");
        }
    }
}
