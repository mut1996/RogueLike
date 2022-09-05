using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator Anim;

    public PlayerStateMachine stateMachine { get; private set; }
}
