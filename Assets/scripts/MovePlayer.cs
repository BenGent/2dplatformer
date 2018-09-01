using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 27f;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        float movex = input.getaxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * movex * speed * Time.deltaTime);
    }
}