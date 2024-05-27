using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour
{
    public Animator animator; // Animator를 연결할 변수

    // 버튼이 클릭될 때 호출될 함수
    public void AttackAnimation()
    {
        if (animator != null)
        {
            StartCoroutine(PlayAnimationWithDelay());//지연 후 애니메이션 실행
        }
        else
        {
            Debug.LogWarning("Animator가 설정되지 않았습니다.");
        }
    }

    // 일정 시간이 지난 후 애니메이션을 실행하는 코루틴
    private IEnumerator PlayAnimationWithDelay()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetTrigger("Effect");
    }
}
