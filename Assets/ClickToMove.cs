﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace CompleteProject {
    
	public class ClickToMove : MonoBehaviour {

		public Transform goal = null;
        private NavMeshAgent agent;

		void Start()
		{
			agent = GetComponent<NavMeshAgent>();
			agent.destination = goal.position;
		}

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				RaycastHit hit;

				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
				{
					agent.destination = hit.point;
				}
			}

            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, 0);
		}
	}
}