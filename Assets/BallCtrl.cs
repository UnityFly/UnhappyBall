using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCtrl : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)||Input.touchCount>0) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 30), ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D other) {
        SceneManager.LoadScene("menu");
    }
}
