using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tmp = GameObject.Find("Sphere").transform.position;
        GameObject.Find("Sphere").transform.position = new Vector3(tmp.x, tmp.y, tmp.z);
        transform.position = new Vector3(tmp.x, tmp.y, tmp.z);
	}
}
