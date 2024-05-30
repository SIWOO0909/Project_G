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
    "https://docs.google.com/spreadsheets/d/1z7UZzpB2PKaaPLIW4Y8rFDShH3QTwbKjA06Fqoqz0Ls/export?format=tsv&range=A2:D12";

    IEnumerator Start()
    {
        // UnityWebRequest 인스턴스 리소스 해제를 위한 using
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
        // columns의 뜻은 열입니다.
        // row는 행이겠죠? 그쵸?
        // Split함수로 데이터 처리하기
        string[] rows = sheetData.Split('\n');
        string[] columns = rows[0].Split('\t'); // A2:D12 기준 1행에 있는 모든 값을 셀 단위로 (탭 단위)로 자른다.
        string[] columns2 = rows[1].Split('\t'); // A2:D12 기준 2행을 있는 모든 값을 셀 단위로 (탭 단위)로 자른다.
        string[] columns3 = rows[2].Split('\t'); 
        string[] columns4 = rows[3].Split('\t');
        string[] columns5 = rows[4].Split('\t');
        string[] columns6 = rows[5].Split('\t');
        string[] columns7 = rows[6].Split('\t');
        string[] columns8 = rows[7].Split('\t');
        string[] columns9 = rows[8].Split('\t');
        string[] columns10 = rows[9].Split('\t');
        string[] columns11 = rows[10].Split('\t');


        // 첫번째 행의 아이템 이름과 Description을 출력한다.
        // displayText.text = columns[1] + "\n" + columns[2];
        displayText.text = columns[3].ToString(); // 윤일동 차렷 
        // columns[2].ToString(); // 위글리 확률 0.3
        // columns2[2].ToString(); // 박스 확률 0.2

        gachaManager.w = float.Parse(columns[2]); // 위글리 확률 0.3
        gachaManager.b = float.Parse(columns2[2]); // 박스 확률 0.2
        gachaManager.k = float.Parse(columns3[2]);
        gachaManager.wr = float.Parse(columns4[2]);
        gachaManager.wo = float.Parse(columns5[2]);
        gachaManager.wy = float.Parse(columns6[2]);
        gachaManager.wb = float.Parse(columns7[2]);
        gachaManager.wpu = float.Parse(columns8[2]);
        gachaManager.wpi = float.Parse(columns9[2]);
        gachaManager.wg = float.Parse(columns10[2]);
        gachaManager.ww = float.Parse(columns11[2]);
    }
}
