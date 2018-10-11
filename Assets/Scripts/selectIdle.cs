﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectIdle : StateMachineBehaviour {
	public int min;
	public int max;

	private float lastID = 0;
	private float newID;
	private float t;
	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	//override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override 
	public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if (t < 1) {
			animator.SetFloat ("idleID", Mathf.Lerp (lastID, newID, t));
			t += Time.deltaTime;
		}	
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo,int layerIndex)
	{
		//Debug.Log ("OneStateEnter");
		//animator.SetFloat("idleID", Random.Range(min, max));
		t = 0;
		lastID = animator.GetFloat("idleID");
		newID = Random.Range(min, max);

	}

}