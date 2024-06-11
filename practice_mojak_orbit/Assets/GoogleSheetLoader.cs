using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class GoogleSheetLoader : MonoBehaviour
{
    string sheetData;
    public Text displayText;
    const string googleSheetURL = 
    "https://docs.google.com/spreadsheets/d/1z7UZzpB2PKaaPLIW4Y8rFDShH3QTwbKjA06Fqoqz0Ls/export?format=tsv&range=A2:D13";

    IEnumerator Start()
    {
        // UnityWebRequest �ν��Ͻ� ���ҽ� ������ ���� using
        using (UnityWebRequest www = UnityWebRequest.Get(googleSheetURL))
        {
            yield return www.SendWebRequest();

            if (www.isDone)
                sheetData = www.downloadHandler.text;
        }

        DisplayText();
    }

    private void DisplayText()
    {
        // columns�� ���� ���Դϴ�.
        // row�� ���̰���? ����?
        // Split�Լ��� ������ ó���ϱ�
        string[] rows = sheetData.Split('\n');
        string[] columns = rows[0].Split('\t'); // A2:D12 ���� 1�࿡ �ִ� ��� ���� �� ������ (�� ����)�� �ڸ���.
        string[] columns2 = rows[1].Split('\t'); // A2:D12 ���� 2���� �ִ� ��� ���� �� ������ (�� ����)�� �ڸ���.
        string[] columns3 = rows[2].Split('\t'); 
        string[] columns4 = rows[3].Split('\t');
        string[] columns5 = rows[4].Split('\t');
        string[] columns6 = rows[5].Split('\t');
        string[] columns7 = rows[6].Split('\t');
        string[] columns8 = rows[7].Split('\t');
        string[] columns9 = rows[8].Split('\t');
        string[] columns10 = rows[9].Split('\t');
        string[] columns11 = rows[10].Split('\t');
        string[] columns12 = rows[11].Split('\t');


        // ù��° ���� ������ �̸��� Description�� ����Ѵ�.
        // displayText.text = columns[1] + "\n" + columns[2];
        displayText.text = columns[3].ToString(); // ���ϵ� ���� 
        //displayText.text = columns11[2].ToString(); // ���ϵ� ���� 
        // columns[2].ToString(); // ���۸� Ȯ�� 0.3
        // columns2[2].ToString(); // �ڽ� Ȯ�� 0.2

        gachaManager.w = float.Parse(columns[2]); // ���۸� Ȯ�� 0.3
        gachaManager.b = float.Parse(columns2[2]); // �ڽ� Ȯ�� 0.2
        gachaManager.k = float.Parse(columns3[2]);
        gachaManager.wr = float.Parse(columns4[2]);
        gachaManager.wo = float.Parse(columns5[2]);
        gachaManager.wy = float.Parse(columns6[2]);
        gachaManager.wb = float.Parse(columns7[2]);
        gachaManager.wpu = float.Parse(columns8[2]);
        gachaManager.wpi = float.Parse(columns9[2]);
        gachaManager.wg = float.Parse(columns10[2]);
        gachaManager.ww = float.Parse(columns11[2]);
        gachaManager.hotDog = float.Parse(columns12[2]); // �ֵ��� Ȯ��
    }
}
