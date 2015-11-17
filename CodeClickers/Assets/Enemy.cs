using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public EnemyManager enemyManager;
	public int health;
	public int damage;
	public float interval;

	public void Init(int health, int damage, Image image) {
		this.health = health;
		this.damage = damage;
		GetComponent<Image>().sprite = image.sprite;
	}

	public void ReceiveDamage (int damage) {
		health -= damage;
		if (health <= 0) Die();
	}

	private void Die(){
		print ("Dead");
		GetComponent<Image>().color = Color.clear;
		enemyManager.createEnemy();
		//Next enemy
	}

	void Update () {
	}
}