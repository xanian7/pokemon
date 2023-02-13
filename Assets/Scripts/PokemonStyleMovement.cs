using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PokemonStyleMovement : MonoBehaviour
{
    Direction direction;
    Vector2 input;
    bool isMoving = false;
    Vector3 startPos;
    Vector3 endPos;
    float t;

    public Animator animator;

    public float walkSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (!isMoving)
        //{
        //    input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //    if(Mathf.Abs(input.x) > Mathf.Abs(input.y))
        //    {
        //        input.y = 0;
        //    }
        //    else
        //    {
        //        input.x = 0;
        //    }

        //    if(input != Vector2.zero)
        //    {
        //        animator.SetFloat("Horizontal", input.x);
        //        animator.SetFloat("Vertical", input.y);
        //        animator.SetFloat("Speed", input.sqrMagnitude);
        //        StartCoroutine(Move(transform));
        //    }
        //}
    }

    private void FixedUpdate()
    {
        if (!isMoving)
        {
            input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if (Mathf.Abs(input.x) > Mathf.Abs(input.y))
            {
                input.y = 0;
            }
            else
            {
                input.x = 0;
            }

            if (input != Vector2.zero)
            {
                animator.SetFloat("Horizontal", input.x);
                animator.SetFloat("Vertical", input.y);
                animator.SetFloat("Speed", input.sqrMagnitude);
                StartCoroutine(Move(transform));
            }
        }
    }

    public IEnumerator Move(Transform entity)
    {
        isMoving = true;
        startPos = entity.position;
        t = 0;

        endPos = new Vector3(startPos.x + System.Math.Sign(input.x), startPos.y + System.Math.Sign(input.y), startPos.z);

        while (t < 1f)
        {
            t += Time.deltaTime * walkSpeed;
            entity.position = Vector3.Lerp(startPos, endPos, t);
            yield return null;
        }
        isMoving = false;
        yield return 0;
    }
}

enum Direction
{
    North,
    East,
    South,
    West
}
