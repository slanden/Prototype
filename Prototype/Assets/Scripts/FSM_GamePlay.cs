using UnityEngine;
using System.Collections;

public class FSM_GamePlay
{
    /// <Game Play FSM>
    /// Control the flow  
    /// 

    enum States /// PlaceHolders
    {
        STATE1,
        STATE2,
        STATE3,
        STATE4
    }

    States currentState = States.STATE1;

    bool CheckTransistion( States to)
    {
        /// Check Fails if transisiton attempt is the same af current state
        if (currentState == to)
        {
            return false;
        }

        switch (to)
        {
            case (FSM_GamePlay.States.STATE1):
                {
                    /// PlaceHolder
                     if(to == FSM_GamePlay.States.STATE2)
                    return true;
                }break;
            case (FSM_GamePlay.States.STATE2):
                {
                    /// PlaceHolder
                    if(to == FSM_GamePlay.States.STATE3)
                    return true;
                }break;
            case (FSM_GamePlay.States.STATE3):
                {
                    /// PlaceHolder
                    if (to == FSM_GamePlay.States.STATE4)
                        return true;
                }break;
            case (FSM_GamePlay.States.STATE4):
                {
                    /// PlaceHolder
                    if (to == FSM_GamePlay.States.STATE1)
                        return true;
                }break;
            default:
                break;
        }
        return false;
    }

    bool HandleTransistion(States from, States to)
    {
        if (CheckTransistion(from, to))
        {

        }

        return false;
    }
}
