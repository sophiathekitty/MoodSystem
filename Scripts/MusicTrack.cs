using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Mood/Music Track")]
public class MusicTrack : ScriptableObject {
    public string artists;
    public string title;
    public string url;
    public AudioClip audioClip;
}
