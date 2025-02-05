using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    public float speed = 2f;
    public float attackDistance = 0.6f;

    private Animator animatorEnemy;
    private Rigidbody rigidbodyEnemy;
    private Transform target;

    [SerializeField]
    private bool isFollowingTarget;

    private float currentAttackTime = 0f;
    private float maxAttackingTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        animatorEnemy = GetComponent<Animator>();
        rigidbodyEnemy = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);

        isFollowingTarget = Vector3.Distance(transform.position, target.position) >= attackingDistance;
        if (isFollowingTarget)
        {
            rigidbodyEnemy.velocity = transform.forward * speed;
        }
    }
}
