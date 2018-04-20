using UnityEngine;
using System.Collections;

public enum MinerStatus { 
    FindingCrystal = 0,
    TakingCrystal = 1,
    FindingDepot = 2,
    Waiting = 3,
}

[RequireComponent(typeof(Seeker))]
public class MinerAI : AIPath {

    private bool isMoving = false;
    public Animator anim;
    /** Minimum velocity for moving */
    public float sleepVelocity = 0.4F;
    protected Vector3 lastTarget;

    private MinerStatus status = MinerStatus.Waiting;

    private bool hasBag = false;
    private GameObject targetObj;

	// Use this for initialization
	public new void Start () {
        base.Start();
        endReachedDistance = 2;
        target = null;
        Waiting();
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();

        //Vector3 relVelocity = tr.InverseTransformDirection(velocity);
        //relVelocity.y = 0;

        //if (relVelocity.sqrMagnitude <= sleepVelocity * sleepVelocity)
        //{
        //    if (isMoving == true) {
        //        Stop();
        //    }            
        //}
        //else {
        //    if (isMoving == false)
        //    {
        //        Run();
        //    } 
        //}
	}

    public override void OnTargetReached()
    {
        base.OnTargetReached();
        Debug.Log("OnTargetReached");
        Stop();
        target = null;
        canMove = false;

        if (status == MinerStatus.FindingCrystal) {
            TakeCrystal();
        }
        else if (status == MinerStatus.FindingDepot) {
            Waiting();
        }

    }


    public void Walk()
    {
        anim.Play(hasBag? "carry_bag_walk":"walk", 0, 0);
        isMoving = true;
    }

    public void Stop()
    {
        anim.Play(hasBag? "carry_bag_idle":"idle", 0, 0);
        isMoving = false;
    }

    public void Run()
    {
        anim.Play(hasBag? "carry_bag_run":"run", 0, 0);
        isMoving = true;
    }

    public void Work(){
        Debug.Log("Working");
        anim.Play("attack");
        StartCoroutine("Working");
    }

    public void FindCrystal() {
        Debug.Log("FindCrystal");
        status = MinerStatus.FindingCrystal;
        
        Crystal crystal = GameManager.GetInstance().GetGameSceneMgr().GetCrystalMgr().GetNearestCrystal(transform.position);
        if (crystal != null) {
            target = crystal.transform;
            targetObj = crystal.gameObject;
            Run();
            canMove = true;
        }
    }

    public void TakeCrystal() {
        status = MinerStatus.TakingCrystal;
        Work();
    }

    public void FindDepot() {
        Debug.Log("FindingDepot");
        status = MinerStatus.FindingDepot;
        Depot depot = GameManager.GetInstance().GetGameSceneMgr().GetBuildingMgr().GetNearestDepot(transform.position);
        if (depot != null) {
            target = depot.transform;
            targetObj = depot.gameObject;
            Run();
            canMove = true;
        }

    }

    public void Waiting() {
        Debug.Log("Waiting");
        status = MinerStatus.Waiting;
        hasBag = false;
        StartCoroutine("RealWaiting");
    }

    IEnumerator RealWaiting() {
        yield return new WaitForSeconds(1);
        FindCrystal();
    }

    IEnumerator Working()
    {
        yield return new WaitForSeconds(3);
        if (targetObj.GetComponent<Crystal>().Take(50)) {
            hasBag = true;
        }
        FindDepot();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
        if(other.gameObject == targetObj){
            if (other.tag.Equals("Crystal"))
            {
                OnTargetReached();
                TakeCrystal();
            }
            else if (other.tag.Equals("Depot"))
            {
                OnTargetReached();
                Waiting();
            }
        }        
    }

    void OnTriggerExit(Collider other)
    {

    }
}
