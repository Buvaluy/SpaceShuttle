using UnityEngine;
using System.Collections;

public class TimeShieldOut : MonoBehaviour {

    private float timeToShieldOff = 0.0f; // читать соед строку
    private float duringShield = 8.0f;  //как это работате не знаю, подсмотерел в документации
    public Transform transformShield;
    private float leftRight = 0.0f;
    private float speed = 0.25f;
    private TryThisDoIt tryThis;


	// Use this for initialization
	void Start () {
        timeToShieldOff = Time.time + duringShield;
        leftRight = transformShield.localPosition.x;
        tryThis = GetComponent<TryThisDoIt>();
        tryThis.speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
        //GameObject ship = GameObject.FindGameObjectWithTag("ship");
        print("a"+this.speed);
        this.speed = tryThis.speed;
        print("b"+speed);
        if (Input.GetKey(KeyCode.A) && leftRight >= -7.8f) //проверка на кнопку и ограничение перемещение по левой стороне(край области видимости)
        {
            
            //Object myObject = GameObject.FindWithTag("shieldOnShip");
            leftRight -= speed;
            Vector3 moveLeft = new Vector3(leftRight, -2.5f, 0.0f);
            this.transformShield.position = moveLeft;
        }//else что бы сразу две кнопки не зажимали
        else if (Input.GetKey(KeyCode.D) && leftRight <= 7.8f) //проверка на кнопку и ограничение перемещение по правой стороне(край области видимости)
        {
            leftRight += speed;
            Vector3 moveRight = new Vector3(leftRight, -2.5f, 0.0f);
            this.transformShield.position = moveRight;
        }

        if (Time.time > timeToShieldOff)
        {
            
            Destroy(gameObject);
        }
	}


    
}
