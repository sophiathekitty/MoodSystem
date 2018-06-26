using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearPointTarget : MonoBehaviour {
    public NearPoint nearPoint;

    public bool near;
    private void OnEnable()
    {
        nearPoint.RegisterPoint(this);
    }
    private void OnDisable()
    {
        nearPoint.UnRegisterPoint(this);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            near = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            near = false;
    }
}
