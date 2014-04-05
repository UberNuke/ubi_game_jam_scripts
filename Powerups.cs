using UnityEngine;
using System.Collections;

public class Powerups : MonoBehaviour
{
    public float speed;

    private float moveBoundSize;
    // Use this for initialization
    void Start()
    {
        moveBoundSize = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = -speed * Time.deltaTime;
        transform.Translate(moveX, 0, 0);
    }
}
