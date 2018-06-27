using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePassage : MonoBehaviour {
    public MoodManager moods;
    public FloatVariable timeOfDay;
    public const float SecondsInDay = 60 * 60 * 24;
    public float DeltaPercent
    {
        get
        {
            return Time.deltaTime / SecondsInDay;
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // update time of day
        timeOfDay.RuntimeValue += DeltaPercent;
        while (timeOfDay.RuntimeValue > 1)
            timeOfDay.RuntimeValue--;

        moods.ApplyDeltaTime();
	}
}
