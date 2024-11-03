using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerBall : MonoBehaviour
{
    public float jumpPower = 30;
    public int itemCount = 0;
    public GameManagerLogic manager;
    AudioSource audio;
    bool isJumping;
    Rigidbody rigid;

    
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        isJumping = false;
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            isJumping = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);

        }
        else if(other.tag == "Point")
        {
            if (itemCount == manager.totalItemCount)
            {
                //Finish!
                if (manager.stage == 0)
                {
                    SceneManager.LoadScene(1);
                    manager.stage += 1;
                }
                else
                {
                    SceneManager.LoadScene(manager.stage+1);
                    manager.stage += 1;

                }
            }
            else
            {
                //Restart...
                SceneManager.LoadScene(manager.stage);
            }
        }
    }
}
