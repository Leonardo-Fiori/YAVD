﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(fileName ="NewAudioEffectPlayer", menuName ="YAVD/Audio Effect")]
public class SAudio : ASAudioEvent {
    public AudioClip[] audioClips;
    public float pitchVariation;
    public float volumeVariation;
    

	public override void Play(AudioSource source)
    {
        float basePitch = source.pitch;
        float baseVolume= source.volume;
        if (audioClips.Length == 0) return;
        source.clip = audioClips[Random.Range(0, audioClips.Length)];
        source.pitch += Random.Range(-pitchVariation, +pitchVariation);
        source.volume += Random.Range(-volumeVariation, +volumeVariation);
        source.Play();
        source.pitch = basePitch;
        source.volume = baseVolume;
    }
}
