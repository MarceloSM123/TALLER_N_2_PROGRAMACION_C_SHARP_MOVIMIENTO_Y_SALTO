using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rd;
    public float speed=5f;
    public float jumpForce=7f;
    private bool isGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move=Input.GetAxis("Horizontal");
        rd.velocity=new Vector2(move * speed, rd.velocity.y);
    }
}
