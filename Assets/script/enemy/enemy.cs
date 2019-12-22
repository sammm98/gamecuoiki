using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public AudioSource egg;
	public float enemySpeed;
	private Rigidbody2D myBody;
	[SerializeField]
	private GameObject bullet;

	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
        egg = GetComponent<AudioSource> ();
	}
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyShoot()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() {
    	myBody.velocity = new Vector2(0f, -enemySpeed);
    }
    IEnumerator EnemyShoot() {
    	yield return new WaitForSeconds(Random.Range (1f, 3f));
    	Vector3 temp = transform.position;
    	temp.y -= 0.5f;
    	Instantiate(bullet, temp, Quaternion.identity);
    	StartCoroutine(EnemyShoot()); 
    }
    void OnTriggerEnter2D (Collider2D target) {
        if (target.tag == "Player") {
            egg.Play();
            Destroy(target.gameObject);
            Score.scoreValue = 0;
            GamePlayController.instance.PlaneDiedShowPanel();
        }
        if (target.tag == "Boder") {
            Destroy(gameObject);
        }
    }
}
