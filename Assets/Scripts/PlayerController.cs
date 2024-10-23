using System.Diagnostics;
using UnityEngine;

public class PlayerController : Controller
{
    //makes the keycodes public so you can edit them from the script on the engine itself
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
     //checks if we have a game manager
        if (GameManager.instance != null)
        {
            //checks if its tracking the players
            if (GameManager.instance.players != null)
            {
                GameManager.instance.players.Add(this);
            }
        }
        base.Start();
    }

    // Update is called once per frame, process inputs makes it where its always looking for inputs
    public override void Update()
    {
        ProcessInputs();
        base.Update();
    }

    //If the correct key is being pushed down it will call the script 
    public void ProcessInputs()
    {
        if (Input.GetKey(moveForwardKey))
        {
            pawn.MoveForward();
        }
                else
        {
            pawn.noiseMaker.volumeDistance = 0;
        }
         if (Input.GetKey(moveBackwardKey))
        {
            pawn.MoveBackward();
        }
                else
        {
            pawn.noiseMaker.volumeDistance = 0;
        }
         if (Input.GetKey(rotateClockwiseKey))
        {
            pawn.RotateClockwise();
        }
                else
        {
            pawn.noiseMaker.volumeDistance = 0;
        }
         if (Input.GetKey(rotateCounterClockwiseKey))
        {
            pawn.RotateCounterClockwise();
        }
                else
        {
            pawn.noiseMaker.volumeDistance = 0;
        }
    }
        public void OnDestroy()
    {
        //if game manager
        if(GameManager.instance != null)
        {
            if (GameManager.instance.players != null)
            {
                GameManager.instance.players.Remove(this);
            }
        }
    }
}
