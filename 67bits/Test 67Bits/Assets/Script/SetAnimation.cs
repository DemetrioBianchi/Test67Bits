using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimation : MonoBehaviour
{
    [SerializeField] private bool isWalk, isRun;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetBool("isWalk", isWalk);
        GetComponent<Animator>().SetBool("isRun", isRun);
    }
}
