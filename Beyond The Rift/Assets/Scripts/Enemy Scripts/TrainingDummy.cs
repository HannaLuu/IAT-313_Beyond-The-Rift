using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using UnityEngine.SceneManagement;

public class TrainingDummy : MonoBehaviour
{

    public int health = 100;

    public GameObject deathEffect;

    public Flowchart myFlowchart;

    private void Start()
    {
        // varChangerTest = GetComponent<VarChangerTest>();
    }

    // private void Update()
    // {
    //     allEnemiesDead();
    // }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
            Debug.Log("Killed: " + DummyCounter.dummiesKilled);
            myFlowchart.ExecuteBlock("Increment RP");
        }
    }

    void Die()
    {
        DummyCounter.dummiesKilled = DummyCounter.dummiesKilled += 1;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
