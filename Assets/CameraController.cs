using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    Vector3 offset;
    public Transform player;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.position + offset;
	}
}
