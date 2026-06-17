using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderWithPlayer : MonoBehaviour
{
    public GameObject obstacle;
    Rigidbody2D obstacleGG;
    Collider2D obstacleColl;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        obstacleGG = obstacle.GetComponent<Rigidbody2D>();
        obstacleColl = obstacle.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);

            SceneManager.LoadScene(0);
        }
    }
}
