using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    private Rigidbody2D rb;


    [field: SerializeField] public int Coin { get; set; } = 0;
    [field: SerializeField] public int Health { get; set; } = 50;



    private void OnTriggerEnter2D(Collider2D other)
    {
        Items item = other.GetComponent<Items>();
        if (item)
        {

            item.Pickup(this);

        }
    }


    public void Heal(int value)
    {
        Health += value;
        Debug.Log("Heart Health" + Health);

    }














    // Start is called before the first frame update
    void Start()
    {
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float move = 0f;
        if (Input.GetKey(KeyCode.A))
            move = -1f;
        else if (Input.GetKey(KeyCode.D))
            move = 1f;

        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }






    }
}
