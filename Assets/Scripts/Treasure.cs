using UnityEngine;
using System.Collections;

public class Treasure : MonoBehaviour
{

    public int value = 10;
    public GameObject explosionPrefab;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(GameManager.instance != null)
            {
                GameManager.instance.Collect(value);
                AchievementManager.instance.CheckAchievements();
            }
            if (explosionPrefab != null)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
