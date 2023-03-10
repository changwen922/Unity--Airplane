using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo2 : MonoBehaviour
{
    public float maxTime = 24;
    private float timer = 0;
    public GameObject ufo;
    public float height = 3;



    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("Update", 12, 3);
        //GameObject newseagull = Instantiate(seagull);
        //newseagull.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newufo = Instantiate(ufo);
            newufo.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newufo, 15);
            timer = 21;

        }
        timer += Time.deltaTime;

    }
}