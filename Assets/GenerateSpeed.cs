using UnityEngine;
using System.Collections;

public class GenerateSpeed : MonoBehaviour {

    public Object speed;
    private float nextShield = 0; // читать соед строку
    private float shieldTimeRate = 0.5f;  //как это работате не знаю, подсмотерел в документации
    // Use this for initialization
    void Start()
    {
        shieldTimeRate = Random.value * 20;
        nextShield = Time.time + shieldTimeRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextShield)
        {
            nextShield = Time.time + shieldTimeRate;
            shieldTimeRate = Random.Range(0, 4);
            Vector3 localPosSetup = transform.localPosition;
            localPosSetup.z += 15;
            localPosSetup.y += 0.5f;
            Quaternion rotationSetup = new Quaternion(90.0f, 0.0f, 0.0f, 90.0f);
            Instantiate(speed, localPosSetup, rotationSetup);
            shieldTimeRate = Random.value * 20;
        }
    }
}
