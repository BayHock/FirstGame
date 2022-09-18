using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour
{
    //------- Функция/метод, выполняемая при запуске игры ---------
    public Rigidbody2D rb;
    public float speed = 13f;
    public Vector2 moveVector;

    //Переменные для прыжка
    private bool isGround;
    public Transform GroundCheck;
    public float checkRadius;
    public LayerMask whatisGround;
    public float JumpForce;

    private int ExtraJumps;
    public int ExtraJumpsValue;

    void Start()
    {
        ExtraJumps = ExtraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);

        if (isGround == true)
        {
            ExtraJumps = ExtraJumpsValue;
        }

        if (Input.GetKeyDown(KeyCode.Space) && ExtraJumps > 0)
        {
            rb.velocity = Vector2.up * JumpForce;
            ExtraJumps--;
        }
        else
        if (Input.GetKeyDown(KeyCode.Space) && ExtraJumps == 0 && isGround == true)
        {
            rb.velocity = Vector2.up * JumpForce;
        }
    }


    private void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, whatisGround);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (other.tag == "Finish game")
        {
            SceneManager.LoadScene("Finish game");
        }
        else if (other.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
}
