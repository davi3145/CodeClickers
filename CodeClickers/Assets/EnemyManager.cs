using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour {

	public Enemy currentEnemy;
	public Image[] images;

	public void ApplyDamage (int damage) {
		currentEnemy.ReceiveDamage(damage);
	}

	public void createEnemy() {
		print ("New enemy");
		currentEnemy.Init(5, 1, images[Random.Range(0, images.Length)]);
	}

	void Start () {
		print ("Test");
	}

	void Update () {
	
	}
}
