using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {
  [Serializable]
  public class Count {
    public int minimum, maximum;
    public Count (int min, int max) {
      minimum = min;
      maximum = max;
    }
  }
  
  public int columns = 8;
  public int rows = 8;
  public Count wallCount = new Count (5,9);
  public foodCount = new Count (1, 5);
  public GameObject exit;
  public GameObject[] floorTiles;
  public GameObject[] wallTiles;
  public GameObject[] foodTiles:
  public GameObject[] enemyTiles;
  public GameObject[] outerWallTiles;
  
  private Transform boardHolder;
  private List <Vector3> gridPositions = new List<Vector3>();
  
  void InitialiseList() {
    for (int x = 1; x < columns - 1; x++) {
      for (int y = 1; y < rows - 1; y++) {
        
      }
    }
  }
}
