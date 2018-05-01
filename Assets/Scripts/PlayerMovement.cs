using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;

    private float _maxSpeed = 5f;
    private Vector3 _input;
    private Rigidbody _rigidbody;

	void Start () {
        _rigidbody = GetComponent<Rigidbody>();
	}
	
	void Update () {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if(_rigidbody.velocity.magnitude < _maxSpeed)
        {
            _rigidbody.AddForce(_input * moveSpeed);
        }
	}

}
