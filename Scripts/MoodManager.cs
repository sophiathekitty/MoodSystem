using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Mood/Manager")]
public class MoodManager : ScriptableObject {
    public List<Mood> moods;
    public Mood CMood;

    public Mood CurrentMood
    {
        get
        {
            foreach(Mood mood in moods)
            {
                if (mood.Valid)
                {
                    CMood = mood;
                    return mood;
                }
                    
            }
            return null;
        }
    }


    public void ApplyDeltaTime()
    {

    }

}
