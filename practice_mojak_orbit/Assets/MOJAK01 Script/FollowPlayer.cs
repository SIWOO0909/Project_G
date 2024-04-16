using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offSet;
    [SerializeField] private float smoothness;

    private void Update()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.transform.position + offSet;
            // y좌표를 현재 카메라의 y좌표로 고정
            targetPosition.y = transform.position.y;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothness);
        }
    }
}
