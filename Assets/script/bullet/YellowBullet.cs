using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBullet : MonoBehaviour
{
	public float speed;
    public AudioSource chicken;
	private Rigidbody2D myBody;

	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
        chicken = GetComponent<AudioSource> ();
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate() {
    	myBody.velocity = new Vector2(0f, speed);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D (Collider2D target) {
        if (target.tag == "Enemy") {
            chicken.Play();
            Destroy(target.gameObject);
            Destroy(gameObject);
            Score.scoreValue += 5;
            
        }
        if (target.tag == "Boder") {
            Destroy(gameObject);
        }
    }
}
