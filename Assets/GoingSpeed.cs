using UnityEngine;
using System.Collections;

public class GoingSpeed : MonoBehaviour {

    public Transform transformSpeed;
    private int randomPositionX;
    // Use this for initialization
    void Start()
    {
        randomPositionX = Random.Range(-7, 7);
	}
	
	// Update is called once per frame
	void Update () {
        this.transformSpeed.position = new Vector3(randomPositionX, this.transformSpeed.localPosition.y, this.transformSpeed.localPosition.z - 0.15f);
        //this.transformAsteroid.RotateAround(new Vector3(randomRotateX, randomRotateY, randomRotateZ), angelRotate);
        //transformShield.RotateAround(new Vector3(randomRotateX, randomRotateY, randomRotateZ), randomAngelRotate);
        if (this.transformSpeed.localPosition.z < -10)
        {
            Destroy(this.gameObject);
        }
	}
}
