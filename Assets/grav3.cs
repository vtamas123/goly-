using UnityEngine;

public class grav3 : MonoBehaviour
{
    public float emelkedesKezdoSebesseg = 1f;
    public float sebessegNovekedes = 0.5f;

    private float emelkedesiSebesseg;
    private float elteltIdo;
    private float ido = 0;

    void Start()
    {
        //emelkedesiSebesseg = emelkedesKezdoSebesseg;
    }

    void Update()
    { ido += Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y,ido));
        
        //elteltIdo += Time.deltaTime;
    }

}

