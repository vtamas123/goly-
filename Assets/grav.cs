using UnityEngine;

public class grav : MonoBehaviour
{
    public float emelkedesKezdoSebesseg = 1f;
    public float sebessegNovekedes = 0.5f;

    private float emelkedesiSebesseg;
    private float elteltIdo;
    private float ido = 1;

    void Start()
    {
        emelkedesiSebesseg = emelkedesKezdoSebesseg;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartEmelkedes();
            elteltIdo += Time.deltaTime;
            ido++;

        }

        if (elteltIdo > 0 && elteltIdo <ido)
        {
            Emelkedes();
        }
    }

    void StartEmelkedes()
    {
        elteltIdo = 0;
        //emelkedesiSebesseg += sebessegNovekedes;
    }

    void Emelkedes()
    {
        float emelkedesMagassag = emelkedesiSebesseg * elteltIdo;
        transform.position = new Vector3(transform.position.x, emelkedesMagassag, transform.position.z);
        elteltIdo += Time.deltaTime;
    }
}
