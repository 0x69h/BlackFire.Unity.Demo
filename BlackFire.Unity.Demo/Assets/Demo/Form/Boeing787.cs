//----------------------------------------------------
//Copyright © 2008-2017 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using UnityEngine;
using BlackFire;

namespace Alan 
{
    public class Boeing787 : Plane , ISignal_FormGroupMembersCommand //,IFly_FormGroupCommand
    {
        public void Fly()
        {
            Log.Info("Boeing787 飞行。");
        }
        
        public void Signal()
        {
            Log.Info("Boeing787 收到信号。");
        }
    }
}