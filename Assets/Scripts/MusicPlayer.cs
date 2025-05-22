using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{

    public AudioClip[] clips;
    private AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
    }

    
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
    }

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0,clips.Length)];
    }
}
