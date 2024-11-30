using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GamePlayManager : MonoBehaviour
{
	private float timer = 0.0f;
	private bool started;
	private int time = 4;
	public GameObject canva;
	public int enemynum;
	// Start is called before the first frame update
	void Start()
	{
		started = true;
		enemynum = 1;
	}

	// Update is called once per frame
	void Update()
	{
		Debug.Log(enemynum);
		if (started)
		{
			timer += Time.deltaTime;
			if (timer > 4.99f)
			{
				GameObject.Find("Fox(Player)").GetComponent<PlayerMovement>().enabled = true;
				GameObject.Find("Fox(Player)").GetComponent<PlayerShoot>().enabled = true;
				canva.SetActive(true);
				started = false;
				timer = 0.0f;
				enemynum --;
			}
		}
		if (enemynum >= 999)
		{
			GameObject.Find("Fox(Player)").GetComponent<Animator>().SetBool("Defeat", true);
			GameObject.Find("Fox(Player)").GetComponent<PlayerMovement>().enabled = false;
			GameObject.Find("Fox(Player)").GetComponent<PlayerShoot>().enabled = false;
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.Confined;
			timer += Time.deltaTime;
			if (timer > time)
				SceneManager.LoadScene("LoseScene");
		}
		if (enemynum == 0)
		{
			SceneManager.LoadScene("WinScene");
		}
	}
}
