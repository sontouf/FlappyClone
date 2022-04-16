using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(-1.5f, 5.5f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }
}
