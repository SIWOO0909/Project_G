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

    public AudioSource jumpSound;

    public AudioSource ClickSound;
    public AudioSource OutSound;
    public AudioSource PopUpSound;
    public AudioSource Reset;
    public AudioSource PlayBtn;
    public AudioSource LvUpBtn;

    public AudioSource bora;

    static public float ButtonVolume;

    public Slider BtnVolumeSlider;
    public Slider MusicVolumeSlider;

    public Slider IngameBtnVolumeSlider;
    public Slider IngameMusicVolumeSlider;

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

        PlayerPrefs.SetFloat("BtnVolume", btnVolume);
    }

    public void LoadVolume()
    {
        // 기본값 0.5를 사용하여 저장된 버튼볼륨을 불러옴
        float BtnSavedVolume = PlayerPrefs.GetFloat("BtnVolume", 0.5f); // 효과음
        float MusicSavedVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f); // 배경음

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



        // 슬라이더 값도 불러온 볼륨으로 설정 // 효과음
        if (BtnVolumeSlider != null)
        {
            BtnVolumeSlider.value = BtnSavedVolume;
            IngameBtnVolumeSlider.value = BtnSavedVolume;
        }

        // 슬라이더 값도 불러온 볼륨으로 설정 // 배경음
        if (BtnVolumeSlider != null)
        {
            MusicVolumeSlider.value = MusicSavedVolume;
            IngameMusicVolumeSlider.value = MusicSavedVolume;
        }

        ClickSoundBug.SetActive(true);
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
