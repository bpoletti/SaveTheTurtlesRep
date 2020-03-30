using System.Collections;
using UnityEngine;
using UnityEngine.AI;

//[RequireComponent(typeof(CharacterCombat))]
public class Enemy_Controller : MonoBehaviour {

	public float lookRadius = 10f;
	Transform target;
	NavMeshAgent agent;
	//CharacterCombat combatManager;


	void Start() {
		target = PlayerManager.instance.turtle.transform;
		agent = GetComponent<NavMeshAgent> ();
		//combatManager = GetComponent<CharacterCombat>();
	}

	void Update() {
		float distance = Vector3.Distance (target.position, transform.position);

		if (distance <= lookRadius) {
			agent.SetDestination (target.position);

			if (distance <= agent.stoppingDistance) {
				// Attack the target
				//combatManager.Attack(Player.instance.playerStats);
				FaceTarget ();
			}
			}

		}

	void FaceTarget ()
	{
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation (new Vector3 (direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp (transform.rotation, lookRotation, Time.deltaTime * 5f);
	}

	void OnDrawGizmosSelected () {
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, lookRadius);
	}
}


