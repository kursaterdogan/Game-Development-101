using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StateMachine
{
    public class LocomotionFSM : MonoBehaviour
    {
        enum State
        {
            Grounded,
            InAir,
            Crouching
        }

        State _currentState = State.Grounded;

        // Jump from Grounded to InAir
        // Jump from Crouching to Grounded        
        public void Jump()
        {
            switch (_currentState)
            {
                case State.Grounded:
                    _currentState = State.InAir;
                    break;
                case State.Crouching:
                    _currentState = State.Grounded;
                    break;
            }
        }

        // Fall from Grounded to InAir
        // Fall from Crouching to InAir 
        public void Fall()
        {
            switch (_currentState)
            {
                case State.Grounded:
                    _currentState = State.InAir;
                    break;
                case State.Crouching:
                    _currentState = State.InAir;
                    break;
            }
        }

        // Land from InAir to Grounded
        public void Land()
        {
            switch (_currentState)
            {
                case State.InAir:
                    _currentState = State.Grounded;
                    break;
            }
        }

        // Crouch from Grounded to Crouching
        // Crouch from Crouching to Grounded 
        public void Crouch()
        {
            switch (_currentState)
            {
                case State.Grounded:
                    _currentState = State.Crouching;
                    break;
                case State.Crouching:
                    _currentState = State.Grounded;
                    break;
            }
        }
    }
}