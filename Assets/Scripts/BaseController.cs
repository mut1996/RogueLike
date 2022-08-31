using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController : MonoBehaviour
{
    [SerializeField]
    protected Define.State _state = Define.State.Idle;
    
    // worldObjectType

    public virtual Define.State State
    {
        get { return _state; }
        set 
        {
            _state = value;

            Animator anim = GetComponent<Animator>();
            switch (_state)
            {
                case Define.State.Idle:
                    anim.CrossFade("IDLE", 0.1f);
                    break;
                case Define.State.Move:
                    anim.CrossFade("MOVE", 0.1f);
                    break;
                case Define.State.Die:
                    anim.CrossFade("DIE", 0.1f);
                    break;
                case Define.State.Attack:
                    // attack 은 childeren 으로 만들어서 제어  
                    break;
                case Define.State.SKill:
                    // 무기에 다릴
                    break;
                case Define.State.Iteraction:
                    break;
                default:
                    break;
            }
        }
    }

    private void Start()
    {
        switch (State)
        {
            case Define.State.Idle:
                UpdateIdle();
                break;
            case Define.State.Move:
                UpdateMoving();
                break;
            case Define.State.Die:
                UpdateDie();
                break;
            case Define.State.SKill:
                UpdateSkill();
                break;
            case Define.State.Iteraction:
                break;
            default:
                break;
        }
    }


    public abstract void Init();

    protected virtual void UpdateMoving() { }
    protected virtual void UpdateDie() { }
    protected virtual void UpdateIdle() { }
    protected virtual void UpdateSkill() { }

}
