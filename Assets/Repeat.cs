using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour {
    public float a = 3.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float MovePos = Mathf.Repeat( a*Time.time, transform.localScale.x);
        transform.position = Vector3.right * MovePos;
    }
}
