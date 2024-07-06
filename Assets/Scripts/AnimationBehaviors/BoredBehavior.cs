using UnityEngine;

public class BoredBehavior : StateMachineBehaviour
{
    [SerializeField] float _timeUntilBored;

    [SerializeField] int _numberOfBoredAnimations;
    float _idleTime;

    bool _isBored;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
