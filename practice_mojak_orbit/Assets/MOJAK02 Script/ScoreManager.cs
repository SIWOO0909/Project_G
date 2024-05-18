using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    #region Good-Bye Declaration (굿바이 선언)
    public TextMeshProUGUI TotalScoreTxt;
    public TextMeshProUGUI gameOverTotalScoreTxt;
    public TextMeshProUGUI gameOverBestScoreTxt;

    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI four;
    public TextMeshProUGUI five;



    static public int abc = 0;

    public static int scoreValueSaved;
    private int scoreValue;
    private int minsu1;

    public Transform trackedObject;
    private float previousXPosition;
    #endregion
    private void Start()
    {
        abc = 0;
        previousXPosition = trackedObject.position.x;
        minsu1 = 0;
    }

    public void Update()
    {
        #region 점수 시스템
        // 플레이어의 X좌표 가져오기
        float currentXPosition = trackedObject.position.x;

        // 양수 일때만 점수 증가
        if (scoreValue >= 0)
        {
            if (currentXPosition > previousXPosition)
            {
                // X 위치가 증가하면 민수 증가
                minsu1 += 1;
            }
            else if (currentXPosition < previousXPosition)
            {
                // X 위치가 감소하면 민수 감소
                minsu1 -= 1;
            }

            if (minsu1 > scoreValue)
            {
                scoreValue = minsu1;
            }
            scoreValueSaved = scoreValue;
        }
        previousXPosition = currentXPosition;

        // score +10
        int a = (scoreValueSaved / 10) * 10;
        #endregion

        if (abc > 0)
        {
            RankSys(a);
        }

        #region 출력
        TotalScoreTxt.text = a.ToString();
        gameOverTotalScoreTxt.text = a.ToString();
        gameOverBestScoreTxt.text = PlayerPrefs.GetInt(0 + "BestScore").ToString();

        one.text = PlayerPrefs.GetInt(0 + "BestScore").ToString();
        two.text = PlayerPrefs.GetInt(1 + "BestScore").ToString();
        three.text = PlayerPrefs.GetInt(2 + "BestScore").ToString();
        four.text = PlayerPrefs.GetInt(3 + "BestScore").ToString();
        five.text = PlayerPrefs.GetInt(4 + "BestScore").ToString();
        
        #endregion
    }

    #region 랭킹 초기화 버튼
    public void ResetRankings()
    {
        PlayerPrefs.SetInt(0 + "BestScore",5);
        PlayerPrefs.SetInt(1 + "BestScore",4);
        PlayerPrefs.SetInt(2 + "BestScore",3);
        PlayerPrefs.SetInt(3 + "BestScore",2);
        PlayerPrefs.SetInt(4 + "BestScore",1);
    }
    #endregion

    // void 함수 (int형 변수값)
    // int형 변수값에 따라 다른 값을 내뱉는 함수
    static public void RankSys(int intValue)
    {
        #region 민수
        // 현재 점수 = intValue
        // 1등 점수 (기기 저장) = PlayerPrefs.GetInt(0 + "BestScore") = 최고 점수 (기기 저장)
        // 2등 점수 (기기 저장) = PlayerPrefs.GetInt(1 + "BestScore")
        // 3등 점수 (기기 저장) = PlayerPrefs.GetInt(2 + "BestScore")
        // 4등 점수 (기기 저장) = PlayerPrefs.GetInt(3 + "BestScore")
        // 5등 점수 (기기 저장) = PlayerPrefs.GetInt(4 + "BestScore")

        // 임시 저장 변수 생성 
        // temp는 임시라는 뜻
        int temp = 0;
        int temp2 = 0;
        int temp3 = 0;
        int temp4 = 0;


        // 만약 (현재점수 > 최고점수) 일때
        if (intValue > PlayerPrefs.GetInt(0 + "BestScore"))
        {
            // 1등 점수 <- 현재 점수 값
            temp = PlayerPrefs.GetInt(0 + "BestScore"); // temp <- 1등
            PlayerPrefs.SetInt(0 + "BestScore", intValue); // 1등 <- 현재 점수

            // 2등 점수 <- 1등 점수 값
            temp2 = PlayerPrefs.GetInt(1 + "BestScore"); // temp2 <- 2등
            PlayerPrefs.SetInt(1 + "BestScore", temp); // 2등 <- temp (1등)

            // 3등 점수 <- 2등 점수 값
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3등
            PlayerPrefs.SetInt(2 + "BestScore", temp2); // 3등 <- temp2 (2등)

            // 4등 점수 <- 3등 점수 값
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4등
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4등 <- temp3 (3등)

            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5등 <- temp4 (4등)
        }

        // 만약 (현재점수 > 2등점수 && 현재점수 < 1등점수) 일떄
        else if (intValue > PlayerPrefs.GetInt(1 + "BestScore") && intValue < PlayerPrefs.GetInt(0 + "BestScore"))
        {
            // 2등 점수 <- 1등 점수 값
            temp2 = PlayerPrefs.GetInt(1 + "BestScore"); // temp2 <- 2등
            PlayerPrefs.SetInt(1 + "BestScore", intValue); // 2등 <- intValue (현재점수)

            // 3등 점수 <- 2등 점수 값
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3등
            PlayerPrefs.SetInt(2 + "BestScore", temp2); // 3등 <- temp2 (2등)

            // 4등 점수 <- 3등 점수 값
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4등
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4등 <- temp3 (3등)

            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5등 <- temp4 (4등)
        }

        // 만약 (현재점수 > 3등점수 && 현재점수 < 2등점수) 일때
        else if (intValue > PlayerPrefs.GetInt(2 + "BestScore")&&intValue<PlayerPrefs.GetInt(1 + "BestScore"))
        {
            // 3등 점수 <- 2등 점수 값
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3등
            PlayerPrefs.SetInt(2 + "BestScore", intValue); // 3등 <- intValue (현재점수)

            // 4등 점수 <- 3등 점수 값
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4등
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4등 <- temp3 (3등)

            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5등 <- temp4 (4등)
        }

        // 만약 (현재점수 > 4등점수 && 현재점수 < 3등점수) 일때
        else if (intValue > PlayerPrefs.GetInt(3 + "BestScore")&&intValue< PlayerPrefs.GetInt(2 + "BestScore"))
        {
            // 4등 점수 <- 3등 점수 값
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4등
            PlayerPrefs.SetInt(3 + "BestScore", intValue); // 4등 <- intValue (현재점수)

            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5등 <- temp4 (4등)
        }

        else if (intValue > PlayerPrefs.GetInt(4 + "BestScore")&&intValue<PlayerPrefs.GetInt(3 + "BestScore"))
        {
            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", intValue); // 5등 <- intValue (현재점수)
        }

        #endregion

        
    }

}