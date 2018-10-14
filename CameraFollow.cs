using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float speed;
    public GameObject player;
    public bool rotate = true;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (rotate) {
            Quaternion turn = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * speed, Vector3.up);
            offset = turn * offset;
        }

        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform);
	}
}
