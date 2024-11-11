using UnityEngine;

public class Soundplayer : MonoBehaviour
{
    public AudioClip[] soundArrey;
    AudioSource audioSource;
    //０は正解　１は不正解

    public void PlaySound(int Number)
    {
        if(audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        audioSource.PlayOneShot(soundArrey[Number]);
    }

}
