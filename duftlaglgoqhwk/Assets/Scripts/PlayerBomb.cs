using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBomb : MonoBehaviour
{
    public GameObject BombFactory;

    public GameObject BombPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject Bomb = Instantiate(BombFactory);

            Bomb.transform.position = BombPosition.transform.position;
        }
    }
}
