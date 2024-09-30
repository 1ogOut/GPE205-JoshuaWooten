using UnityEngine;

public abstract class Pawn : MonoBehaviour
{

    //move speed variable
    public float moveSpeed;
    //turn speed variable
    public float turnSpeed;
    //storing our mover. 
    public Mover mover; 

    //when the game starts, it will get the mover to obtain the Mover copmonent 
    public virtual void Start()
    {
        mover = GetComponent<Mover>();
    }

    // needs to be here and public so TankPawn can get it even if theres nothing in it
    public virtual void Update()
    {
    }

    //scripts for the move commands
    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
}
