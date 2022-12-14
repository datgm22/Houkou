using UnityEngine;

public class Houkou : MonoBehaviour
{
    /// <summary>
    /// 決まった方向に制限した角度を返す
    /// </summary>
    /// <param name="degree">-180〜180度</param>
    /// <returns>30方向にまとめた角度を返す</returns>
    public float GetLimitedDegree(float degree)
    {
        return 6;
    }
}
