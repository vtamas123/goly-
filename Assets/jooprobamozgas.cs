using UnityEngine;
using UnityEngine.SceneManagement;

public class probamozgas : MonoBehaviour
{
    public float sebesseg = 1;
    private Rigidbody _rigidbody;
    private Vector3 _vector3;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal")*sebesseg ;
        var y = Input.GetAxis("Vertical")  * sebesseg;
        var z = Input.GetAxis("Jump")  * sebesseg;
        Move(x, z,y);
        if (Input.GetKey("r"))
            SceneManager.LoadScene(0);

    }

    private void Move(float x, float z, float y)
    {
        _vector3.Set(x, z, y);
        _vector3 = _vector3.normalized * sebesseg * Time.deltaTime;
        _rigidbody.MovePosition(transform.position + _vector3);
       
    }
}
