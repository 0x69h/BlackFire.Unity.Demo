//----------------------------------------------------
//Copyright © 2008-2017 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using BlackFire;
using BlackFire.Unity;
using UnityEngine;

namespace Alan 
{
    public sealed class PlaneGroup : FormGroup,IEngineStart_FormGroupCommand
    {
        public void EngineStart()
        {
            Log.Info("CC919 启动引擎。");
            Log.Info("Boeing787 启动引擎。");
        }
    }
}