using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour,Damagable {

    PlayerLife playerLife;

    public void DealDamage(int Damage)
    {
        playerLife.takeDamage(Damage);
    }

    // Use this for initialization
    void Start () {
		playerLife = GetComponent<PlayerLife>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
