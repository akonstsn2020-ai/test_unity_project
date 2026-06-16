using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almas : MonoBehaviour
{
    public GameObject almas;
    Rigidbody gg;


    // Start is called before the first frame update
    void Start()
    {
        gg = GetComponent<Rigidbody>();

        InvokeRepeating(nameof(Spawn), 3f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
        GameObject t_almas = Instantiate(almas, pos, Quaternion.identity);

        Destroy(t_almas, 5f);
    }

    
}
