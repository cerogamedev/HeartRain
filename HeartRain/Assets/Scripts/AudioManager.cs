using UnityEngine;

public class AudioManager : MonoSingleton<AudioManager>
{
    public AudioClip ButtonEffect;

    public AudioClip HeartCollected;
    public AudioClip GameOver;

    public void ButtonPlaySound()
    {
        AudioSource.PlayClipAtPoint(ButtonEffect, Camera.main.transform.position);
    }
    public void HeartPlaySound()
    {
        AudioSource.PlayClipAtPoint(HeartCollected, Camera.main.transform.position);
    }
    public void GameOverPlaySound()
    {
        AudioSource.PlayClipAtPoint(GameOver, Camera.main.transform.position);
    }
}