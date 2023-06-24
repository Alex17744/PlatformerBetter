using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum Powerups
    {
        Speed,
        attackDistance,
        DashOP
    }
    public Powerups type = Powerups.Speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);

            switch (type)
            {
                case Powerups.Speed:
                    collision.GetComponent<Player>().speed *= 2;    
                    break;
                case Powerups.attackDistance:
                    collision.GetComponent<Player>().attackDistance *= 2;
                    break;
                case Powerups.DashOP:
                    collision.GetComponent<Player>().DashOP *= 2;
                    break;
            }
        }
    }
}
