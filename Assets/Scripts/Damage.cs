using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{

    public float damageAmount = 10.0f;
    public bool damageOnTrigger = true;
    public bool damageOnCollision = false;
    public bool continuousDamage = false;
    public float continuousTimeBetweenHits = 0;
    public bool destroySelfOnImpact = false;
    public float delayBeforeDestroy = 0.0f;
    public GameObject explosionPrefab;
    private float savedTime = 0;

    void OnTriggerEnter(Collider collision)
    {
        if (damageOnTrigger)
        {
            if (this.tag == "PlayerBullet" && collision.gameObject.tag == "Player")
            {
                return;
            }
            if (collision.gameObject.GetComponent<Health>() != null)
            {
                collision.gameObject.GetComponent<Health>().ApplyDamage(damageAmount);
                if (destroySelfOnImpact)
                {
                    Destroy(gameObject, delayBeforeDestroy);
                }
                if (explosionPrefab != null)
                {
                    Instantiate(explosionPrefab, transform.position, transform.rotation);
                }
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (damageOnCollision)
        {
            if (this.tag == "PlayerBullet" && collision.gameObject.tag == "Player")
            {
                return;
            }
            if (collision.gameObject.GetComponent<Health>() != null)
            {
                collision.gameObject.GetComponent<Health>().ApplyDamage(damageAmount);
                if (destroySelfOnImpact)
                {
                    Destroy(gameObject, delayBeforeDestroy);
                }
                if (explosionPrefab != null)
                {
                    Instantiate(explosionPrefab, transform.position, transform.rotation);
                }

            }

        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (continuousDamage)
        {
            if (collision.gameObject.tag == "Player" && collision.gameObject.GetComponent<Health>() != null)
            {
                if (Time.time - savedTime >= continuousTimeBetweenHits)
                {
                    savedTime = Time.time;
                    collision.gameObject.GetComponent<Health>().ApplyDamage(damageAmount);
                }
            }
        }
    }
}
