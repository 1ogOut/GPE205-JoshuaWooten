using UnityEngine;

//changes the monobehavior to inherit from pawn
public class TankPawn : Pawn
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        nextEventTime = Time.time + 1/fireRate;
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Start();
    }

    //If the key is pressed down, triggering the script, it will activate the move code, getting its tranform to go forward by the movespeed or turnspeed float which if done in a negative will make it go backwards
    public override void MoveForward()
    {
        mover.Move(transform.forward, moveSpeed);
    }
    public override void MoveBackward()
    {
        mover.Move(transform.forward, -moveSpeed);
        noiseMaker.volumeDistance = movingVolumeDistance;
    }
    public override void RotateClockwise()
    {
        mover.Rotate(turnSpeed);
        noiseMaker.volumeDistance = movingVolumeDistance;
    }
    public override void RotateCounterClockwise()
    {
        mover.Rotate(-turnSpeed);
    }

     //Code for our AI\
    
    //creates the RotateTowards command to get our AI to find the direction the players in
    public override void RotateTowards(Vector3 targetPosition)
    {
        //creates a vectorToTarget by taking its posiition and subtracting ours
        Vector3 vectorToTarget = targetPosition - transform.position;
        //gets our target rotation to look donwn that vector
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);
        //rotate towards the vector by our turn speed instead of in 1 frame
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }   
}
