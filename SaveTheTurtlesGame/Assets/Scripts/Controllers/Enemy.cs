using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable {

	//CharacterStats stats;
	//public RagdollManager ragdoll;

	//void Start ()
	//{
		//stats = GetComponent<CharacterStats>();
		//stats.OnHealthReachedZero += Die;
	//}

	// When we interact with the enemy: We attack it.
	//public override void Interact()
	//{
		//base.Interact ();
		//print ("Interact");
		//CharacterCombat combatManager = Player.instance.playerCombatManager;
		//combatManager.Attack(stats);
	//}

	//void Die() {
	//	ragdoll.transform.parent = null;
	//	ragdoll.Setup ();
	//	Destroy (gameObject);
	//}

}
