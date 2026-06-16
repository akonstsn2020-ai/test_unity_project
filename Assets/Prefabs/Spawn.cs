using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject orol1;
    public GameObject orol2;

    Rigidbody2D rb1, rb2;

    // Start is called before the first frame update
    void Start()
    {
        rb1 = orol1.GetComponent<Rigidbody2D>();
        rb2 = orol2.GetComponent<Rigidbody2D>();

        InvokeRepeating(nameof(Spawn1), 1f, 2.5f);
        InvokeRepeating(nameof(Spawn2), 1f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn1()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
        GameObject orol = Instantiate(orol1, pos , Quaternion.identity);
        Destroy(orol, 10f);
    }

    void Spawn2()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
        GameObject orol = Instantiate(orol2, pos, Quaternion.identity);
        Destroy(orol, 10f);
    }
}
