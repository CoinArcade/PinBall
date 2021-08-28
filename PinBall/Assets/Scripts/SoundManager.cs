using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    public List<AudioSource> audioClips = new List<AudioSource>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

public class AudioSource
{
    public string name;
    public AudioClip audioClip;
}