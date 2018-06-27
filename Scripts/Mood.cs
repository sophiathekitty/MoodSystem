using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Mood/Mood")]
public class Mood : ScriptableObject {
    public TimeOfDay timeOfDay;
    public List<MusicTrack> music = new List<MusicTrack>();
    public List<MoodCondition> conditions = new List<MoodCondition>();
    public bool isValid;
    public bool Valid
    {
        get
        {
            foreach (MoodCondition cond in conditions)
                if (cond.Valid)
                {
                    isValid = cond.Valid;
                    return cond.Valid;
                }
            isValid = (conditions.Count == 0);
            return (conditions.Count == 0);
        }
    }

}
