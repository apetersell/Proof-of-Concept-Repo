//HATY CATCHY by m@ boch - NYU GAMECENTER - Oct 2016

using UnityEngine;
using System.Collections;

public class StudentSpawner : MonoBehaviour {
    //public variables are accessible by other scripts, and are often set in the inspector
    //they're great for tunable variables, like these, since we can edit them in play mode.
    public GameObject studentPrefab1;
    public GameObject studentPrefab2;
    public float timeBetweenSpawns; //interval of time to wait between spawn in seconds

    public float velocity;
   
    public float xSpawnPosMin; //left most spawn point
    public float xSpawnPosMax; //right most spawn point
    public float ySpawnPos; //height of spawn

    //private variables are more like the global variables in Phaser, and 
    //they can't be accessed by other scripts
    public float timeUntilSpawn;

    public void Start()
    {
        timeUntilSpawn = 1;
    }

    public void Update()
    {
        //Time.delaTime is how much time has occured since the last update. 
        //We subtract it from time until spawn every frame
        timeUntilSpawn -= Time.deltaTime;
        //Once timeUntilSpawn is less than 0, we spawn a new hat
        if (timeUntilSpawn <= 0)
        {
            SpawnStudent();
            //then we reset timeUntilSpawn to the timeBetweenSpawns & start all over again
            timeUntilSpawn = timeBetweenSpawns;
        }
    }

    private void SpawnStudent()
    {
        //Generate a new spawn position. 
        //For the first value of this Vector3 (x) we use Random.Range to get a position between our min & max X values
        //The second (y) is just the height we spawn at
        //The third (z) is the depth, which is set to 0 as we're in 2D
        Vector3 newPos = new Vector3(Random.Range(xSpawnPosMin, xSpawnPosMax), ySpawnPos, 0);
        //Instantiate creates a new object from a prefab. It needs the prefab, the position, and the rotation as arguements
        //newPos is the position we made, Quaternion.identity just means that we're not rotating the sprite
        GameObject student1 =  Instantiate(studentPrefab1, newPos, Quaternion.identity);
        student1.GetComponent<Rigidbody2D>().velocity = new Vector3(velocity, 0, 0);

        Vector3 newPos2 = new Vector3(Random.Range(xSpawnPosMin, xSpawnPosMax), ySpawnPos, 0);
        GameObject student2 = Instantiate(studentPrefab2, newPos2, Quaternion.identity);
        student2.GetComponent<Rigidbody2D>().velocity = new Vector3(velocity, 0, 0);
    }

 

}
