using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCtrl : MonoBehaviour {
    public GameObject GameCtrl;
    private float MoveSpeed;
    private GameObject PipeDown,PipeUp;
	// Use this for initialization
	void Start () {
        MoveSpeed = GameCtrl.GetComponent<GameCtrl>().MoveSpeed;
        PipeDown = transform.FindChild("Rect").gameObject;
        PipeUp = transform.FindChild("Rect (1)").gameObject;

    }

    // Update is called once per frame
    void Update () {
        transform.Translate(new Vector2(-MoveSpeed * Time.deltaTime, 0));
        if (transform.position.x < -83)
        {
            int rand = Random.Range(0, 100);
            float r = rand;

            transform.Translate(new Vector2(2f * 82.3f, 0));
            transform.Translate(new Vector2(0, -transform.position.y - 20));
            transform.Translate(new Vector2(0, rand / 6));
            PipeDown.transform.Translate(new Vector2(-62f + (PipeUp.transform.position.y - PipeDown.transform.position.y),0));
            r= Random.Range(0, 100);
            PipeDown.transform.Translate(new Vector2(-r / 50,0 ));

        }
    }
}
