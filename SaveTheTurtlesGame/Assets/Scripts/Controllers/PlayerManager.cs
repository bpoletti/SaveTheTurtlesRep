using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

	#region Singleton

	public static PlayerManager instance;

	void Awake () {
		instance = this;
	}
	
	#endregion

	public GameObject turtle;

	//void Start() {
	//	playerStats.OnHealthReachedZero += Die;
	//}

	//public CharacterCombat playerCombatManager;
	//public PlayerStats playerStats;


	//void Die() {
	//	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	//}
}
