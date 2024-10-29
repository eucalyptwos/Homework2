using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] float moveRate;
    [SerializeField] float speed;
	float rotateSpeed = 100;
	private Rigidbody rb;
	Vector3 moveVec;
	Vector3 lookVec;
	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
		InvokeRepeating("Rotate", 0, moveRate);
	}
	private void Rotate()
	{
		float x = Random.Range(-1, 1);
		float y = Random.Range(-1, 1);
		moveVec = new  Vector3(x, 0, y);
		lookVec = new Vector3(x, 0, y);
	}

	// Update is called once per frame
	void Update()
    {
		var dir = Vector3.back;
		rb.MovePosition(rb.position + transform.TransformDirection(-dir) * (speed * Time.deltaTime));
		//gameObject.transform.Translate(moveVec * speed *Time.deltaTime);
		Quaternion targetRotation = Quaternion.LookRotation(lookVec);
		Quaternion rotateAmount = Quaternion.RotateTowards(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
		rb.rotation = rotateAmount;

	}
}
