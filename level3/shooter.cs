using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public Transform bulletObj;
    private float interval = 1f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval) {
            timer = 0f;
            Instantiate(bulletObj, transform.position, transform.rotation);
        }
    }
}
