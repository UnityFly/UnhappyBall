using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour {

	void Start () {
		
	}
    public void GoToGame() {
        SceneManager.LoadScene("level1");

    }
	void Update () {
		
	}
}
