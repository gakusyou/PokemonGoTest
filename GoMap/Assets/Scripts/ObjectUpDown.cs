using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectUpDown : MonoBehaviour
{
    float timer;
	// Use this for initialization
	void Start ()
    {
        Invoke("Delete", 10);
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(Vector3.Distance(transform.position, PlayerController.playerInstance.transform.position));
        timer += Time.deltaTime;
        if (timer < 1)
        {
            gameObject.transform.Translate(transform.up * Time.deltaTime);
        }
        else if (timer > 1 && timer < 2)
        {
            gameObject.transform.Translate(-transform.up * Time.deltaTime);
        }
        else
        {
            timer = 0;
        }
	}
    void Delete()
    {
        Destroy(gameObject);
    }
}
