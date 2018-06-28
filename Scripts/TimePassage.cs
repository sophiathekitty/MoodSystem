using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePassage : MonoBehaviour {
    public MoodManager moods;
    public FloatVariable timeOfDay;
    public const float SecondsInDay = 60 * 60 * 24;
    public float DayRatio = 24f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        DateTime now = DateTime.Now;
        float secs = (now.Hour * 60 * 60) + (now.Minute * 60) + now.Second;
        float time = ((secs / SecondsInDay) * DayRatio);
        float timeFlat = Mathf.Floor(time);
        timeOfDay.RuntimeValue = time - timeFlat;
    }
}
