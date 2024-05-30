using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource LobbyMusicsource;
    public AudioSource IngameMusicSource;


    public AudioSource GameOverSound;

    public AudioSource coinSound;

    public AudioSource jumpSound;

    public AudioSource ClickSound;
    public AudioSource OutSound;
    public AudioSource PopUpSound;
    public AudioSource Reset;
    public AudioSource PlayBtn;
    public AudioSource LvUpBtn;

    public void SetMusicVolume(float volume) 
    {  
        LobbyMusicsource.volume = volume;
        IngameMusicSource.volume = volume;
    }

    public void SetButtonVolume(float volume)
    {
        coinSound.volume = volume;
        jumpSound.volume = volume;
        ClickSound.volume = volume;
        OutSound.volume = volume;
        PopUpSound.volume = volume;
        Reset.volume = volume;
        PlayBtn.volume = volume;
        GameOverSound.volume = volume;
        LvUpBtn.volume = volume;
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
