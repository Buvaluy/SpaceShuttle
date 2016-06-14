using UnityEngine;
using System.Collections;

public class GoingShield : MonoBehaviour {

    public Object shield;
    public Transform transformShield;

    private int randomPositionX;
	// Use this for initialization
	void Start () {
        randomPositionX = Random.Range(-7, 7);
	}
	
	// Update is called once per frame
	void Update () {
        this.transformShield.position = new Vector3(randomPositionX, this.transformShield.localPosition.y, this.transformShield.localPosition.z - 0.15f);
        //this.transformAsteroid.RotateAround(new Vector3(randomRotateX, randomRotateY, randomRotateZ), angelRotate);
        //transformShield.RotateAround(new Vector3(randomRotateX, randomRotateY, randomRotateZ), randomAngelRotate);
        if (this.transformShield.localPosition.z < -10)
        {
            Destroy(this.gameObject);
        }
	}
}
