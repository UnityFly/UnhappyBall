using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void setScore(int x) {
        GetComponent<Text>().text = "Score:" + x;
            }

    // Update is called once per frame
    void Update () {
		
	}
}
