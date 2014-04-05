using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed;
    public float moveBound;
    public float gravity;
    public int difficulty;
    public float fuel;
    public float maxfuel;
    public float fuel_consumption;
    private float moveBoundSize;
    private float counter;
    private bool game_over;

    public GUIText altitudeText;
    public GUIText scoreText;
    public GUIText fuelText;
    public GameManager GM;


	void Start () {
	    moveBoundSize = Camera.main.orthographicSize;

        ////////////INITIALIZARE DE CONSTANTE
        gravity = (float)-0.03;
        difficulty = 0;
        counter = 0;
        fuel = 50;
        maxfuel = 100;
        game_over = false;
        fuel_consumption = (float)0.1;
    }
	
	void Update () {
	    //float moveX = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveY = speed * Input.GetAxis("Vertical") * Time.deltaTime;

        

        if (fuel <= 0 && moveY > 0)
            moveY = 0;

        if (moveY > 0)
            fuel -= fuel_consumption;

        moveY = calculate_gravity(moveY);

        transform.Translate(0, moveY, 0);

        if (fuel < 0)
            Debug.Log("Out of fuel");

        Vector3 pos = transform.position;
        float toClamp = moveBoundSize - moveBound;
        pos.x = Mathf.Clamp(pos.x, -toClamp, toClamp);
        pos.y = Mathf.Clamp(pos.y, -toClamp, toClamp);

        if (pos.y < -6.999) game_over = true;
        transform.position = pos;


        if (game_over) Debug.Log("GAME OVEEEEER!!!!!");

        counter++;
        if (counter==10000)
        {
            counter = 0;
            difficulty++;
            Debug.Log("am crescut dificultatea la " + difficulty.ToString());
        }

        // update gui text
        altitudeText.text = "" + transform.position.y;
        scoreText.text = "" + GM.score;
        fuelText.text = "" + fuel;

	}

    float calculate_gravity(float init_y)
    {
        var calculate = init_y + gravity;
        return calculate;
    }
}