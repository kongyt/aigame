using UnityEngine;
using System.Collections;

public class Miner : MonoBehaviour {

    public Animator anim;
    public NavMeshAgent agent;
    public bool isMoving = false;

    void Awake() {
        
    }

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (IsMoving())
        {
            if (Mathf.Abs(agent.remainingDistance) < 0.1f)
            {
                Stop();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 screenPos = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(screenPos);

            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                Vector3 target = hitInfo.point;

                WalkTo(target);
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Vector3 screenPos = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(screenPos);

            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                Vector3 target = hitInfo.point;

                RunTo(target);
            }
        }   
	}

    private bool IsMoving() {
        return this.isMoving;
    }

    public void WalkTo(Vector3 target) {
        isMoving = true;
        transform.LookAt(target);   
        agent.speed = 1.5f;
        agent.Resume();        
        agent.destination = target;
        anim.Play("walk");
    }

    public void Stop() {
        isMoving = false;
        agent.Stop();
        anim.Play("idle");
    }

    public void RunTo(Vector3 target) {
        isMoving = true;
        transform.LookAt(target);
        agent.speed = 3;
        agent.Resume();
        agent.destination = target;
        anim.Play("run");
    }

    public void OnDrawGizmos() {
        if (IsMoving()) {
            NavMeshPath path = agent.path;
            Gizmos.color = Color.blue;
            for (int i = 0; i < path.corners.Length-1; i++) {
                Gizmos.DrawLine(path.corners[i], path.corners[i + 1]);
            }
        }
    }
}
