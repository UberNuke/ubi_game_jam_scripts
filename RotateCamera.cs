using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

	private float angle = 30;
    private float rotationTime = 0;

    public bool canRotate = false;
    public float maxSpeed;
    public float minDuration;
    public float maxDuration;


	void Start () {
	
	}
	
	void Update () {
        if (rotationTime <= 0) {
            rotationTime = Random.Range(minDuration, maxDuration);
            //Debug.Log(rotationTime);

            angle = (Random.value - 0.5f) * maxSpeed;
            //Debug.Log("change camera rotation");
        }

        if (Input.GetKeyDown(KeyCode.R))
            canRotate = !canRotate;

        if (canRotate)
	        transform.Rotate( Vector3.forward, angle * Time.deltaTime);
        //else
           // transform.rotation = Quaternion.identity;

        rotationTime -= Time.deltaTime;
	}
}
