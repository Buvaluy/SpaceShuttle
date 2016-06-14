using UnityEngine;
using System.Collections;


public class GoingAsteroidLittle : MonoBehaviour {

    public Object asteroid;
    public Transform transformAsteroid;
    private float randomRotateX;
    private float randomRotateY;
    private float randomRotateZ;
    private float randomAngelRotate;
    private int randomPositionX;

	// Use this for initialization
	void Start () {
        randomRotateX = (float)Random.Range(0, 45);
        randomRotateY = (float)Random.Range(0, 45);
        randomRotateZ = (float)Random.Range(0, 45);
        randomAngelRotate = Random.value/10;
        randomPositionX = Random.Range(-7, 7);
        if (randomAngelRotate > 0.1f)
        {
            randomAngelRotate -= 0.05f;
        }
	}
	
	// Update is called once per frame
	void Update () {
        this.transformAsteroid.position = new Vector3(randomPositionX, this.transformAsteroid.localPosition.y, this.transformAsteroid.localPosition.z - 0.15f);
        //this.transformAsteroid.RotateAround(new Vector3(randomRotateX, randomRotateY, randomRotateZ), angelRotate);
        transformAsteroid.RotateAround(new Vector3(randomRotateX, randomRotateY, randomRotateZ), randomAngelRotate);
        if (this.transformAsteroid.localPosition.z < -10)
        {
            Destroy(this.gameObject);
        }
	}
}
