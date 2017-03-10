using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum State
    {
        IDLE = 0,
        WALK,
        ROLL,
    }

    public Animator m_Animator;
    public SpriteRenderer m_SpriteRenderer;
	
	// Update is called once per frame
	void Update ()
    {
        /*if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_Animator.SetInteger("State", (int)State.WALK);
            m_SpriteRenderer.flipX = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            m_Animator.SetInteger("State", (int)State.IDLE);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_Animator.SetInteger("State", (int)State.WALK);

            m_SpriteRenderer.flipX = false;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            m_Animator.SetInteger("State", (int)State.IDLE);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Animator.SetInteger("State", (int)State.ROLL);

        }*/
        
        float moveDelta = Input.GetAxisRaw("Horizontal");

        if (moveDelta != 0)
        {
            m_SpriteRenderer.flipX = moveDelta < 0;
            m_Animator.SetInteger("State", (int)State.WALK);
        }
        else
        {
            m_Animator.SetInteger("State", (int)State.IDLE);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Animator.SetInteger("State", (int)State.ROLL);
        }
        
    }

    public void OnRollEnd()
    {
        //m_Animator.SetInteger("State", (int)State.IDLE);
    }
}


