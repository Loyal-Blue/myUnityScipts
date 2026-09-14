using UnityEngine;

public class player : MonoBehaviour
{  
    [SerializeField]
    private string _horizontalAxis = "Horizontal", _verticalAxis = "Vertical";

    [SerializeField]
    private Rigidbody2D _rb2d;

    private Vector2 _input;

    public float playerHealth = 10f;

    public float playerSpeed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void FixedUpdate()
    {
        _rb2d.linearVelocity = _input * playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw(_horizontalAxis);
        float verticalInput = Input.GetAxisRaw(_verticalAxis);
        _input = new Vector2(horizontalInput, verticalInput);
        _input.Normalize();
    }

    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
        
    
    private void damageFunction()
    {

    }
    
    
}
