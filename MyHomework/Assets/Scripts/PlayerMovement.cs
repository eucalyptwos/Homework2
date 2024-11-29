using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 movementValue;
    private float lookValue;
    public float speed;
    public float rotationSpeed;
    public int ammoType;
	private Rigidbody rb;
	// Start is called before the first frame update
	void Start()
    {
        ammoType = 0;
    }
    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
		rb = GetComponent<Rigidbody>();
	}

	public void OnMove(InputValue value)
	{
        movementValue = value.Get<Vector2>()*speed;
	}
    public void OnLook(InputValue value) {
        lookValue = value.Get<Vector2>().x*rotationSpeed;
    }
	// Update is called once per frame
	public void OnChangeAmmo1(InputValue value)
	{
		ammoType = 0;
	}
	public void OnChangeAmmo2(InputValue value)
	{
		ammoType = 1;
	}
	public void OnBlink(InputValue value)
	{
		var dir = Vector3.forward;

		gameObject.transform.Translate(dir * speed*3);
		Debug.Log("transport");
	}
    //바라보는 방향으로 b누르면 이동 추가.
	void Update()
    {
		rb.AddRelativeForce(
		movementValue.x * Time.deltaTime*speed, 0, movementValue.y * Time.deltaTime*speed);

		rb.AddRelativeTorque(0, lookValue * Time.deltaTime*rotationSpeed, 0);
		if (Input.GetKey(KeyCode.LeftAlt))
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.Confined;
		}else
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}
	}
}
