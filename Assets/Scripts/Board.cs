using UnityEngine;
using System.Collections;
using System.Linq;

public class Board : MonoBehaviour {

    public int boardSize;

    public Tile tilePrefab;

    public Tile[,] tiles;
    

	// Use this for initialization
	void Start () {
        Debug.Log("Board Created");

        CreateBoard();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void CreateBoard()
    {
        tiles = new Tile[boardSize, boardSize];

        int i,j;

        for (i = 0; i < boardSize; i++ )
        {
            for(j = 0; j < boardSize; j++)
            {

                Tile myObject = Instantiate(tilePrefab, new Vector3(0, 0, 0), Quaternion.identity) as Tile;

                myObject.transform.position = new Vector3(1*i,0,1*j);

                myObject.transform.parent = this.transform;

                tiles[i, j] = myObject;
            }
        }
    }
}