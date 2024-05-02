using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text text;
    public int scoreValue;
    public Transform trackedObject;
    private float previousXPosition;

    private void Start()
    {
        // 초기 X 위치 설정
        previousXPosition = trackedObject.position.x;

        // 점수 초기화
        scoreValue = 0;

        // Text 컴포넌트 가져오기
        text = GetComponent<Text>();
    }

    private void Update()
    {
        // 현재 X 위치 가져오기
        float currentXPosition = trackedObject.position.x;

        // X 위치가 증가했는지 확인
        if (currentXPosition > previousXPosition)
        {
            // X 위치가 증가하면 점수 증가
            scoreValue += 1;
        }

        // 이전 X 위치 업데이트
        previousXPosition = currentXPosition;

        // UI 텍스트 업데이트
        text.text = "Score  " + (scoreValue/10)*10;
    }
}
