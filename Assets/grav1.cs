using UnityEngine;

public class grav1 : MonoBehaviour
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
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //StartEmelkedes();
            //elteltIdo += Time.deltaTime;
            ido++;Emelkedes();elteltIdo = 0;

        }

        
    }

    void StartEmelkedes()
    {
        //elteltIdo = 0;
        //emelkedesiSebesseg += sebessegNovekedes;
    }

    void Emelkedes()
    {
        float emelkedesMagassag = ido;
        transform.position = new Vector3(transform.position.x, emelkedesMagassag, transform.position.z);
        //elteltIdo += Time.deltaTime;
    }
}
