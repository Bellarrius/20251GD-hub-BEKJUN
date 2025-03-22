using UnityEngine;

public class NPCAnimation : MonoBehaviour
{
    public Animator animator;
    public Transform player;
    public float greetingDistance = 5f;

    private bool isGreeting = false;

    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
        animator.SetInteger("AnimationID", 0); // Idle par défaut
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= greetingDistance && !isGreeting)
        {
            isGreeting = true;
            animator.SetInteger("AnimationID", 1); // Jouer animation de salut
        }
        else if (distance > greetingDistance && isGreeting)
        {
            isGreeting = false;
            animator.SetInteger("AnimationID", 0); // Revenir à l'animation d'attente
        }
    }
}