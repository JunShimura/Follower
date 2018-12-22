using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

    Rigidbody rigidbody;
    public float speed = 100.0f;

    // Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    Vector3 moveVector=new Vector3();
    void Update () {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");
        rigidbody.AddForce(moveVector * speed);
	}
}
