using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadline = -10;


    AudioSource aud;

    GameObject ground;


    // Start is called before the first frame update
    void Start()
    {
        this.ground = GameObject.Find("ground");

        

    }


    //キューブが衝突した瞬間、音を出す
    void OnCollisionEnter2D(Collision2D other)
    {

        //Tag（GroundTag, CubeTagなど）
        Debug.Log("衝突：" + other.gameObject.tag);

        if (this.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }
        if (this.gameObject.tag == "GroundTag")
        {
            GetComponent<AudioSource>().Play();
        }
    }


    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);


        //画面外に出たら破棄する
        if(transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
    }
}
