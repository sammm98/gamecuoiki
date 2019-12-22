using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
	public float planeSpeed;
	public AudioSource bulletSound;

	private Rigidbody2D myBody;
	private Animator animator;
	private bool canShoot = true;
	[SerializeField]
	private GameObject bullet;
	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
		bulletSound = GetComponent<AudioSource> ();
		animator = GetComponent<Animator> ();
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.Space)) {
        	if (canShoot){
        		StartCoroutine (Shoot ());
				bulletSound.Play();
				// animator.Play("planeBullet", 0, 1f);
        	}
        }
    }
    void FixedUpdate() {
    	PlaneMovement();
    }

    void PlaneMovement() {
    	float xAxis = Input.GetAxisRaw("Horizontal") * planeSpeed;
    	float yAxis = Input.GetAxisRaw("Vertical") * planeSpeed;
    	myBody.velocity = new Vector2(xAxis, yAxis);
    }
    IEnumerator Shoot() {
    	canShoot = false;
    	Vector3 temp = transform.position;
		Vector3 temp2 = transform.position;
		Vector3 temp3 = transform.position;
    	temp.y += 0.6f;
   		Instantiate(bullet, temp, Quaternion.identity);
    	yield return new WaitForSeconds(0.2f);
    	canShoot = true;
    }
}
