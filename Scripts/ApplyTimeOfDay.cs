using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyTimeOfDay : MonoBehaviour {
    public MoodManager moods;
    public FloatVariable time;
    private Camera _camera;
    private Light _light;
    public float fadeRate = 0.01f;
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
            _camera.backgroundColor = Color.Lerp(_camera.backgroundColor,timeOfDay.sky.Evaluate(time.RuntimeValue),fadeRate);
        if (_light != null && timeOfDay != null)
        {
            _light.color = Color.Lerp(_light.color,timeOfDay.light.Evaluate(time.RuntimeValue), fadeRate);
            _light.intensity = Mathf.Lerp(_light.intensity, timeOfDay.intensity.Evaluate(time.RuntimeValue), fadeRate);
        }

    }
}
