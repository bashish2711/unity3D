using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public enum ConnectionState
// {
//     WAIT,
//     DISCOVER,
//     CONNECTED,
//     TERMINATED
// }
//public ConnectionState connectionState = ConnectionState.WAIT;

public class Cube : MonoBehaviour
{
	public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
       moveSpeed = 1;
       transform.position = new Vector3(0.0f, 1f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(Input.GetAxis("Horizontal"), 1f, 0.0f);
        //transform.Translate(moveSpeed*Input.GetAxis("Horizontal")* Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")* Time.deltaTime) ;
    }
}
