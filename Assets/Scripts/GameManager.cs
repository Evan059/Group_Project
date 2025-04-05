using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Enemy prefabs
    public GameObject enemyBasicPrefab;
    public GameObject enemyFlowPrefab;
    public GameObject enemyAttackPrefab;
    
    public GameObject cloudPrefab;

    public GameObject PlayerPrefab;

    public TextMeshProUGUI livesText;

    public float horizontalScreenSize;
    public float verticalScreenSize;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        horizontalScreenSize = 10f;
        verticalScreenSize = 6.5f;
        score = 0;
        Instantiate(PlayerPrefab, transform.position, Quaternion.identity);
        CreateSky();
        InvokeRepeating("CreateEnemyBasic", 1, 2);
        InvokeRepeating("CreateEnemyFlow", 1.5f, 3f);
        InvokeRepeating("CreateEnemyAttack", 3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemyBasic()
    {
        Instantiate(enemyBasicPrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    void CreateEnemyFlow()
    {
        // Flow enemies only spawn on the right side of the screen
        Instantiate(enemyFlowPrefab, new Vector3(Random.Range(0, 9f), 6.5f, 0), Quaternion.identity);
    }

    void CreateEnemyAttack()
    {
        // Attack enemies spawn at the right edge of the screen and move to the left
        Instantiate(enemyAttackPrefab, new Vector3(9.5f, Random.Range(2f, 5f), 0), Quaternion.identity);
    }
    void CreateSky()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(cloudPrefab, new Vector3(Random.Range(-horizontalScreenSize, horizontalScreenSize), Random.Range(-verticalScreenSize, verticalScreenSize), 0), Quaternion.identity);
        }

    }
    public void AddScore(int earnedScore)
    {
        score = score + earnedScore;
    }

    public void ChangeLivesText (int currentLives)
    {
        livesText.text = "Lives:" + currentLives;
    }
}
