//----------------------------------------------------
//Copyright © 2008-2017 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using UnityEngine;
using BlackFire;

namespace Alan 
{
    public class CC919 : Plane ,IFly_FormGroupMemberCommand,ISignal_FormGroupMembersCommand
    {
        public void Fly()
        {
            Log.Info("CC919 飞行。");
        }

        public void Signal()
        {
            Log.Info("CC919 收到信号。");
        }
    }
}