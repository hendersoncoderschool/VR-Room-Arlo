using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOUNSSOUND : MonoBehaviour
{
    AudioSource Audioplayer;
    public AudioClip bounceFX;
    // Start is called before the first frame update
    void Start()
    {
        Audioplayer = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Audioplayer.PlayOneShot(bounceFX, 1f);
    }
}
