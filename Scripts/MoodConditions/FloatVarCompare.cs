using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Mood/Condition/FloatVar Compare")]
public class FloatVarCompare : MoodCondition {
    public FloatVariable A;
    public FloatVariable B;
    public FVCMode mode;
    public enum FVCMode { GreaterThan, Equal, Delta }
    public float delta;


    public override bool Valid
    {
        get
        {
            if (A == null || B == null) return false;
            switch (mode)
            {
                case FVCMode.GreaterThan:
                    return (A.RuntimeValue > B.RuntimeValue);
                case FVCMode.Delta:
                    return (Mathf.Abs(A.RuntimeValue - B.RuntimeValue) < Mathf.Abs(delta));
                case FVCMode.Equal:
                    return (A.RuntimeValue == B.RuntimeValue);
            }

            return false;
        }
    }
}
