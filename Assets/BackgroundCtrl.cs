using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCtrl : MonoBehaviour {
    public float MoveSpeed;
    public GameObject GameCtrl;
	// Use this for initialization
	void Start () {
        MoveSpeed = GameCtrl.GetComponent<GameCtrl>().MoveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(-MoveSpeed*Time.deltaTime,0));
        if (transform.position.x < -83) {
            transform.Translate(new Vector2(2*82.3f, 0));
        }
    }

}
