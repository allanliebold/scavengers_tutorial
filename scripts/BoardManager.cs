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
  
}
