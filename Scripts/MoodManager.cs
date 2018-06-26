using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Mood/Manager")]
public class MoodManager : ScriptableObject {
    public List<Mood> moods;

    public Mood CurrentMood
    {
        get
        {

            return null;
        }
    }
}
