using UnityEngine;
using System.Collections;

public class SpawnBlocks : MonoBehaviour {

	public GameObject blockPrefab;
	public int worldSize;
	public int blockSize;

	public void Start()
	{	
		CreateWorld();
	}

	public void CreateWorld()
	{
		for (int x=0; x < worldSize; x+=blockSize) 
		{
			for (int z=0; z < worldSize; z+=blockSize) 
			{
				GameObject block = (GameObject)Instantiate(blockPrefab);
				block.transform.position = new Vector3(this.transform.position.x+x, 
				                                       this.transform.position.y, 
				                                       this.transform.position.z+z);
			}			
		}
	}
}
