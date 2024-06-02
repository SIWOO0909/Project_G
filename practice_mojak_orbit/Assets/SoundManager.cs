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

    public AudioSource jumpSound;

    public AudioSource ClickSound;
    public AudioSource OutSound;
    public AudioSource PopUpSound;
    public AudioSource Reset;
    public AudioSource PlayBtn;
    public AudioSource LvUpBtn;

    public AudioSource SangJeomBGM; // 상점소리

    public AudioSource Siren; // 사이렌 소리

    public AudioSource MulSoRi; // 물 첨벙 소리

    public AudioSource bora;

    static public float ButtonVolume;

    // 볼륨 조절 바 (로비)
    public Slider BtnVolumeSlider;
    public Slider MusicVolumeSlider;

    // 볼륨 조절바 (인게임)
    public Slider IngameBtnVolumeSlider;
    public Slider IngameMusicVolumeSlider;
    public Slider IngameSirenVolumeSlider; // 사이렌

    public GameObject ClickSoundBug;


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
        jumpSound.volume = btnVolume;
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

        PlayerPrefs.SetFloat("BtnVolume", btnVolume);
    }

    public void SirenVolume(float sirenVolume)
    {
        Siren.volume = sirenVolume;
        PlayerPrefs.SetFloat("SirenVolume", sirenVolume);
    }

    public void LoadVolume()
    {
        // 기본값 0.5를 사용하여 저장된 버튼볼륨을 불러옴
        float BtnSavedVolume = PlayerPrefs.GetFloat("BtnVolume", 0.5f); // 효과음
        float MusicSavedVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f); // 배경음
        float SirenSavedVolume = PlayerPrefs.GetFloat("SirenVolume", 0.5f); // 사이렌음

        // 불러온 볼륨을 적용 // 효과음
        coinSound.volume = BtnSavedVolume;
        jumpSound.volume = BtnSavedVolume;
        ClickSound.volume = BtnSavedVolume; // 버튼 클릭음
        OutSound.volume = BtnSavedVolume;
        PopUpSound.volume = BtnSavedVolume;
        Reset.volume = BtnSavedVolume;
        PlayBtn.volume = BtnSavedVolume;
        GameOverSound.volume = BtnSavedVolume;
        LvUpBtn.volume = BtnSavedVolume;
        dead.volume = BtnSavedVolume;

        // 불러온 볼륨을 적용 // 배경음
        LobbyMusicsource.volume = MusicSavedVolume;
        IngameMusicSource.volume = MusicSavedVolume;
        bora.volume = MusicSavedVolume;

        // 불러온 볼륨을 적용 // 사이렌
        Siren.volume = SirenSavedVolume;

        // 슬라이더 값도 불러온 볼륨으로 설정 // 효과음
        if (BtnVolumeSlider != null)
        {
            BtnVolumeSlider.value = BtnSavedVolume;
            IngameBtnVolumeSlider.value = BtnSavedVolume;
        }

        // 슬라이더 값도 불러온 볼륨으로 설정 // 배경음
        if (BtnVolumeSlider != null)
        {
            MusicVolumeSlider.value = MusicSavedVolume; // 로비
            IngameMusicVolumeSlider.value = MusicSavedVolume; // 인게임
        }

        // 슬라이더 값도 불러온 볼륨으로 설정 // 사이렌음
        if (IngameSirenVolumeSlider != null)
        {
            IngameSirenVolumeSlider.value = SirenSavedVolume;//인게임
        }

        // 버튼 소리 판넬 재활성화
        ClickSoundBug.SetActive(true);
    }

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
        jumpSound.Play();
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
}
