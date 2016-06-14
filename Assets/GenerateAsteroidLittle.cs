using UnityEngine;
using System.Collections;

public class GenerateAsteroidLittle : MonoBehaviour {

    public Object asteroidLittle;
    private float nextAsteroid = 0; // читать соед строку
    private float asteroidTimeRate = 0.5f;  //как это работате не знаю, подсмотерел в документации
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextAsteroid)
        {
            nextAsteroid = Time.time + asteroidTimeRate;
            asteroidTimeRate = Random.Range(0, 4);
            Vector3 localPosSetup = transform.localPosition;
            localPosSetup.z += 15;
            localPosSetup.y += 0.5f;
            Quaternion rotationSetup = new Quaternion(90.0f, 0.0f, 0.0f, 90.0f);
            Instantiate(asteroidLittle, localPosSetup, rotationSetup);
        }
	}
}
