using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0; // 현재 점수
    private int lastPlayerX = 0; // 이전 플레이어의 X 좌표
    private bool isMovingRight = false; // 플레이어가 오른쪽으로 이동 중인지 여부를 나타내는 변수

    void Update()
    {
        // 플레이어의 현재 X 좌표
        int currentPlayerX = Mathf.RoundToInt(transform.position.x);

        // 플레이어가 오른쪽으로 이동한 경우에만 점수를 추가
        if (currentPlayerX > lastPlayerX && isMovingRight)
        {
            score++;
            Debug.Log("Score: " + score);
        }

        // 플레이어의 이동 방향에 따라 이전 위치 갱신
        lastPlayerX = currentPlayerX;

        // 플레이어의 이동 방향을 확인하여 오른쪽으로 이동 중인지 갱신
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        isMovingRight = horizontalInput > 0;
    }
}
