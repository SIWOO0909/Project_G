using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0; // ���� ����
    private int lastPlayerX = 0; // ���� �÷��̾��� X ��ǥ
    private bool isMovingRight = false; // �÷��̾ ���������� �̵� ������ ���θ� ��Ÿ���� ����

    void Update()
    {
        // �÷��̾��� ���� X ��ǥ
        int currentPlayerX = Mathf.RoundToInt(transform.position.x);

        // �÷��̾ ���������� �̵��� ��쿡�� ������ �߰�
        if (currentPlayerX > lastPlayerX && isMovingRight)
        {
            score++;
            Debug.Log("Score: " + score);
        }

        // �÷��̾��� �̵� ���⿡ ���� ���� ��ġ ����
        lastPlayerX = currentPlayerX;

        // �÷��̾��� �̵� ������ Ȯ���Ͽ� ���������� �̵� ������ ����
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        isMovingRight = horizontalInput > 0;
    }
}
