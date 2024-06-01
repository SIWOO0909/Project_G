using UnityEngine;

public class Show : MonoBehaviour
{
    // 활성화할 오브젝트를 드래그 앤 드롭으로 할당할 수 있게끔 public으로 선언합니다.
    public GameObject objectToActivate;

    // 현재 오브젝트가 비활성화될 때 호출됩니다.
    private void OnDisable()
    {
        // 활성화할 오브젝트가 null이 아닌지 확인합니다.
        if (objectToActivate != null)
        {
            // 지정된 오브젝트를 활성화합니다.
            objectToActivate.SetActive(true);
        }
        else
        {
            Debug.LogWarning("objectToActivate가 할당되지 않았습니다.");
        }
    }
}
