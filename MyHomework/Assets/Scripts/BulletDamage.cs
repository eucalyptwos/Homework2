using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
	public int damage;
	private int ek;
	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			other.gameObject.GetComponent<Enemy>().hp -= damage;
			if (other.gameObject.GetComponent<Enemy>().hp < 1)
			{
				ek = GameObject.Find("Objective").GetComponent<ObjectInfo>().enemyKill++;
				if(ek==4)
					GameObject.FindWithTag("EditorOnly").GetComponent<GameManager>().enemynum = -1;
				Destroy(other.gameObject);
			}
			Destroy(gameObject);
		}
		else //if (other.gameObject.tag == "Free")
		{
			if (other.gameObject.GetComponent<Enemy>() != null)
			{
				other.gameObject.GetComponent<Enemy>().hp -= damage;
				if (other.gameObject.GetComponent<Enemy>().hp < 1)
				{
					Destroy(other.gameObject);
				}

				
			}
			Destroy(gameObject);
		}
	}
}
