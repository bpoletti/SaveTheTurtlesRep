using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyStats : CharacterStats
{

	public override void Die()
	{
		base.Die ();

		//add ragdoll effect / death animation

		//Destroy(object);
	}
}

