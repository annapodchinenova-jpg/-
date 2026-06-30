using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float JumpStrength = 10.0f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //Увеличение высоты прыжка игрока
        other.GetComponent<Jump> ().jumpStrength += JumpStrength;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        //Понижение высоты прыжка игрока
      other.GetComponent<Jump> ().jumpStrength -= JumpStrength;
    }
}
