using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    #region Good-Bye Declaration (�¹��� ����)
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
        #region ���� �ý���
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

        // score +10
        int a = (scoreValueSaved / 10) * 10;
        #endregion

        if (abc > 0)
        {
            RankSys(a);
        }

        #region ���
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