using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaEffectManager : MonoBehaviour
{
    public ParticleSystem particleSysComp;

    public void GachaEffectStart()
    {
        // 파티클 시스템 실행
        particleSysComp.Play();

        // 파티클 시스템 멈춤
        // particleSysComp.Stop();

        // 파티클 시스템 일시정지
        // particleSysComp.Pause();

        // 파티클 시스템 입자가 순간 100개 뿜어져 나옴
        // particleSysComp.Emit(100);
    }

    public void GachaEffectStop()
    {
        // 파티클 시스템 멈춤
        particleSysComp.Stop();
    }
}
