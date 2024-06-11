using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource LobbyMusicsource;
    public AudioSource IngameMusicSource;

    public AudioSource dead;

    public AudioSource GameOverSound;

    public AudioSource coinSound;

    public AudioSource attack;

    //public AudioSource ChumBeong;

    public AudioSource FootSound;

    public AudioSource ClickSound;
    public AudioSource OutSound;
    public AudioSource PopUpSound;
    public AudioSource Reset;
    public AudioSource PlayBtn;
    public AudioSource LvUpBtn;

    public AudioSource PamPhaRe;

    public AudioSource SangJeomBGM; // 상점소리

    public AudioSource Siren; // 사이렌 소리

    public AudioSource MulSoRi; // 물 첨벙 소리

    public AudioSource bora;

    static public float ButtonVolume;



    // 볼륨 조절바 (인게임)
    public Slider IngameMusicVolumeSlider;
    public Slider IngameBtnVolumeSlider;
    public Slider IngameFootVolumeSlider; // 발소리
    public Slider IngameSirenVolumeSlider; // 사이렌 소리


    public void Start()
    {
        LoadVolume();
    }


    // 배경음악 조절
    public void SetMusicVolume(float volume) 
    {  
        LobbyMusicsource.volume = volume;
        IngameMusicSource.volume = volume;
        bora.volume = volume;
        SangJeomBGM.volume = volume;

        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    // 효과음 조절
    public void SetButtonVolume(float btnVolume)
    {
        coinSound.volume = btnVolume;
        ClickSound.volume = btnVolume; // 버튼 클릭음
        OutSound.volume = btnVolume;
        PopUpSound.volume = btnVolume;
        Reset.volume = btnVolume;
        PlayBtn.volume = btnVolume;
        GameOverSound.volume = btnVolume;
        LvUpBtn.volume = btnVolume;
        dead.volume = btnVolume;
        MulSoRi.volume = btnVolume;
        attack.volume = btnVolume;
        PamPhaRe.volume = btnVolume;

        PlayerPrefs.SetFloat("BtnVolume", btnVolume);
    }

    // 발소리 조절
    public void FootVolume(float footVolume)
    {
        FootSound.volume = footVolume; // 발소리
        PlayerPrefs.SetFloat("FootVolume", footVolume);
    }

    // 사이렌 소리 조절
    public void SirenVolume(float sirenVolume)
    {
        Siren.volume = sirenVolume;
        PlayerPrefs.SetFloat("SirenVolume", sirenVolume);
    }

    public void LoadVolume()
    {
        // 기본값 0.5를 사용하여 저장된 버튼볼륨을 불러옴
        float MusicSavedVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f); // 배경음
        float BtnSavedVolume = PlayerPrefs.GetFloat("BtnVolume", 0.5f); // 효과음
        float FootSavedVolume = PlayerPrefs.GetFloat("FootVolume", 0.5f); // 발소리
        float SirenSavedVolume = PlayerPrefs.GetFloat("SirenVolume", 0.5f); // 사이렌소리

        // 배경음 조절
        if (IngameMusicVolumeSlider != null)
        {
            IngameMusicVolumeSlider.value = MusicSavedVolume;
        }

        // 효과음 조절
        if (IngameBtnVolumeSlider != null)
        {
            IngameBtnVolumeSlider.value = BtnSavedVolume;
        }

        // 발소리 조절
        if (IngameFootVolumeSlider != null)
        {
            IngameFootVolumeSlider.value = FootSavedVolume;
        }

        // 사이렌 소리 조절
        if (IngameSirenVolumeSlider != null)
        {
            IngameSirenVolumeSlider.value = SirenSavedVolume;
        }
    }


    #region 사운드 재생
    // 공격사운드
    public void attackSound()
    {
        attack.Play();
    }

    public void CoinBtnSound()
    {
       coinSound.Play();
    }

    public void JumpSound()
    {
        FootSound.Play();
    }

    public void ClickBtnSound()
    {
        ClickSound.Play();
    }

    public void OutBtnSound()
    {
        OutSound.Play();
    }

    public void PopUpBtnSound()
    {
        PopUpSound.Play();
    }

    public void ResetBtnSound()
    {
        Reset.Play();
    }

    public void PlayBtnSound()
    {
        PlayBtn.Play();
    }

    public void StopIngameBgm()
    {
        IngameMusicSource.Pause();
    }

    public void StartBgm()
    {
        IngameMusicSource.Play();
    }

    public void LvUpBgm()
    {
        LvUpBtn.Play();
    }
    #endregion
}
