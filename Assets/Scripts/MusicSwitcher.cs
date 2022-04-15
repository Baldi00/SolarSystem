using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
	public AudioClip clip1;
	public AudioClip clip2;
    AudioSource audioSource;
    private int currentClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentClip = 1;
    } 

    void Update()
    {
        if (!audioSource.isPlaying)
        {
        	if(currentClip == 1)
        	{
            	audioSource.clip = clip2;
            	currentClip = 2;
        	}
            else if(currentClip == 2)
            {
            	audioSource.clip = clip1;
            	currentClip = 1;
            }
            audioSource.Play();
        }
    }
}
