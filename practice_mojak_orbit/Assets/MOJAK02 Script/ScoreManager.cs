using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    // UI Component
    public TextMeshProUGUI TotalScoreTxt;
    public TextMeshProUGUI totalCoinsTxt_InGame;

    public TextMeshProUGUI gameOverTotalScoreTxt;
    public TextMeshProUGUI gameOverBestScoreTxt;
    public TextMeshProUGUI gameOverEarnCoinTxt;

    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI four;
    public TextMeshProUGUI five;

    public Transform trackedObject;

    // 변수 선언
    static public int abc = 0; // 랭크 시스템 작동 여부 abc값이 1일때 실행
    static public int a = 0;
    public static int scoreValueSaved;
    private int scoreValue;
    private int minsu1;
    private float previousXPosition;
    public float NowScoreSlowEffect;
    public float BestScoreSlowEffect;
    //float text_score = 0f;

    // 시작함수
    private void Start()
    {
        abc = 0;
        previousXPosition = trackedObject.position.x;
        minsu1 = 0;
        //text_score = 0;
    }

    // 업데이트 함수
    public void Update()
    {

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

        // 점수가 10점 단위로 증가하게 됩니다.
        int a = (scoreValueSaved / 10) * 10;

        // top5점수 계산 함수입니다.
        RankSys(a);

        // 플레이어 사망시 TOP5 랭킹시스템 실행
        if (abc > 0)
        {
            RankSys(a);
        }

        // 점수 100점당 1코인 지급
        if (a % 100 == 0)
        {
            int crrCoins = PlayerPrefs.GetInt("scoreCoins"); // scoreCoins형태로 기기저장 점수가 crrCoins에 값이 입력되고
            crrCoins = a / 100; // 현 점수를 100으로 나눈값이 crrCoins
            PlayerPrefs.SetInt("scoreCoins", crrCoins); // crrCoins를 다시 scoreCoins형태로 기기저장

            // UI상 기기에 저장된 scoreCoin 보여지기
            totalCoinsTxt_InGame.text = PlayerPrefs.GetInt("scoreCoins").ToString();

            if (a >= 100)
            {
                crrCoins += PlayerPrefs.GetInt("scoreCoins");
                PlayerPrefs.SetInt("totalCoins", crrCoins - 1);
            }
        }
        TotalScoreTxt.text = a.ToString(); // 현재 점수 출력

        // 게임오버UI 현재 점수 연출 시스템
        //float floata = a;
        //floata += 2000 * Time.deltaTime * 0.8f;
        //int aaa = (int)Mathf.Round(floata);
        //gameOverTotalScoreTxt.text = aaa.ToString(); // 게임오버UI에 현재 점수 출력
        float floata = a;
        floata += 1000 * Time.deltaTime * NowScoreSlowEffect;
        if (a >= 1000)
        {
            gameOverTotalScoreTxt.text = 1000.ToString("F0");
        }
        else
        {
            gameOverTotalScoreTxt.text = floata.ToString("F0");
        }

        // 게임오버시 베스트 점수 연출 시스템
        float floatb = PlayerPrefs.GetInt(0 + "BestScore");
        floatb += 2000 * Time.deltaTime * NowScoreSlowEffect;
        int bbb = (int)Mathf.Round(floatb);
        gameOverBestScoreTxt.text = bbb.ToString(); // 게임오버UI베스트 점수 출력

        // 
        if (a > 100)
        {
            float floatc = PlayerPrefs.GetInt("scoreCoins");
            floatc += 2000 * Time.deltaTime * NowScoreSlowEffect;
            int ccc = (int)Mathf.Round(floatc);
            gameOverEarnCoinTxt.text = ccc.ToString();
        }

        // Top 5 출력
        one.text = PlayerPrefs.GetInt(0 + "BestScore").ToString();
        two.text = PlayerPrefs.GetInt(1 + "BestScore").ToString();
        three.text = PlayerPrefs.GetInt(2 + "BestScore").ToString();
        four.text = PlayerPrefs.GetInt(3 + "BestScore").ToString();
        five.text = PlayerPrefs.GetInt(4 + "BestScore").ToString();
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