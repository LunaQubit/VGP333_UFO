using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rigidBody2d;
    private Vector3 lastCheckpoint = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
        lastCheckpoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis( "Horizontal" );
        float v = Input.GetAxis( "Vertical" );

        rigidBody2d.AddForce( new Vector2( h * speed, v * speed ) );
    }

    void OnTriggerEnter2D( Collider2D other )
    {
        if( other.CompareTag( "PickUp" ) )
        {
            other.gameObject.SetActive( false );
        }
        else if( other.CompareTag( "Checkpoint" ) )
        {
            lastCheckpoint = other.transform.position;
        }
    }
}
