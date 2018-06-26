using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Mood/Condition/Near Point")]
public class NearPoint : MoodCondition {
    private List<NearPointTarget> points = new List<NearPointTarget>();
    public TransformVariable player;
    public void RegisterPoint(NearPointTarget point)
    {
        if (points.Contains(point)) return;
        else points.Add(point);
    }
    public void UnRegisterPoint(NearPointTarget point)
    {
        if (points == null || !points.Contains(point)) return;
        else points.Remove(point);
    }
    public override bool Valid
    {
        get
        {
            foreach(NearPointTarget point in points)
                if(point.near)
                    return true;
            return false;
        }
    }
}
