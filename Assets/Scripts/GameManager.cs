using System.Numerics;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //instance makes it where only this one can exist. 
    public static GameManager instance;
    //gets the transform of PlayerSpawn
    public Transform PlayerSpawnTransform;
    //Awake means this is the first thing that happens, this code looks for other instance's of gamemanagers and destroys them, without destroying this. 
    private void Awake ()
    {
        if (instance == null){
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    //Code for Spawning the player
    public void SpawnPlayer()
    {
        //
        GameObject newPlayerObj = Instantiate(playerControllerPrefab, UnityEngine.Vector3.zero, UnityEngine.Quaternion.identity) as GameObject;
        GameObject newPawnObj = Instantiate(tankPawnPrefab, PlayerSpawnTransform.position, PlayerSpawnTransform.rotation) as GameObject;
        Controller newController = newPlayerObj.GetComponent<Controller>();
        Pawn newPawn = newPawnObj.GetComponent<Pawn>();
        newController.pawn = newPawn;
    }
    public GameObject tankPawnPrefab;
    public GameObject playerControllerPrefab;
    private void Start()
    {
        SpawnPlayer();
    }
}
