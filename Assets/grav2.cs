using UnityEngine;

public class grav2 : MonoBehaviour
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
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, emelkedesMagassag));
        //elteltIdo += Time.deltaTime;
    }
}
