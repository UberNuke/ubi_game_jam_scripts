using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    public enum PowerUpType {
        FUEL,
        HEALTH,
        SHIELD
    }

    public PowerUpType type;
    public float spawnRate;

    private Player playerClass;
    private float speed;


	protected void BaseStart () {
	    playerClass = GameObject.Find("Player").GetComponent<Player>();
        speed = GameObject.Find("Background").GetComponent<BackgroundMove>().speed;
	}

	
	protected void BaseUpdate () {
	    // move 
        transform.Translate(-speed * Time.deltaTime, 0, 0);
	}


    virtual public void Activate() {}


    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {

            Destroy(gameObject);
        }
    }

}
