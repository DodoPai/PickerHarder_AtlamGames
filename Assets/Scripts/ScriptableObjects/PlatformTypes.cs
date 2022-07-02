using UnityEngine;

[CreateAssetMenu(fileName = "New Platform Type",menuName ="Platform Type")]
public class PlatformTypes : ScriptableObject
{
    #region Platform Movement Values
    public int howManyBall;
    public float distance;
    public bool isTrue;
  
    public string typeName = "Platform1";
    #endregion

}
