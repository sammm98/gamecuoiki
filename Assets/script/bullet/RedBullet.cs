using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour
{
	public float speed;
	private Rigidbody2D myBody;
    public AudioSource egg;
	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
        egg = GetComponent<AudioSource> ();
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate() {
    	myBody.velocity = new Vector2(0f, -speed);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D (Collider2D target) {
        if (target.tag == "Player") {
            egg.Play();
            Destroy(target.gameObject);
            Score.scoreValue = 0;
            GamePlayController.instance.PlaneDiedShowPanel();
            // Application.LoadLevel("MainMenu");
        }
        if (target.tag == "Boder") {
            Destroy(gameObject);
        }
    }
}
