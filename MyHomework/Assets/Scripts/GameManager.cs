using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private float timer=0.0f;
	private bool started = true;
	private int time = 4;
	public GameObject canva;
	public int enemynum;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (started)
		{
			timer += Time.deltaTime;
			Debug.Log(timer);
			if (timer > 4.99f)
			{
				GameObject.Find("Fox(Player)").GetComponent<PlayerMovement>().enabled = true;
				GameObject.Find("Fox(Player)").GetComponent<PlayerShoot>().enabled = true;
				canva.SetActive(true);
				started = false;
				timer = 0.0f;
			}
		}
		Debug.Log(enemynum);
		if (enemynum >= 999)
		{
			GameObject.Find("Fox(Player)").GetComponent<Animator>().SetBool("Defeat", true);
			GameObject.Find("Fox(Player)").GetComponent<PlayerMovement>().enabled = false;
			GameObject.Find("Fox(Player)").GetComponent<PlayerShoot>().enabled = false;
			timer += Time.deltaTime;
			if (timer > time)
				SceneManager.LoadScene("LoseScene");
		}
		if (enemynum == -1)
		{
			SceneManager.LoadScene("WinScene");
		}
	}
}

