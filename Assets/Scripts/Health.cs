using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Health : MonoBehaviour
{
    
    public enum deathAction {loadLevelWhenDead,doNothingWhenDead};
    public float healthPoints = 1f;
    public float respawnHealthPoints = 1f;
    public int numberOfLives = 1;
    public bool isAlive = true;
    public GameObject explosionPrefab;
    public deathAction onLivesGone = deathAction.doNothingWhenDead;
    public string LevelToLoad = "";
    private Vector3 respawnPosition;
    private Quaternion respawnRotation;

    void Start()
    {
        respawnPosition = transform.position;
        respawnRotation = transform.rotation;
        if (LevelToLoad == "")
        {
            LevelToLoad = SceneManager.GetActiveScene().name;
        }
    }

    
    void Update()
    {
        if (healthPoints <= 0)
        {
            numberOfLives--;
            if (explosionPrefab != null)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }
            if (numberOfLives > 0)
            {
                transform.position = respawnPosition;
                transform.rotation = respawnRotation;
                healthPoints = respawnHealthPoints;
            }
            else
            {
                isAlive = false;
                switch (onLivesGone)
                {
                    case deathAction.loadLevelWhenDead:
                        SceneManager.LoadScene(LevelToLoad);
                        break;
                    case deathAction.doNothingWhenDead:
                        Debug.Log("Game Over");
                        break;
                }
                Destroy(gameObject);
            }
        }
    }

    public void ApplyDamage(float amount)
    {
        healthPoints = healthPoints - amount;
    }

    public void ApplyHealth(float amount)
    {
        healthPoints = healthPoints + amount;
    }

    public void ApplyBonusLife(int amount)
    {
        numberOfLives = numberOfLives + amount;
    }

    public void UpdateRespawn(Vector3 newRespawnPosition, Quaternion newRespawnRotation)
    {
        respawnPosition = newRespawnPosition;
        respawnRotation = newRespawnRotation;
    }
}
