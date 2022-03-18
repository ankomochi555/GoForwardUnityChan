using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //�L���[�u�̈ړ����x
    private float speed = -12;

    //���ňʒu
    private float deadline = -10;


    AudioSource aud;

    GameObject ground;


    // Start is called before the first frame update
    void Start()
    {
        this.ground = GameObject.Find("ground");

        

    }


    //�L���[�u���Փ˂����u�ԁA�����o��
    void OnCollisionEnter2D(Collision2D other)
    {

        //Tag�iGroundTag, CubeTag�Ȃǁj
        Debug.Log("�ՓˁF" + other.gameObject.tag);

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
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);


        //��ʊO�ɏo����j������
        if(transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
    }
}