using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {

    public GameObject Player1;
    public GameObject Player2;

    public float accel;
    public float rotateSpeed;

    private Rigidbody P1RB;
    private Rigidbody P2RB;
    // Use this for initialization
    void Start () {
        P1RB = Player1.GetComponent<Rigidbody>();
        P2RB = Player2.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            P1RB.AddRelativeForce(transform.forward * accel, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Player1.transform.Rotate(new Vector3(0, -rotateSpeed, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player1.transform.Rotate(new Vector3(0, rotateSpeed, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            P1RB.AddRelativeForce(-transform.forward * accel, ForceMode.Impulse);
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            P2RB.AddRelativeForce(transform.forward * accel, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player2.transform.Rotate(new Vector3(0, -rotateSpeed, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player2.transform.Rotate(new Vector3(0, rotateSpeed, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            P2RB.AddRelativeForce(-transform.forward * accel, ForceMode.Impulse);
        }
    }
}
