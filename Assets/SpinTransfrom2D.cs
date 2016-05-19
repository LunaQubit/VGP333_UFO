using UnityEngine;
using System.Collections;

public class SpinTransfrom2D : MonoBehaviour {

    public float spin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate( 0f, 0f, spin * Time.deltaTime );
	}
}
