using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public EnemyManager enemyManager;
	public int clickDamage = 1;
	public int damagePerSecond = 0;

	private IEnumerator Start() {
		while(true) {
			yield return new WaitForSeconds(1);
			GiveDPS();
		}
	}

	public void GiveClickDamage () {
		enemyManager.ApplyDamage(clickDamage);
	}

	private void GiveDPS () {
		enemyManager.ApplyDamage(damagePerSecond);
	}

	void Update () {
	
	}
}
