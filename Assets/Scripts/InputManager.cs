using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public static bool Jump(int playerID)
    {
        if(Input.GetButtonDown("A_Button_P" + playerID))
        {
            return true;
        }
        return false;
    }

    public static float Horizontal(int playerID)
    {
        if(Input.GetAxisRaw("J_Horizontal_P" + playerID) != 0)
        {
            return Input.GetAxisRaw("J_Horizontal_P" + playerID);
        }
        return 0;
    }

    public static float Vertical(int playerID)
    {

        return 0;
    }
}
