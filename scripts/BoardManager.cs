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
  
}
