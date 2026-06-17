using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    public GameObject Almas;
    AudioSource sound;
    int coinsScore = 0; 

    // Start is called before the first frame update
    void Start()
    {
        sound = Almas.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Almas"))
        {
            sound.Play();
            Destroy(collision.gameObject);
        }
    }
}
