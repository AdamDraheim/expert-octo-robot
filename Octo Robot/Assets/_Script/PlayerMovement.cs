using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Vector3 Velocity;
    private float theta = 0;

	// Use this for initialization
	void Start () {
        Velocity = new Vector3(1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {


        Velocity = new Vector3(Mathf.Sin(theta), 0, Mathf.Cos(theta));
        Velocity *= Time.deltaTime * 5;
        gameObject.transform.position += Velocity;
        if (Input.GetKey(KeyCode.D))
        {
            theta += 5 * Time.deltaTime;
            gameObject.transform.Rotate(Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {

            theta -= 5 * Time.deltaTime;
            gameObject.transform.Rotate(Vector3.left * Time.deltaTime);

        }


    }
}
