using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyTimeOfDay : MonoBehaviour {
    public MoodManager moods;
    private Camera _camera;
    private Light _light;
    public bool applyTime = false;
	// Use this for initialization
	void Start () {
        _camera = GetComponent<Camera>();
        _light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        Mood mood = moods.CurrentMood;
        TimeOfDay timeOfDay = mood.timeOfDay;
        if(_camera != null && timeOfDay != null)
            _camera.backgroundColor = timeOfDay.sky.Evaluate(timeOfDay.timeRate);
        if (_light != null && timeOfDay != null)
        {
            _light.color = timeOfDay.light.Evaluate(timeOfDay.timeRate);
            _light.intensity = timeOfDay.intensity.Evaluate(timeOfDay.timeRate);
        }

    }
}
