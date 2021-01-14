
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float Deceleration;
    

    public Rigidbody rb;
    private Vector3 velocity = Vector3.zero;
    private float horizontalMovement;
    
    void FixedUpdate()
    {
           
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        
        MovePlayer(horizontalMovement);
        
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement,rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, Deceleration);
    }

    void Start()
    {
        
    }
    


}
