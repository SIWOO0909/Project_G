using UnityEngine;

public class AnotherScript : MonoBehaviour
{
    // DestroyExternalObject 스크립트에 대한 참조
    public DestroyExternalObject destroyManager;

    private void Update()
    {
        // 임의의 조건에서 게임 오브젝트를 파괴 (예: 스페이스 키를 눌렀을 때)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            destroyManager.DestroyTargetObject();
        }
    }
}