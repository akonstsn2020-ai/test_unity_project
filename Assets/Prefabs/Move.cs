using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject obstacle;
    Rigidbody2D gg;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        gg = GetComponent<Rigidbody2D>();
        pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
    }

    // Update is called once per frame
    void Update()
    {
        gg.transform.position = Vector3.MoveTowards(gg.transform.position, pos, 2f * Time.deltaTime);

        if (Vector3.Distance(gg.transform.position, pos) < 0.1f)
        {
            ChooseNewPoint();
        }

        void ChooseNewPoint()
        {
            pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
        }

    }

}
