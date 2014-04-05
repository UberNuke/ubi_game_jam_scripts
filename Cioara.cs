using UnityEngine;
using System.Collections;

public class Cioara : MonoBehaviour {

    public float maxSpeed;
    private float velocityX;

	void Start () {
	    velocityX = - Random.value * maxSpeed;
	}
	
	void Update () {
	    transform.Translate(velocityX, 0, 0);
	}

    void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        if (other.tag != "Player")
            Destroy(other.gameObject);
        Debug.Log("coliziune");
    }
}
