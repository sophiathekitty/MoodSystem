using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePassage : MonoBehaviour {
    public MoodManager moods;
    public FloatVariable timeOfDay;
    public const float SecondsInDay = 60 * 60 * 24;
    public float GameDayLasts = 60 * 60;
    public float DeltaPercent
    {
        get
        {
            return (Time.deltaTime / SecondsInDay) * (GameDayLasts / SecondsInDay);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DateTime now = DateTime.Now;
        float secs = (now.Hour * 60 * 60) + (now.Minute * 60) + now.Second;
        timeOfDay.RuntimeValue = secs / SecondsInDay;
        // update time of day
        Debug.Log(timeOfDay.RuntimeValue);
        return;

        timeOfDay.RuntimeValue += DeltaPercent;
        while (timeOfDay.RuntimeValue > 1)
            timeOfDay.RuntimeValue--;

        //moods.ApplyDeltaTime();
	}
}
