using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public int enemynum;
	// Start is called before the first frame update
	void Start()
	{
		enemynum = 0;
	}

	// Update is called once per frame
	void Update()
	{
		Debug.Log(enemynum);
		if (enemynum >= 10)
		{
			SceneManager.LoadScene("LoseScene");
		}
		if (enemynum == 0)
		{
			SceneManager.LoadScene("WinScene");
		}
	}
}

