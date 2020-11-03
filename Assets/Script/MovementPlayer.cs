using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class MovementPlayer : MonoBehaviour
{
    public GameObject DeathScreen;
    private Rigidbody2D playerRigid;
    private bool playerDied;
    public float jumpSpeed;
    bool isPlatform;
    bool isDead;
    public Text textScore;
    private int topScore = 0;
    public Text endScore;
    public Text highScore;
    public GameObject death;
    public GameObject player;

    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;

    public AudioSource aud;
   

    private void Awake()
    {
        playerRigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
       
        highScore.text = PlayerPrefs.GetInt("High Score: ", 0).ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform" || collision.gameObject.tag == "platform1")
        {
            isPlatform = true;
            this.transform.parent = collision.transform;

        }
         
        
        if (collision.gameObject.tag == "fire")
        {
           
            Instantiate(death, transform.position, Quaternion.identity);
            isDead = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform" || collision.gameObject.tag == "platform1")
        {
            isPlatform = false;
            this.transform.parent = null;

        }
      
            if (collision.gameObject.tag == "fire")
        {
            isDead = false;
        }
    }


    void FixedUpdate()
    {
     
        if (isDead && !DeathScreen.activeSelf)
        {
            aud.Stop();
            Destroy(player);
            DeathScreen.SetActive(true);

        }
       
    }

    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, leftLimit, rightLimit),transform.position.y);



        Jump();
        if (playerRigid.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = (int)transform.position.y;

        }
        textScore.text = endScore.text = topScore.ToString();
        if (topScore > PlayerPrefs.GetInt("High Score: ", 0))
        {
            PlayerPrefs.SetInt("High Score: ", topScore);
            highScore.text = topScore.ToString();
        }
    }

    void Jump()
    {
        if (isPlatform && Input.GetButtonDown("Jump"))
        {
            playerRigid.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        }
    }
}
