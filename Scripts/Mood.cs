using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Mood/Mood")]
public class Mood : ScriptableObject {
    public TimeOfDay timeOfDay;
    public List<MusicTrack> music;
    public List<MoodCondition> conditions = new List<MoodCondition>();
}
