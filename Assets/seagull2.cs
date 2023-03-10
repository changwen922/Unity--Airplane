using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seagull2 : MonoBehaviour
{
    public float maxTime = 12;
    private float timer = 0;
    public GameObject seagull;
    public float height = 2;



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
            GameObject newseagull = Instantiate(seagull);
            newseagull.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newseagull, 15);
            timer = 9;

        }
        timer += Time.deltaTime;

    }
}
