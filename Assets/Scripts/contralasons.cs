using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contralasons : MonoBehaviour
{
    [SerializeField] private AudioSource MusicaFundo;

    public void Volumes(float volume)
    {
        MusicaFundo.volume = volume;
    }
}
