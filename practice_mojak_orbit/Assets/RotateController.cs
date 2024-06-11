using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public GameObject mainLobbyCanvas; // MainLobby Canvas를 참조
    public Rotate rotateScript; // Rotate 스크립트를 참조

    private void Update()
    {
        // Canvas가 활성화되어 있는지 확인
        if (mainLobbyCanvas.activeSelf)
        {
            if (!rotateScript.enabled)
            {
                rotateScript.enabled = true; // Rotate 스크립트 활성화
            }
        }
        else
        {
            if (rotateScript.enabled)
            {
                rotateScript.enabled = false; // Rotate 스크립트 비활성화
            }
        }
    }
}
