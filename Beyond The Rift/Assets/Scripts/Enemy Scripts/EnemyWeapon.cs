using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    //mayhaps RP effect how much damage enemies do as well?
    public int attackDamage = 10;
    public float attackRange = 0.5f;
    public LayerMask playerLayer;

    public Transform attackPoint;

    //public Vector3 attackOffset;
    //public float attackRange = 1f;
    //public LayerMask attackMask;

    public void Attack()
    {
        Collider2D colInfo = Physics2D.OverlapCircle(attackPoint.position, attackRange, playerLayer);
        if (colInfo != null)
        {
            colInfo.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        }
        //Vector3 pos = transform.position;
        //pos += transform.right * attackOffset.x;
        //pos += transform.up * attackOffset.y;

        //Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        //if(colInfo != null)
        //{
        //    colInfo.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        //}
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
