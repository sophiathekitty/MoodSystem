using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class MoodMusicPlayer : MonoBehaviour {
    public MoodManager moods;
    public AudioMixer mixer;
    private AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!audio.isPlaying)
        {
            // find some mood music to play
            Mood mood = moods.CurrentMood;
            if(mood.music.Count > 0)
            {
                audio.clip = mood.music[Random.Range(0, mood.music.Count - 1)].audioClip;
                audio.loop = false;
                audio.Play();
            }
        }
	}
}
