using UnityEngine;
using System.Collections;

public class BackgroundMove : MonoBehaviour {

    public float speed;


	void Start () {
	
	}
	
	void Update () {
	    transform.Translate(- speed * Time.deltaTime, 0, 0);
	}
}
