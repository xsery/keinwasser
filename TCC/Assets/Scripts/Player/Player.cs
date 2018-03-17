using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float maxSpeed = 4;
    public float jumpForce = 400;
    public float minHeight, maxHeight;
    public int maxHealth = 10;
    public string playerName;
    public Sprite playerImage;
    //public AudioClip collisionSound, jumpSound, healthItem;

    private int currentHealth;
    private float currentSpeed;
    private Rigidbody rb;
    private Animator anim;
    private Transform groundCheck;
    private Transform wallCheck;
    private bool onGround;
    private bool onWallX;
    public bool isDead = false;
    private bool facingRight = true;
    private bool jump = false;
    //private AudioSource audioS;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        groundCheck = gameObject.transform.Find("GroundCheck");
        //wallCheck = gameObject.transform.Find("WallCheck");
        currentSpeed = maxSpeed;
        //audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        onGround = Physics.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        //onWallX = Physics.Linecast(transform.position, wallCheck.position, 1 << LayerMask.NameToLayer("LimiteX"));

        if (Input.GetButtonDown("Jump") && onGround)
        {
            jump = true;
        }

        if (Input.GetButtonDown("Attack"))
        {
            anim.SetTrigger("Attack");
        }

		if (rb.velocity.x == 0f && onGround) {
			
			anim.SetBool ("Walk", false);
		}
		else
			anim.SetBool ("Walk", true);
    }

    private void FixedUpdate()
    {
        if (!isDead)
        {
            float h = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            if (!onGround)
            {
                z = 0;
            }

            if (h > 0 && !facingRight)
            {
                Flip();
            }
            else if (h < 0 && facingRight)
            {
                Flip();
            }

            if (jump)
            {
                jump = false;
				anim.SetTrigger ("Jump");
                rb.AddForce(Vector3.up * jumpForce);
            }

            float minWidthCamera = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 10)).x;
            float maxWidthCamera = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 10)).x;

            if (onWallX)
            {

                rb.velocity = new Vector3(0, rb.velocity.y, z * currentSpeed); 
            }
            else
            {
                rb.velocity = new Vector3(h * currentSpeed, rb.velocity.y, z * currentSpeed);
            }

                rb.position = new Vector3(Mathf.Clamp(rb.position.x, minWidthCamera + 1, maxWidthCamera - 1),
                    rb.position.y,
                    Mathf.Clamp(rb.position.z, minHeight + 1, maxHeight - 1));
               


			if (((rb.position.x <= minWidthCamera + 1) && (!facingRight)) ||
                    ((rb.position.x >= maxWidthCamera - 1) && (facingRight)))
                {
                    rb.velocity = new Vector3(0, rb.velocity.y, z * currentSpeed);
                }

        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void ZeroSpeed()
    {
        currentSpeed = 0;
    }

    void ResetSpeed()
    {
        currentSpeed = maxSpeed;
    }

    public void PlaySong(AudioClip clip)
    {
        //audioS.clip = clip;
        //audioS.Play();
    }

    public void TookDamage(int damage)
    {
        if (!isDead)
        {
            currentHealth -= damage;
            //anim.SetTrigger("HitDamage");
            FindObjectOfType<UIManager>().UpdateHealth(currentHealth);
            //PlaySong(collisionSound);
            if(currentHealth <= 0)
            {
                isDead = true;
                FindObjectOfType<GameManager>().lives--;
                
                if (facingRight)
                {
                    rb.AddForce(new Vector3(-3, 5, 0), ForceMode.Impulse);
                } else
                {
                    rb.AddForce(new Vector3(3, 5, 0), ForceMode.Impulse);
                }
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Health Item"))
        {
            if (Input.GetButtonDown("Item"))
            {
                Destroy(other.gameObject);
                //anim.SetTrigger("Catching");
                //PlaySong(healthItem);
                currentHealth = maxHealth;
                FindObjectOfType<UIManager>().UpdateHealth(currentHealth);
            }
        }
    }

    void PlayerRespawn()
    {
        if (FindObjectOfType<GameManager>().lives > 0)
        {
            isDead = false;
            FindObjectOfType<UIManager>().UpdateLives();
            currentHealth = maxHealth;
            FindObjectOfType<UIManager>().UpdateHealth(currentHealth);
            //anim.Rebind();
            float minWidth = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 10)).x;
            transform.position = new Vector3(minWidth, 10, -4);
        }
        else
        {
            //popup Dead
            GameManager.Instance.beginGame();
        }
    }
}
