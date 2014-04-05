using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject cioaraPrefab;
    public Transform spawnCioara;

    private float cameraSize;


	void Start () {
        Screen.SetResolution(700, 700, false);
	    cameraSize = Camera.main.orthographicSize;
        SpawnCiori();
	}

    void SpawnPowerUp() {

    }
	
	void SpawnCiori() {
	    for (int i=0; i < 10; i++) {
            float posY = Random.insideUnitCircle.y * cameraSize;
            Instantiate(cioaraPrefab, new Vector3(spawnCioara.position.x, posY, 0), Quaternion.identity);
        }
	}
}
