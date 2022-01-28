using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject[] prefab;//生成的物体
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("InstantiateBall", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {


    }
    void InstantiateBall()
    {
        Vector2 objectPosition = Random.insideUnitCircle * 10;
        Vector2 pos = objectPosition.normalized * (13 + objectPosition.magnitude);
        Vector3 pos2 = new Vector3(pos.x, 2, pos.y) + transform.position;
        Instantiate(prefab[Random.Range(0, prefab.Length)], pos2, Quaternion.identity);
    }
}
