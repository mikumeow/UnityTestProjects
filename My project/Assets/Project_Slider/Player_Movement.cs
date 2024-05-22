
using Unity.VisualScripting;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewayForce = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (!FindObjectOfType<GameManager>().GameRunning())
        {
            return;
        }
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce( -sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (rb.transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
