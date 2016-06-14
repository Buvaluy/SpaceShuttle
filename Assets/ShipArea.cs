using UnityEngine;
using System.Collections;

public class ShipArea : MonoBehaviour {
    public Object partitionDestroyShip;
    public Object shieldShip;
    public Transform transformShip;
    private float timeToShieldOff = 0.0f; // читать соед строку
    private float duringShield = 5.0f;  //как это работате не знаю, подсмотерел в документации

    private bool shieldOnOff = false;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > timeToShieldOff && timeToShieldOff != 0)
        {
            print("4");
            // документация
            shieldOnOff = false;
        }
	}


    void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if (other.tag == "asteroid_cube_little" && !shieldOnOff)
        {
            print("1");
            Vector3 localPosSetup = transformShip.localPosition;
            Quaternion rotationSetup = new Quaternion(90.0f, 0.0f, 0.0f, -90.0f);
            Instantiate(partitionDestroyShip, localPosSetup, rotationSetup);
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }
        else if (other.tag == "asteroid_cube_little" && shieldOnOff)
        {
            print("2");
            Vector3 localPosSetup = transformShip.localPosition;
            Quaternion rotationSetup = new Quaternion(90.0f, 0.0f, 0.0f, -90.0f);
            Instantiate(partitionDestroyShip, localPosSetup, rotationSetup);
            Destroy(other.gameObject);
        }



        if (other.tag == "shieldOn")
        {
            Object myObject = GameObject.FindWithTag("shieldOnShip");
            Destroy(myObject);
            print("3");
            shieldOnOff = true;
            timeToShieldOff = Time.time + duringShield;
            Vector3 localPosSetup = transformShip.localPosition;
            Quaternion rotationSetup = new Quaternion(90.0f, 0.0f, 0.0f, -90.0f);
            Instantiate(shieldShip, localPosSetup, rotationSetup);
            Destroy(other.gameObject);
        }


        
        
    }

}
