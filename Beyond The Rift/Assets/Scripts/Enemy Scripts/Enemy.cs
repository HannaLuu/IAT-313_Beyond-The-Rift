using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public int health = 100;

	public Animator animator;
	public GameObject deathEffect;

	public Transform player;

	public bool isFlipped = false;

	public void TakeDamage(int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

	public void LookAtPlayer()
    {
		Vector3 flipped = transform.localScale;
		flipped.z *= -1f;

		if(transform.position.x > player.position.x && isFlipped)
        {
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = false;
        } else if (transform.position.x < player.position.x && !isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = true;
		}
	}
}
