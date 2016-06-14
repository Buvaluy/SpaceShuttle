using UnityEngine;
using System.Collections;

public class TryThisDoIt : MonoBehaviour {
    
	public Rigidbody rigidbody; // не использую
    public Transform transform; //передвигаю координаты а не задаю вектор направления силы
    public Object shot; //для клонирувания цылиндров
    private float leftRight = 0.0f; //в зависимости от клавиши оно будет увеличиваться или уменьшатся, другими словами менять координаты X
    private float nextFire = 0.0f; // читать соед строку
    private float fireRate = 0.5f;  //как это работате не знаю, подсмотерел в документации
    private float endSpeed = 0.0f;
    private float speedRate = 5.0f;

    public float speed = 0.25f;
    private float nextAsteroid = 0.0f; // читать соед строку
    private float asteroidTimeRate = 0.5f;  //как это работате не знаю, подсмотерел в документации


    public float LeftRight // не уверен что нужно было, но написал
    {
        get
        {
            return leftRight;
        }
        set
        {
            leftRight = value;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (endSpeed < Time.time && endSpeed != 0.0f)
        {
            speed -= 0.5f;
            endSpeed = 0.0f;
        }

        if (Input.GetKey(KeyCode.A) && leftRight >= -7.8f) //проверка на кнопку и ограничение перемещение по левой стороне(край области видимости)
        {
            Object myObject = GameObject.FindWithTag("shieldOnShip");
            leftRight -= speed;
            Vector3 moveLeft = new Vector3(leftRight, -2.5f, 0.0f);
            this.transform.position = moveLeft;
        }//else что бы сразу две кнопки не зажимали
        else if (Input.GetKey(KeyCode.D) && leftRight <= 7.8f) //проверка на кнопку и ограничение перемещение по правой стороне(край области видимости)
        {
            leftRight += speed;
            Vector3 moveRight = new Vector3(leftRight, -2.5f, 0.0f);
            this.transform.position = moveRight;
        }


        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire) //стреляем и задержка перед след выстрелом
        {
            nextFire = Time.time + fireRate; // документация
            Vector3 localPosSetup = transform.localPosition; //берем позиция коробля, что бы пуля вылетела с него.
            localPosSetup.z += 1; //что бы она ввылетала приблизно с носа
            localPosSetup.y -= 0.2f;
            Quaternion rotationSetup = new Quaternion(90.0f, 0.0f, 0.0f, 90.0f); //цылиндр смотрет в вверх, перевернем в сторону полета
            Instantiate(shot, localPosSetup, rotationSetup); //создали копию
        }
        
	}


    void FixedUpdate()
    {
        
        //оно обрабатывает быстрей, но, то ли комп у меня лагает, толи хз чего, у меня оно обраматывает рывками, а в обыном апдейт равномерно.
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "speedTablet" && endSpeed == 0.0f)
        {
            endSpeed = Time.time + speedRate;
            speed += + 0.5f;
            Destroy(other.gameObject);
        }
    }
    
}
