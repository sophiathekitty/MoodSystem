using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoodCondition : ScriptableObject {
    public abstract bool Valid { get; }
    public bool isValid;
}
