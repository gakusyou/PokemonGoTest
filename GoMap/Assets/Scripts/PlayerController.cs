using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    public static PlayerController playerInstance;//单例
	// Use this for initialization
	void Start ()
    {
        playerInstance = this;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        gameObject.transform.position += new Vector3(h, 0, v) * 40 * Time.deltaTime;
        if (v != 0 || h != 0)
        {
            anim.SetBool("Walk", true);
            Quaternion tempAngle = Quaternion.LookRotation(new Vector3(h, 0, v), Vector3.up);//由物体的方向以及Up向量，确定目标角度
            gameObject.transform.rotation = Quaternion.RotateTowards(gameObject.transform.rotation, tempAngle, 10);//从原来角度转向目标点，每次转deltaAngle
        }
        else if (v == 0 && h == 0)
        {
            anim.SetBool("Walk", false);
        }
	}
}
