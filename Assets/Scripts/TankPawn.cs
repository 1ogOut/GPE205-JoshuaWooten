using UnityEngine;

//changes the monobehavior to inherit from pawn
public class TankPawn : Pawn
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
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
    }
    public override void RotateClockwise()
    {
        mover.Rotate(turnSpeed);
    }
    public override void RotateCounterClockwise()
    {
        mover.Rotate(-turnSpeed);
    }
}
