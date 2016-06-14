using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

    public Transform transformShot;
    public Rigidbody rigidbodyShot;
    private Vector3 location;

	// Use this for initialization
	void Start () {
        //rigidbodyShot.AddForce(transformShot.forward * 2);// хотел сделать ограничение на дистанцию полета, не получилось
	}
	
	// Update is called once per frame
	void Update () {
        //просто пуля движется вперед
        this.transformShot.position = new Vector3(this.transformShot.localPosition.x, this.transformShot.localPosition.y, this.transformShot.localPosition.z + 0.4f);
        if (this.transformShot.localPosition.z > 22)
        {
            Destroy(this.gameObject);
        }
	}
}
