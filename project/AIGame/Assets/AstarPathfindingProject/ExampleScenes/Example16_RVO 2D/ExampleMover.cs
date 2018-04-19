using UnityEngine;
using System.Collections;

namespace Pathfinding.Examples {
	public class ExampleMover : MonoBehaviour {
		RVOExampleAgent agent;
		public Transform target;

		// Use this for initialization
		void Awake () {
			agent = GetComponent<RVOExampleAgent>();
		}

		void Start () {
			agent.SetTarget(target.position);
		}

		void LateUpdate () {
			if (Input.GetKeyDown(KeyCode.Mouse0)) {
				agent.SetTarget(target.position);
			}
		}
	}
}
