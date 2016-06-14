using UnityEngine;
using System.Collections;

public class DestroyAsteroidWhenHeCatchShield : MonoBehaviour {
    public Object partitionDestroyAsteroidOnShield;
    public Transform transformShield;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "asteroid_cube_little")
        {
           // Vector3 localPosSetup = transformShield.localPosition;
            Vector3 localPosSetup = other.gameObject.transform.localPosition;
            Quaternion rotationSetup = new Quaternion(90.0f, 0.0f, 0.0f, -90.0f);
            Instantiate(partitionDestroyAsteroidOnShield, localPosSetup, rotationSetup);
            Destroy(other.gameObject);
        }
    }
}
