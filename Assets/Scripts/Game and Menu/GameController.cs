using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private AudioClip music;

    private void Awake()
    {
        SoundManager.instance.ChangeBGM(music);
    }
}
