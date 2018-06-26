using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Mood/Condition/FloatVar Range")]
public class FloatVarRange : MoodCondition {
    public FloatVariable A;
    public float min = 0f;
    public float max = 1f;
    public FVCMode mode;
    public enum FVCMode { Between, BellowMax, AboveMin }
    public override bool Valid
    {
        get
        {
            if (A == null) return false;
            switch (mode)
            {
                case FVCMode.AboveMin:
                    return (A.RuntimeValue > min);
                case FVCMode.BellowMax:
                    return (A.RuntimeValue < max);
                case FVCMode.Between:
                    return (A.RuntimeValue > min && A.RuntimeValue < max);
            }

            return (A.RuntimeValue > min && A.RuntimeValue < max);
        }
    }
}
