using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKnife : MonoBehaviour
{

    public GameObject KnifeFactory;

    public GameObject KnifePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject Knife = Instantiate(KnifeFactory);

            Knife.transform.position = KnifePosition.transform.position;
        }
    }
}
