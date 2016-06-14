using UnityEngine;
using System.Collections;

public class DeletePartitionDestroyAsterodFromScene : MonoBehaviour {
    private float timeToDestroy = 5;
    private float destroyAfter;
	// Use this for initialization
	void Start () {
        destroyAfter = Time.time + timeToDestroy; // документация
	}
	
	// Update is called once per frame
	void Update () {
        if (destroyAfter < Time.time)
        {
            Destroy(gameObject);
        }
	}


    
}
