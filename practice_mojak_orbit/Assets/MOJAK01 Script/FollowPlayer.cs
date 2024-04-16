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
            // y��ǥ�� ���� ī�޶��� y��ǥ�� ����
            targetPosition.y = transform.position.y;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothness);
        }
    }
}
