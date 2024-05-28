using UnityEngine;
using TMPro;
using System;
using System.Collections;
using UnityEngine.XR;

public class ScoreManager : MonoBehaviour
{
    #region 선언
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

    public TextMeshProUGUI Date1;
    public TextMeshProUGUI Date2;
    public TextMeshProUGUI Date3;
    public TextMeshProUGUI Date4;
    public TextMeshProUGUI Date5;

    public GameObject GameOverUI;

    public TextMeshProUGUI ROne;
    public TextMeshProUGUI RTwo;
    public TextMeshProUGUI RThree;
    public TextMeshProUGUI RFour;
    public TextMeshProUGUI RFive;

    public TextMeshProUGUI RDate1;
    public TextMeshProUGUI RDate2;
    public TextMeshProUGUI RDate3;
    public TextMeshProUGUI RDate4;
    public TextMeshProUGUI RDate5;


    public float pf;

    // public float i;
    // 변수 선언
    static public int abc = 0; // 랭크 시스템 작동 여부 abc값이 1일때 실행
    static public int a = 0;
    public static int scoreValueSaved;
    private int scoreValue;
    private int minsu1;
    //private int score;
    //private int displayScore;
    private float previousXPosition;
    // public float NowScoreSlowEffect;
    // public float BestScoreSlowEffect;
    public static int abc_score = 0; // 점수 연출
    //float text_score = 0f;

    #endregion

    #region 한 번 실행
    private void Start()
    {
        abc = 0;
        abc_score = 0;
        previousXPosition = trackedObject.position.x;
        minsu1 = 0;
    }

    
    #endregion
    public void Update() // 매 프레임 실행
    {
        #region 점수 증감
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
        #endregion

        #region 게임오버시
        switch (abc)
        {
            case 1:
                RankSys(a);
                PlayerPrefs.SetInt("NowScore", a);
                // RecentSys(a);
                abc = 0;
                Debug.Log("TOP5함수를 실행합니다.");
                break;
        }
        #endregion

        #region 100점 = 1코인
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
        #endregion

        #region 점수 연출
        float scaledIncrement = 1000 * Time.deltaTime *pf; // Time.deltaTime을 곱하여 프레임당 증가량 계산

        // 현재 점수
        float floata = a;
        floata += scaledIncrement;
        gameOverTotalScoreTxt.text = floata.ToString();

        // 베스트 점수
        float floatb = PlayerPrefs.GetInt(0 + "BestScore");
        floatb += scaledIncrement;
        gameOverBestScoreTxt.text = floatb.ToString(); // 게임오버UI베스트 점수 출력

        // 얻은 코인
        if (a > 100)
        {
            float floatc = PlayerPrefs.GetInt("scoreCoins");
            floatc += scaledIncrement;
            gameOverEarnCoinTxt.text = floatc.ToString();
        }
        #endregion

        #region TOP 5 출력
        if (PlayerPrefs.GetInt(0 + "BestScore") < 6)
        {
            one.text = "0";
        }
        else
        {
            one.text = PlayerPrefs.GetInt(0 + "BestScore").ToString();
        }
        if (PlayerPrefs.GetInt(1 + "BestScore") < 6)
        {
            two.text = "0";
        }
        else
        {
            two.text = PlayerPrefs.GetInt(1 + "BestScore").ToString();
        }
        if (PlayerPrefs.GetInt(2 + "BestScore") < 6)
        {
            three.text = "0";
        }
        else
        {
            three.text = PlayerPrefs.GetInt(2 + "BestScore").ToString();
        }
        if (PlayerPrefs.GetInt(3 + "BestScore") < 6)
        {
            four.text = "0";
        }
        else
        {
            four.text = PlayerPrefs.GetInt(3 + "BestScore").ToString();
        }
        if (PlayerPrefs.GetInt(4 + "BestScore") < 6)
        {
            five.text = "0";
        }
        else
        {
            five.text = PlayerPrefs.GetInt(4 + "BestScore").ToString();
        }
        #endregion

        #region TOP5 날짜 출력
        Date1.text = PlayerPrefs.GetString(0 + "Date").ToString();
        Date2.text = PlayerPrefs.GetString(1 + "Date").ToString();
        Date3.text = PlayerPrefs.GetString(2 + "Date").ToString();
        Date4.text = PlayerPrefs.GetString(3 + "Date").ToString();
        Date5.text = PlayerPrefs.GetString(4 + "Date").ToString();
        #endregion

        #region 최근 기록 출력
        ROne.text = PlayerPrefs.GetInt(0 + "RecentScore").ToString();
        RTwo.text = PlayerPrefs.GetInt(1 + "RecentScore").ToString();
        RThree.text = PlayerPrefs.GetInt(2 + "RecentScore").ToString();
        RFour.text = PlayerPrefs.GetInt(3 + "RecentScore").ToString();
        RFive.text = PlayerPrefs.GetInt(4 + "RecentScore").ToString();
        #endregion

        #region 최근 기록 날짜 출력
        RDate1.text = PlayerPrefs.GetString(0 + "RDate").ToString();
        RDate2.text = PlayerPrefs.GetString(1 + "RDate").ToString();
        RDate3.text = PlayerPrefs.GetString(2 + "RDate").ToString();
        RDate4.text = PlayerPrefs.GetString(3 + "RDate").ToString();
        RDate5.text = PlayerPrefs.GetString(4 + "RDate").ToString();
        #endregion
    }

    #region 최근기록 함수
    static public void RecentSys(int a)
    {
        #region 임시 int 저장소
        // 임시 저장 변수 생성 
        // temp는 임시라는 뜻
        int Rtemp1 = 0;
        int Rtemp2 = 0;
        int Rtemp3 = 0;
        int Rtemp4 = 0;
        #endregion

        #region 임시 str 저장소
        string RtempStr1 = "";
        string RtempStr2 = "";
        string RtempStr3 = "";
        string RtempStr4 = "";
        #endregion

        // 1등 <- 현재 점수
        Rtemp1 = PlayerPrefs.GetInt(0 + "RecentScore"); // temp <- 1등
        PlayerPrefs.SetInt(0 + "RecentScore", a); // 1등 <- 현재 점수
        // 1등 날짜 <- 현 날짜
        RtempStr1 = PlayerPrefs.GetString(0 + "RDate");
        PlayerPrefs.SetString(0 + "RDa'te", DateTime.Now.ToString("yyyy/MM/dd"));

        // 2등 점수 <- 1등 점수 값
        Rtemp2 = PlayerPrefs.GetInt(1 + "RecentScore"); // temp2 <- 2등
        PlayerPrefs.SetInt(1 + "RecentScore", Rtemp1); // 2등 <- temp (1등)
        // 2등 날짜 <- 1등 날짜
        RtempStr2 = PlayerPrefs.GetString(1 + "RDate");
        PlayerPrefs.SetString(1 + "RDate", RtempStr1);

        // 3등 점수 <- 2등 점수 값
        Rtemp3 = PlayerPrefs.GetInt(2 + "RecentScore"); // temp3 <- 3등
        PlayerPrefs.SetInt(2 + "RecentScore", Rtemp2); // 3등 <- temp2 (2등)
        // 3등 날짜 <- 2등 날짜
        RtempStr3 = PlayerPrefs.GetString(2 + "RDate");
        PlayerPrefs.SetString(2 + "RDate", RtempStr2);

        // 4등 점수 <- 3등 점수 값
        Rtemp4 = PlayerPrefs.GetInt(3 + "RecentScore"); // temp4 <- 4등
        PlayerPrefs.SetInt(3 + "RecentScore", Rtemp3); // 4등 <- temp3 (3등)
        // 4등 날짜 <- 3등 날짜 
        RtempStr4 = PlayerPrefs.GetString(3 + "RDate");
        PlayerPrefs.SetString(3 + "RDate", RtempStr3);

        // 5등 점수 <- 4등 점수 값
        PlayerPrefs.SetInt(4 + "RecentScore", Rtemp4); // 5등 <- temp4 (4등)
        // 5등 날짜 <- 4등 날짜 
        PlayerPrefs.SetString(4 + "RDate", RtempStr4);
    }
    #endregion

    #region 랭킹, 날짜, 최근기록 초기화 함수
    static public void ResetRankings()
    {
        // TOP 5
        PlayerPrefs.SetInt(0 + "BestScore",5);// 0번 때 BestScore에 5점 넘겨준다.
        PlayerPrefs.SetInt(1 + "BestScore",4);
        PlayerPrefs.SetInt(2 + "BestScore",3);
        PlayerPrefs.SetInt(3 + "BestScore",2);
        PlayerPrefs.SetInt(4 + "BestScore",1);

        // TOP 5 날짜
        PlayerPrefs.SetString(0 + "Date", DateTime.Now.ToString("yyyy/MM/dd"));// 0번 때 Date에 현재 날짜를 지금으로 초기화
        PlayerPrefs.SetString(1 + "Date", DateTime.Now.ToString("yyyy/MM/dd"));
        PlayerPrefs.SetString(2 + "Date", DateTime.Now.ToString("yyyy/MM/dd"));
        PlayerPrefs.SetString(3 + "Date", DateTime.Now.ToString("yyyy/MM/dd"));
        PlayerPrefs.SetString(4 + "Date", DateTime.Now.ToString("yyyy/MM/dd"));

        // 최근 기록
        PlayerPrefs.SetInt(0 + "RecentScore", 0);
        PlayerPrefs.SetInt(1 + "RecentScore", 0);
        PlayerPrefs.SetInt(2 + "RecentScore", 0);
        PlayerPrefs.SetInt(3 + "RecentScore", 0);
        PlayerPrefs.SetInt(4 + "RecentScore", 0);

        // 최근 기록 날짜
        PlayerPrefs.SetString(0 + "RDate", DateTime.Now.ToString("yyyy/MM/dd"));
        PlayerPrefs.SetString(1 + "RDate", DateTime.Now.ToString("yyyy/MM/dd"));
        PlayerPrefs.SetString(2 + "RDate", DateTime.Now.ToString("yyyy/MM/dd"));
        PlayerPrefs.SetString(3 + "RDate", DateTime.Now.ToString("yyyy/MM/dd"));
        PlayerPrefs.SetString(4 + "RDate", DateTime.Now.ToString("yyyy/MM/dd"));
    }
    #endregion

    #region TOP 5 랭킹 및 날짜 함수
    static public void RankSys(int intValue) // intValue = 현재 점수 값
    {
        #region TOP 5 랭킹 함수 규칙
        // 현재 점수 = intValue
        // 1등 점수 (기기 저장) = PlayerPrefs.GetInt(0 + "BestScore") = 최고 점수 (기기 저장)
        // 2등 점수 (기기 저장) = PlayerPrefs.GetInt(1 + "BestScore")
        // 3등 점수 (기기 저장) = PlayerPrefs.GetInt(2 + "BestScore")
        // 4등 점수 (기기 저장) = PlayerPrefs.GetInt(3 + "BestScore")
        // 5등 점수 (기기 저장) = PlayerPrefs.GetInt(4 + "BestScore")
        #endregion

        #region 임시 int 저장소
        // 임시 저장 변수 생성 
        // temp는 임시라는 뜻
        int temp = 0;
        int temp2 = 0;
        int temp3 = 0;
        int temp4 = 0;
        #endregion

        #region 임시 str 저장소
        string tempStr1 = "";
        string tempStr2 = "";
        string tempStr3 = "";
        string tempStr4 = "";
        #endregion        

        // 만약 (1위 < 현 점수) 
        if (intValue > PlayerPrefs.GetInt(0 + "BestScore"))
        {
            // 1등 점수 <- 현재 점수 값
            temp = PlayerPrefs.GetInt(0 + "BestScore"); // temp <- 1등
            PlayerPrefs.SetInt(0 + "BestScore", intValue); // 1등 <- 현재 점수
            // 1등 날짜 <- 현 날짜
            tempStr1 = PlayerPrefs.GetString(0 + "Date");
            PlayerPrefs.SetString(0 + "Date", DateTime.Now.ToString("yyyy/MM/dd"));

            // 2등 점수 <- 1등 점수 값
            temp2 = PlayerPrefs.GetInt(1 + "BestScore"); // temp2 <- 2등
            PlayerPrefs.SetInt(1 + "BestScore", temp); // 2등 <- temp (1등)
            // 2등 날짜 <- 1등 날짜
            tempStr2 = PlayerPrefs.GetString(1 + "Date");
            PlayerPrefs.SetString(1 + "Date", tempStr1);

            // 3등 점수 <- 2등 점수 값
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3등
            PlayerPrefs.SetInt(2 + "BestScore", temp2); // 3등 <- temp2 (2등)
            // 3등 날짜 <- 2등 날짜
            tempStr3 = PlayerPrefs.GetString(2 + "Date");
            PlayerPrefs.SetString(2 + "Date", tempStr2);

            // 4등 점수 <- 3등 점수 값
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4등
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4등 <- temp3 (3등)
            // 4등 날짜 <- 3등 날짜 
            tempStr4 = PlayerPrefs.GetString(3 + "Date");
            PlayerPrefs.SetString(3 + "Date", tempStr3);

            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5등 <- temp4 (4등)
            // 5등 날짜 <- 4등 날짜 
            PlayerPrefs.SetString(4 + "BestScore", tempStr4);
        }

        // 만약 (2위 < 현 점수 < 1위) 
        else if (intValue > PlayerPrefs.GetInt(1 + "BestScore") && intValue < PlayerPrefs.GetInt(0 + "BestScore"))
        {
            // 2등 점수 <- 1등 점수 값
            temp2 = PlayerPrefs.GetInt(1 + "BestScore"); // temp2 <- 2등
            PlayerPrefs.SetInt(1 + "BestScore", intValue); // 2등 <- intValue (현재점수)
            // 2등 날짜 <- 현 날짜
            tempStr2 = PlayerPrefs.GetString(1 + "Date");
            PlayerPrefs.SetString(1 + "Date", DateTime.Now.ToString("yyyy/MM/dd"));

            // 3등 점수 <- 2등 점수 값
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3등
            PlayerPrefs.SetInt(2 + "BestScore", temp2); // 3등 <- temp2 (2등)
            // 3등 날짜 <- 2등 날짜 
            tempStr3 = PlayerPrefs.GetString(2 + "Date");
            PlayerPrefs.SetString(2 + "Date", tempStr2);

            // 4등 점수 <- 3등 점수 값
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4등
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4등 <- temp3 (3등)
            // 4등 날짜 <- 3등 날짜 
            tempStr4 = PlayerPrefs.GetString(3 + "Date");
            PlayerPrefs.SetString(3 + "Date", tempStr3);

            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5등 <- temp4 (4등)
            // 5등 날짜 <- 4등 날짜 
            PlayerPrefs.SetString(4 + "Date", tempStr4);
        }

        // 만약 (3위 < 현 점수 < 2위)
        else if (intValue > PlayerPrefs.GetInt(2 + "BestScore")&&intValue<PlayerPrefs.GetInt(1 + "BestScore"))
        {
            // 3등 점수 <- 2등 점수 값
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3등
            PlayerPrefs.SetInt(2 + "BestScore", intValue); // 3등 <- intValue (현재점수)
            // 3등 날짜 <- 2등 날짜
            tempStr3 = PlayerPrefs.GetString(2 + "Date");
            PlayerPrefs.SetString(2 + "Date", DateTime.Now.ToString("yyyy/MM/dd"));

            // 4등 점수 <- 3등 점수 값
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4등
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4등 <- temp3 (3등)
            // 4등 날짜 <- 3등 날짜
            tempStr4 = PlayerPrefs.GetString(3 + "Date");
            PlayerPrefs.SetString(3 + "Date", tempStr3);

            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5등 <- temp4 (4등)
            // 5등 날짜 <- 4등 날짜
            PlayerPrefs.SetString(4 + "Date", tempStr4);
        }

        // 만약 (4위 < 현 점수 < 3위)
        else if (intValue > PlayerPrefs.GetInt(3 + "BestScore")&&intValue< PlayerPrefs.GetInt(2 + "BestScore"))
        {
            // 4등 점수 <- 3등 점수 값
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4등
            PlayerPrefs.SetInt(3 + "BestScore", intValue); // 4등 <- intValue (현재점수)
            // 4등 점수 <- 3등 점수 값
            tempStr4 = PlayerPrefs.GetString(3 + "BestScore");
            PlayerPrefs.SetString(3 + "BestScore", DateTime.Now.ToString("yyyy/MM/dd"));

            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5등 <- temp4 (4등)
            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetString(4 + "BestScore", tempStr4);
        }

        // 만약 (5위 < 현 점수 < 4위)
        else if (intValue > PlayerPrefs.GetInt(4 + "BestScore")&&intValue<PlayerPrefs.GetInt(3 + "BestScore"))
        {
            // 5등 점수 <- 4등 점수 값
            PlayerPrefs.SetInt(4 + "BestScore", intValue); // 5등 <- intValue (현재점수)
            // 5등 날짜 <- 현 날짜
            PlayerPrefs.SetString(4 + "Date", DateTime.Now.ToString("yyyy/MM/dd"));
        }
    }
    #endregion

    #region 최근기록 함수
    public void RescentRankSysBtn()
    {
        Debug.Log("최근기록 함수를 실행합니다.");
        // RankSys(a);
        RecentSys(PlayerPrefs.GetInt("NowScore"));
    }
    #endregion
}