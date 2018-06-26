using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Mood/Time of Day")]
public class TimeOfDay : ScriptableObject {
    public static float time = 0.0f;
    [Range(0f,1f)]
    public float timeRate = 0.0f;
    public Gradient sky;
    public Gradient light;
    public AnimationCurve intensity;
}
