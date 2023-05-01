using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimations : MonoBehaviour
{
    // Start is called before the first frame update
    public Animation idle;
    public Animation attack;
    public Animation effect;
    public GameObject effectGO;
    public Animation move;
    void Start()
    {
        effectGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DoIdle() {
        idle.Play();
    }

    void DoMove() {
        move.Play();

    }
    void DoAttack() {
        effectGO.SetActive(true);
        effect.Play();



    }
}
