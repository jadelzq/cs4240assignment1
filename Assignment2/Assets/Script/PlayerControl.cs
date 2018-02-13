using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    //default unity3D function to detect collision
    void OnTriggerEnter(Collider other)
    {
        //if there is collision
        if (other.gameObject.CompareTag("Pick Up"))
        {
            //become invisible
            other.gameObject.SetActive(false);
        }
    }
}
