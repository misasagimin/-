using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    GameObject timerText;
    float time = 90.0f;

	// Use this for initialization
	void Start () {
        this.timerText = GameObject.Find("Time");
	}
	
	// Update is called once per frame
	void Update () {
        this.time -= Time.deltaTime;
        if (time <= 0) SceneManager.LoadScene("meiro o");
        this.timerText.GetComponent<Text>().text =
            this.time.ToString("F1");
        
	}
}
