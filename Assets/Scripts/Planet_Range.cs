using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Range : MonoBehaviour
{
    [SerializeField]
    private float gravityscale;
    [SerializeField]
    private Transform planet_transform;

    int maxscore = 250;

    public void OnTriggerStay2D(Collider2D collision)
    {
        planet_transform.localScale -= new Vector3(1, 1) * Time.deltaTime;
        GameManager.Score++;
        maxscore--;
        if (maxscore <= 0)
            Death();
    }

    private void Death()
    {
        Destroy(transform.parent.gameObject);
    }

    public float GetGravityScale()
    {
        return gravityscale;
    }
}
