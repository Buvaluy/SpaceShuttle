using UnityEngine;
using System.Collections;

public class DestroyArea : MonoBehaviour
{
    public Object partitionDestroyAsteroid;
    public Transform transformPulay;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "asteroid_cube_little")
        {
            Vector3 localPosSetup = transformPulay.localPosition;
            Quaternion rotationSetup = new Quaternion(90.0f, 0.0f, 0.0f, -90.0f);
            Instantiate(partitionDestroyAsteroid, localPosSetup, rotationSetup);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
    }
}
