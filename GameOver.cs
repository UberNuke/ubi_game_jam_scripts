using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {


    public GameObject gameOverObj;

	public void StopGame() {
        Time.timeScale = 0;

        gameOverObj.SetActive(true);
        gameOverObj.transform.FindChild("Score Value").guiText.text = "32234";
    }

}
