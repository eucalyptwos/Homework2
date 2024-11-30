using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFSM : MonoBehaviour
{
	public enum EnemyState { GoToBase, AttackBase }
	public EnemyState currentState;
	public Transform baseTransform;
	public GameObject playerbase;
	public Sight sightSensor;
	public float baseAttackDistance;
	public int damage;
	private NavMeshAgent agent;
	private float timer;
	
	// Start is called before the first frame update
	private void Awake()
    {
		timer = 0.0f;
		playerbase = GameObject.FindWithTag("PlayerBase");
		baseTransform = playerbase.transform;
		if (baseTransform == null)
		{
			Debug.Log("No base");
		}
		agent = GetComponentInParent<NavMeshAgent>();
		agent.SetDestination(baseTransform.position);
		currentState = EnemyState.GoToBase;
    }
	void GoToBase()
	{

		float distanceToBase = Vector3.Distance(
			transform.position, baseTransform.position);
		if (distanceToBase < baseAttackDistance)
		{
			currentState = EnemyState.AttackBase;
		}
	}

	public float playerAttackDistance;

	void AttackBase()
	{
		if (sightSensor.detectedObject == null)
		{
			currentState = EnemyState.GoToBase;
			return;
		}
		if (timer <= 0.0f)
		{
			timer = 0.1f;
			playerbase.GetComponent<Enemy>().hp -= damage;
			if (playerbase.GetComponent<Enemy>().hp < 1)
			{

				Destroy(playerbase);
				GameObject.FindWithTag("EditorOnly").GetComponent<GameManager>().enemynum = 9999;
			}
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, playerAttackDistance);

		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, baseAttackDistance);
	}
	// Update is called once per frame
	void Update()
    {
		if (currentState == EnemyState.GoToBase)
		{
			GoToBase();
		}
		else if (currentState == EnemyState.AttackBase)
		{
			AttackBase();
		}
		if(timer > 0.0f)
			timer -= Time.deltaTime;
    }
}
