using UnityEngine;
using System.Collections;

public class BackgroundBarrier : MonoBehaviour {

    private float cameraSize;
	
	void Start () {
	    cameraSize = Camera.main.orthographicSize;
	}
	
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        Transform background = other.transform.parent;
        background.Translate( new Vector3(cameraSize * 2, 0, 0) );
    }
}
