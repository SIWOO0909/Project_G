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

    // ���� ����
    static public int abc = 0; // ��ũ �ý��� �۵� ���� abc���� 1�϶� ����
    static public int a = 0;
    public static int scoreValueSaved;
    private int scoreValue;
    private int minsu1;
    private float previousXPosition;
    public float NowScoreSlowEffect;
    public float BestScoreSlowEffect;
    //float text_score = 0f;

    // �����Լ�
    private void Start()
    {
        abc = 0;
        previousXPosition = trackedObject.position.x;
        minsu1 = 0;
        //text_score = 0;
    }

    // ������Ʈ �Լ�
    public void Update()
    {

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

        // top5���� ��� �Լ��Դϴ�.
        RankSys(a);

        // �÷��̾� ����� TOP5 ��ŷ�ý��� ����
        if (abc > 0)
        {
            RankSys(a);
        }

        // ���� 100���� 1���� ����
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

        // ���ӿ���UI ���� ���� ���� �ý���
        //float floata = a;
        //floata += 2000 * Time.deltaTime * 0.8f;
        //int aaa = (int)Mathf.Round(floata);
        //gameOverTotalScoreTxt.text = aaa.ToString(); // ���ӿ���UI�� ���� ���� ���
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

        // ���ӿ����� ����Ʈ ���� ���� �ý���
        float floatb = PlayerPrefs.GetInt(0 + "BestScore");
        floatb += 2000 * Time.deltaTime * NowScoreSlowEffect;
        int bbb = (int)Mathf.Round(floatb);
        gameOverBestScoreTxt.text = bbb.ToString(); // ���ӿ���UI����Ʈ ���� ���

        // 
        if (a > 100)
        {
            float floatc = PlayerPrefs.GetInt("scoreCoins");
            floatc += 2000 * Time.deltaTime * NowScoreSlowEffect;
            int ccc = (int)Mathf.Round(floatc);
            gameOverEarnCoinTxt.text = ccc.ToString();
        }

        // Top 5 ���
        one.text = PlayerPrefs.GetInt(0 + "BestScore").ToString();
        two.text = PlayerPrefs.GetInt(1 + "BestScore").ToString();
        three.text = PlayerPrefs.GetInt(2 + "BestScore").ToString();
        four.text = PlayerPrefs.GetInt(3 + "BestScore").ToString();
        five.text = PlayerPrefs.GetInt(4 + "BestScore").ToString();
    }
    

    #region ��ŷ �ʱ�ȭ ��ư
    public void ResetRankings()
    {
        PlayerPrefs.SetInt(0 + "BestScore",5);
        PlayerPrefs.SetInt(1 + "BestScore",4);
        PlayerPrefs.SetInt(2 + "BestScore",3);
        PlayerPrefs.SetInt(3 + "BestScore",2);
        PlayerPrefs.SetInt(4 + "BestScore",1);
    }
    #endregion

    // void �Լ� (int�� ������)
    // int�� �������� ���� �ٸ� ���� ����� �Լ�
    static public void RankSys(int intValue)
    {
        #region �μ�
        // ���� ���� = intValue
        // 1�� ���� (��� ����) = PlayerPrefs.GetInt(0 + "BestScore") = �ְ� ���� (��� ����)
        // 2�� ���� (��� ����) = PlayerPrefs.GetInt(1 + "BestScore")
        // 3�� ���� (��� ����) = PlayerPrefs.GetInt(2 + "BestScore")
        // 4�� ���� (��� ����) = PlayerPrefs.GetInt(3 + "BestScore")
        // 5�� ���� (��� ����) = PlayerPrefs.GetInt(4 + "BestScore")

        // �ӽ� ���� ���� ���� 
        // temp�� �ӽö�� ��
        int temp = 0;
        int temp2 = 0;
        int temp3 = 0;
        int temp4 = 0;


        // ���� (�������� > �ְ�����) �϶�
        if (intValue > PlayerPrefs.GetInt(0 + "BestScore"))
        {
            // 1�� ���� <- ���� ���� ��
            temp = PlayerPrefs.GetInt(0 + "BestScore"); // temp <- 1��
            PlayerPrefs.SetInt(0 + "BestScore", intValue); // 1�� <- ���� ����

            // 2�� ���� <- 1�� ���� ��
            temp2 = PlayerPrefs.GetInt(1 + "BestScore"); // temp2 <- 2��
            PlayerPrefs.SetInt(1 + "BestScore", temp); // 2�� <- temp (1��)

            // 3�� ���� <- 2�� ���� ��
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3��
            PlayerPrefs.SetInt(2 + "BestScore", temp2); // 3�� <- temp2 (2��)

            // 4�� ���� <- 3�� ���� ��
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4��
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4�� <- temp3 (3��)

            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5�� <- temp4 (4��)
        }

        // ���� (�������� > 2������ && �������� < 1������) �ϋ�
        else if (intValue > PlayerPrefs.GetInt(1 + "BestScore") && intValue < PlayerPrefs.GetInt(0 + "BestScore"))
        {
            // 2�� ���� <- 1�� ���� ��
            temp2 = PlayerPrefs.GetInt(1 + "BestScore"); // temp2 <- 2��
            PlayerPrefs.SetInt(1 + "BestScore", intValue); // 2�� <- intValue (��������)

            // 3�� ���� <- 2�� ���� ��
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3��
            PlayerPrefs.SetInt(2 + "BestScore", temp2); // 3�� <- temp2 (2��)

            // 4�� ���� <- 3�� ���� ��
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4��
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4�� <- temp3 (3��)

            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5�� <- temp4 (4��)
        }

        // ���� (�������� > 3������ && �������� < 2������) �϶�
        else if (intValue > PlayerPrefs.GetInt(2 + "BestScore")&&intValue<PlayerPrefs.GetInt(1 + "BestScore"))
        {
            // 3�� ���� <- 2�� ���� ��
            temp3 = PlayerPrefs.GetInt(2 + "BestScore"); // temp3 <- 3��
            PlayerPrefs.SetInt(2 + "BestScore", intValue); // 3�� <- intValue (��������)

            // 4�� ���� <- 3�� ���� ��
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4��
            PlayerPrefs.SetInt(3 + "BestScore", temp3); // 4�� <- temp3 (3��)

            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5�� <- temp4 (4��)
        }

        // ���� (�������� > 4������ && �������� < 3������) �϶�
        else if (intValue > PlayerPrefs.GetInt(3 + "BestScore")&&intValue< PlayerPrefs.GetInt(2 + "BestScore"))
        {
            // 4�� ���� <- 3�� ���� ��
            temp4 = PlayerPrefs.GetInt(3 + "BestScore"); // temp4 <- 4��
            PlayerPrefs.SetInt(3 + "BestScore", intValue); // 4�� <- intValue (��������)

            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", temp4); // 5�� <- temp4 (4��)
        }

        else if (intValue > PlayerPrefs.GetInt(4 + "BestScore")&&intValue<PlayerPrefs.GetInt(3 + "BestScore"))
        {
            // 5�� ���� <- 4�� ���� ��
            PlayerPrefs.SetInt(4 + "BestScore", intValue); // 5�� <- intValue (��������)
        }

        #endregion

        
    }

}