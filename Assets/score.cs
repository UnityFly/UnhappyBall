using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {
     int s=0;
    public GameObject t;
	// Use this for initialization
	void Start () {
	}
	

	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        s++;
        t.SendMessage("setScore",s/2);
    }
}
