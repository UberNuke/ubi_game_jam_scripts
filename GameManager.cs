using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject cioaraPrefab;
    public Transform spawnCioara;
    public int max_no_of_ciori = 10;
    public int difficulty = 0;


    private float cameraSize;
    private int crt_no_of_ciori=0;


	void Start () {
        Screen.SetResolution(700, 700, false);
	    cameraSize = Camera.main.orthographicSize;
        SpawnCiori();
	}
	
	void SpawnPowerUp() {

    }

	
	void SpawnCiori() {
	    for (int i=0; i < max_no_of_ciori; i++) {
            float posY = Random.insideUnitCircle.y * cameraSize;
            Instantiate(cioaraPrefab, new Vector3(spawnCioara.position.x, posY, 0), Quaternion.identity);
            crt_no_of_ciori++;
        }    
	}

    void DecreaseCiori()
    {
        crt_no_of_ciori--;
    }

    void SpawnCioriIfNeeded()
    {
        for (int i=crt_no_of_ciori; i<max_no_of_ciori;i++ )
        {
            float posY = Random.insideUnitCircle.y * cameraSize;
            Instantiate(cioaraPrefab, new Vector3(spawnCioara.position.x, posY, 0), Quaternion.identity);
            crt_no_of_ciori++;
        }
    }
}
