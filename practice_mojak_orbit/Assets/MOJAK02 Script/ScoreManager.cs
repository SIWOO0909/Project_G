using UnityEngine;
using TMPro;
using System;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    #region ����
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

    public float pf;

    // public float i;
    // ���� ����
    static public int abc = 0; // ��ũ �ý��� �۵� ���� abc���� 1�϶� ����
    static public int a = 0;
    public static int scoreValueSaved;
    private int scoreValue;
    private int minsu1;
    private int score;
    private int displayScore;
    private float previousXPosition;
    // public float NowScoreSlowEffect;
    // public float BestScoreSlowEffect;
    public static int abc_score = 0; // ���� ����
    //float text_score = 0f;

    #endregion

    #region �� �� ����
    private void Start()
    {
        abc = 0;
        abc_score = 0;
        previousXPosition = trackedObject.position.x;
        minsu1 = 0;
        // Date1.text = DateTime.Now.ToString("yyyy/M/d h:mm:ss tt");
        score = 0;
        displayScore = 0;
    }

    
    #endregion
    public void Update() // �� ������ ����
    {
        #region ���� ����
        // �÷��̾��� X��ǥ ��������
        float currentXPosition = trackedObject.position.x;

        // ��� �϶��� ���� ����
        if (scoreValue >= 0)
        {
            if (currentXPosition > previousXPosition)
            {
                // X ��ġ�� �����ϸ� �μ� ����
                minsu1 += 1;
            }
            else if (currentXPosition < previousXPosition)
            {
                // X ��ġ�� �����ϸ� �μ� ����
                minsu1 -= 1;
            }

            if (minsu1 > scoreValue)
            {
                scoreValue = minsu1;
            }
            scoreValueSaved = scoreValue;
            
        }
        previousXPosition = currentXPosition;

        // ������ 10�� ������ �����ϰ� �˴ϴ�.
        int a = (scoreValueSaved / 10) * 10;
        #endregion

        #region ���ӿ�����
        if (abc > 0)
        {
            // ��ŷ �Լ� �� ����
            RankSys(a);

            // ��¥ �Լ� �� ��¥
            // DateSys(DateTime.Now.ToString("yyyy/M/d h:mm:ss tt"));
        }
        #endregion

        #region 100�� = 1����
        if (a % 100 == 0)
        {
            int crrCoins = PlayerPrefs.GetInt("scoreCoins"); // scoreCoins���·� ������� ������ crrCoins�� ���� �Էµǰ�
            crrCoins = a / 100; // �� ������ 100���� �������� crrCoins
            PlayerPrefs.SetInt("scoreCoins", crrCoins); // crrCoins�� �ٽ� scoreCoins���·� �������

            // UI�� ��⿡ ����� scoreCoin ��������
            totalCoinsTxt_InGame.text = PlayerPrefs.GetInt("scoreCoins").ToString();

            if (a >= 100)
            {
                crrCoins += PlayerPrefs.GetInt("scoreCoins");
                PlayerPrefs.SetInt("totalCoins", crrCoins - 1);
            }
        }
        TotalScoreTxt.text = a.ToString(); // ���� ���� ���
        #endregion

        #region ���� ����
        float scaledIncrement = 1000 * Time.deltaTime *pf; // Time.deltaTime�� ���Ͽ� �����Ӵ� ������ ���

        // ���� ����
        float floata = a;
        floata += scaledIncrement;
        gameOverTotalScoreTxt.text = floata.ToString();


        // ����Ʈ ����
        float floatb = PlayerPrefs.GetInt(0 + "BestScore");
        floatb += scaledIncrement;
        gameOverBestScoreTxt.text = floatb.ToString(); // ���ӿ���UI����Ʈ ���� ���

        // ���� ����
        if (a > 100)
        {
            float floatc = PlayerPrefs.GetInt("scoreCoins");
            floatc += scaledIncrement;
            gameOverEarnCoinTxt.text = floatc.ToString();
        }
        #endregion

        #region TOP 5 ��ŷ ���
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

        #region ��¥ ���
        Date1.text = PlayerPrefs.GetString(0 + "Date").ToString();
        Date2.text = PlayerPrefs.GetString(1 + "Date").ToString();
        Date3.text = PlayerPrefs.GetString(2 + "Date").ToString();
        Date4.text = PlayerPrefs.GetString(3 + "Date").ToString();
        Date5.text = PlayerPrefs.GetString(4 + "Date").ToString();
        #endregion
    }

    #region ��ŷ, ��¥ �ʱ�ȭ �Լ�
    public void ResetRankings()
    {
        // 0�� �� BestScore�� 5�� �Ѱ��ش�.
        PlayerPrefs.SetInt(0 + "BestScore",5);
        PlayerPrefs.SetInt(1 + "BestScore",4);
        PlayerPrefs.SetInt(2 + "BestScore",3);
        PlayerPrefs.SetInt(3 + "BestScore",2);
        PlayerPrefs.SetInt(4 + "BestScore",1);

        // 0�� �� Date�� ���� ��¥�� �������� �ʱ�ȭ
        PlayerPrefs.SetString(0 + "Date", DateTime.Now.ToString("yyyy/M/d hh:mm:ss"));
        PlayerPrefs.SetString(1 + "Date", DateTime.Now.ToString("yyyy/M/d hh:mm:ss"));
        PlayerPrefs.SetString(2 + "Date", DateTime.Now.ToString("yyyy/M/d hh:mm:ss"));
        PlayerPrefs.SetString(3 + "Date", DateTime.Now.ToString("yyyy/M/d hh:mm:ss"));
        PlayerPrefs.SetString(4 + "Date", DateTime.Now.ToString("yyyy/M/d hh:mm:ss"));
    }
    #endregion
    
    #region ��ŷ ��¥ �Լ�
    private void DateSys(string v)
    {
        #region �ӽ� (str)�����
        string tempStr1 = "";
        string tempStr2 = "";
        string tempStr3 = "";
        string tempStr4 = "";
        #endregion        

        // ���� (1�� < �� ����) 
        if (a > PlayerPrefs.GetInt(0 + "BestScore"))
        {
            Debug.Log("1�� �� ��¥ ���");
            // 1�� ��¥ <- �� ��¥
            tempStr1 = PlayerPrefs.GetString(0 + "Date"); 
            PlayerPrefs.SetString(0 + "Date", DateTime.Now.ToString("yyyy/M/d hh:mm:ss"));

            // 2�� ��¥ <- 1�� ��¥
            tempStr2 = PlayerPrefs.GetString(1 + "Date"); 
            PlayerPrefs.SetString(1 + "Date", tempStr1);

            // 3�� ��¥ <- 2�� ��¥
            tempStr3 = PlayerPrefs.GetString(2 + "Date");
            PlayerPrefs.SetString(2 + "Date", tempStr2);

            // 4�� ��¥ <- 3�� ��¥ 
            tempStr4 = PlayerPrefs.GetString(3 + "Date"); 
            PlayerPrefs.SetString(3 + "Date", tempStr3);

            // 5�� ��¥ <- 4�� ��¥ 
            PlayerPrefs.SetString(4 + "BestScore", tempStr4);
        }

        // ���� (2�� < �� ���� < 1��) 
        else if (a > PlayerPrefs.GetInt(1 + "BestScore") && a < PlayerPrefs.GetInt(0 + "BestScore"))
        {
            // 2�� ��¥ <- �� ��¥
            tempStr2 = PlayerPrefs.GetString(1 + "Date"); 
            PlayerPrefs.SetString(1 + "Date", DateTime.Now.ToString("yyyy/M/d hh:mm:ss"));

            // 3�� ��¥ <- 2�� ��¥ 
            tempStr3 = PlayerPrefs.GetString(2 + "Date");
            PlayerPrefs.SetString(2 + "Date", tempStr2);

            // 4�� ��¥ <- 3�� ��¥ 
            tempStr4 = PlayerPrefs.GetString(3 + "Date");
            PlayerPrefs.SetString(3 + "Date", tempStr3);

            // 5�� ��¥ <- 4�� ��¥ 
            PlayerPrefs.SetString(4 + "Date", tempStr4); 
        }

        // ���� (3�� < �� ���� < 2��)
        else if (a > PlayerPrefs.GetInt(2 + "BestScore") && a < PlayerPrefs.GetInt(1 + "BestScore"))
        {
            // 3�� ��¥ <- 2�� ��¥
            tempStr3 = PlayerPrefs.GetString(2 + "Date");
            PlayerPrefs.SetString(2 + "Date", DateTime.Now.ToString("yyyy/M/d hh:mm:ss"));

            // 4�� ��¥ <- 3�� ��¥
            tempStr4 = PlayerPrefs.GetString(3 + "Date"); 
            PlayerPrefs.SetString(3 + "Date", tempStr3);

            // 5�� ��¥ <- 4�� ��¥
            PlayerPrefs.SetString(4 + "Date", tempStr4);
        }

        // ���� (4�� < �� ���� < 3��)
        else if (a > PlayerPrefs.GetInt(3 + "BestScore") && a < PlayerPrefs.GetInt(2 + "BestScore"))
        {
            // 4�� ���� <- 3�� ���� ��
            tempStr4 = PlayerPrefs.GetString(3 + "BestScore"); 
            PlayerPrefs.SetString(3 + "BestScore", DateTime.Now.ToString("yyyy/M/d hh:mm:ss")); 

            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetString(4 + "BestScore", tempStr4);
        }

        // ���� (5�� < �� ���� < 4��)
        else if (a > PlayerPrefs.GetInt(4 + "BestScore") && a < PlayerPrefs.GetInt(3 + "BestScore"))
        {
            // 5�� ��¥ <- �� ��¥
            PlayerPrefs.SetString(4 + "Date", DateTime.Now.ToString("yyyy/M/d hh:mm:ss"));
        }
    }
    #endregion

    #region TOP 5 ��ŷ �Լ�
    static public void RankSys(int intValue) // intValue = ���� ���� ��
    {
        #region TOP 5 ��ŷ �Լ� ��Ģ
        // ���� ���� = intValue
        // 1�� ���� (��� ����) = PlayerPrefs.GetInt(0 + "BestScore") = �ְ� ���� (��� ����)
        // 2�� ���� (��� ����) = PlayerPrefs.GetInt(1 + "BestScore")
        // 3�� ���� (��� ����) = PlayerPrefs.GetInt(2 + "BestScore")
        // 4�� ���� (��� ����) = PlayerPrefs.GetInt(3 + "BestScore")
        // 5�� ���� (��� ����) = PlayerPrefs.GetInt(4 + "BestScore")
        #endregion

        #region �ӽ� int �����
        // �ӽ� ���� ���� ���� 
        // temp�� �ӽö�� ��
        int temp = 0;
        int temp2 = 0;
        int temp3 = 0;
        int temp4 = 0;
        #endregion

        #region �ӽ� str �����
        string tempStr1 = "";
        string tempStr2 = "";
        string tempStr3 = "";
        string tempStr4 = "";
        #endregion        

        // ���� (1�� < �� ����) 
        if (intValue > PlayerPrefs.GetInt(0 + "BestScore"))
        {
            // 1�� ���� <- ���� ���� ��
            temp = PlayerPrefs.GetInt(0 + "BestScore"); // temp <- 1��
            PlayerPrefs.SetInt(0 + "BestScore", intValue); // 1�� <- ���� ����
            // 1�� ��¥ <- �� ��¥
            tempStr1 = PlayerPrefs.GetString(0 + "Date");
            PlayerPrefs.SetString(0 + "Date", DateTime.Now.ToString("yyyy/M/d h:mm:ss tt"));

            // 2�� ���� <- 1�� ���� ��
            temp2 = PlayerPrefs.GetInt(1 + "BestScore"); // temp2 <- 2��
            PlayerPrefs.SetInt(1 + "BestScore", temp); // 2�� <- temp (1��)
            // 2�� ��¥ <- 1�� ��¥
            tempStr2 = PlayerPrefs.GetString(1 + "Date");
            PlayerPrefs.SetString(1 + "Date", tempStr1);

            // 3�� ���� <- 2�� ���� ��
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3��
            PlayerPrefs.SetInt(2 + "BestScore", temp2); // 3�� <- temp2 (2��)
            // 3�� ��¥ <- 2�� ��¥
            tempStr3 = PlayerPrefs.GetString(2 + "Date");
            PlayerPrefs.SetString(2 + "Date", tempStr2);

            // 4�� ���� <- 3�� ���� ��
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4��
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4�� <- temp3 (3��)
            // 4�� ��¥ <- 3�� ��¥ 
            tempStr4 = PlayerPrefs.GetString(3 + "Date");
            PlayerPrefs.SetString(3 + "Date", tempStr3);

            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5�� <- temp4 (4��)
            // 5�� ��¥ <- 4�� ��¥ 
            PlayerPrefs.SetString(4 + "BestScore", tempStr4);
        }

        // ���� (2�� < �� ���� < 1��) 
        else if (intValue > PlayerPrefs.GetInt(1 + "BestScore") && intValue < PlayerPrefs.GetInt(0 + "BestScore"))
        {
            // 2�� ���� <- 1�� ���� ��
            temp2 = PlayerPrefs.GetInt(1 + "BestScore"); // temp2 <- 2��
            PlayerPrefs.SetInt(1 + "BestScore", intValue); // 2�� <- intValue (��������)
            // 2�� ��¥ <- �� ��¥
            tempStr2 = PlayerPrefs.GetString(1 + "Date");
            PlayerPrefs.SetString(1 + "Date", DateTime.Now.ToString("yyyy/M/d h:mm:ss tt"));

            // 3�� ���� <- 2�� ���� ��
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3��
            PlayerPrefs.SetInt(2 + "BestScore", temp2); // 3�� <- temp2 (2��)
            // 3�� ��¥ <- 2�� ��¥ 
            tempStr3 = PlayerPrefs.GetString(2 + "Date");
            PlayerPrefs.SetString(2 + "Date", tempStr2);

            // 4�� ���� <- 3�� ���� ��
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4��
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4�� <- temp3 (3��)
            // 4�� ��¥ <- 3�� ��¥ 
            tempStr4 = PlayerPrefs.GetString(3 + "Date");
            PlayerPrefs.SetString(3 + "Date", tempStr3);

            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5�� <- temp4 (4��)
            // 5�� ��¥ <- 4�� ��¥ 
            PlayerPrefs.SetString(4 + "Date", tempStr4);
        }

        // ���� (3�� < �� ���� < 2��)
        else if (intValue > PlayerPrefs.GetInt(2 + "BestScore")&&intValue<PlayerPrefs.GetInt(1 + "BestScore"))
        {
            // 3�� ���� <- 2�� ���� ��
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3��
            PlayerPrefs.SetInt(2 + "BestScore", intValue); // 3�� <- intValue (��������)
            // 3�� ��¥ <- 2�� ��¥
            tempStr3 = PlayerPrefs.GetString(2 + "Date");
            PlayerPrefs.SetString(2 + "Date", DateTime.Now.ToString("yyyy/M/d h:mm:ss tt"));

            // 4�� ���� <- 3�� ���� ��
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4��
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4�� <- temp3 (3��)
            // 4�� ��¥ <- 3�� ��¥
            tempStr4 = PlayerPrefs.GetString(3 + "Date");
            PlayerPrefs.SetString(3 + "Date", tempStr3);

            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5�� <- temp4 (4��)
            // 5�� ��¥ <- 4�� ��¥
            PlayerPrefs.SetString(4 + "Date", tempStr4);
        }

        // ���� (4�� < �� ���� < 3��)
        else if (intValue > PlayerPrefs.GetInt(3 + "BestScore")&&intValue< PlayerPrefs.GetInt(2 + "BestScore"))
        {
            // 4�� ���� <- 3�� ���� ��
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4��
            PlayerPrefs.SetInt(3 + "BestScore", intValue); // 4�� <- intValue (��������)
            // 4�� ���� <- 3�� ���� ��
            tempStr4 = PlayerPrefs.GetString(3 + "BestScore");
            PlayerPrefs.SetString(3 + "BestScore", DateTime.Now.ToString("yyyy/M/d h:mm:ss tt"));

            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5�� <- temp4 (4��)
            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetString(4 + "BestScore", tempStr4);
        }

        // ���� (5�� < �� ���� < 4��)
        else if (intValue > PlayerPrefs.GetInt(4 + "BestScore")&&intValue<PlayerPrefs.GetInt(3 + "BestScore"))
        {
            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", intValue); // 5�� <- intValue (��������)
            // 5�� ��¥ <- �� ��¥
            PlayerPrefs.SetString(4 + "Date", DateTime.Now.ToString("yyyy/M/d h:mm:ss tt"));
        }
    }
    #endregion
}