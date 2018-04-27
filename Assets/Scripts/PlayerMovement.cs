using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
    public GameObject deatParticles;

    private float _maxSpeed = 5f;
    private Vector3 _input;
    private Vector3 _spawnPosition;
    private Rigidbody _rigidbody;

	void Start () {
        _rigidbody = GetComponent<Rigidbody>();
        _spawnPosition = transform.position;
	}
	
	void Update () {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if(_rigidbody.velocity.magnitude < _maxSpeed)
        {
            _rigidbody.AddForce(_input * moveSpeed);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            Instantiate(deatParticles, transform.position, Quaternion.identity);
            transform.position = _spawnPosition;
        }
    }
}
