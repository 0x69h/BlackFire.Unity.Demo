//----------------------------------------------------
//Copyright © 2008-2017 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using UnityEngine;

namespace Alan
{
    public sealed class GameObjectTracerUT : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(GameObjectTracer.Acqiure("Fucker").name);
        }
    }
}