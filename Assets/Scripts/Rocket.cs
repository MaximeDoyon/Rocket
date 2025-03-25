using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Rocket : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _maxForceParSeconde = 1000;
    private Vector2 _turnVector = Vector2.zero;
    private bool _goUp = false;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_goUp)
        {
            Vector3 force = new Vector3(
            0,
            100,
            0
        ) * _maxForceParSeconde * Time.fixedDeltaTime;
            _rigidbody.AddForce(force);
            //_goUp = false;
        }     
    }
    void OnJump(InputValue inputValue)
    {
        _goUp = inputValue.isPressed;
    }
    void OnMove(InputValue inputValue)
    {
        var _turnVector = inputValue.Get<Vector2>();
    }
}
