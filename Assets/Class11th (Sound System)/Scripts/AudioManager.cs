using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSours;

    public void Listener(AudioClip adioClip)
    {
        audioSours.PlayOneShot(adioClip);
    }
}
