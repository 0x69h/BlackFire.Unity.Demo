﻿//----------------------------------------------------
//Copyright © 2008-2018 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Alan 
{
	public interface IBeShotHandler : BlackFire.Event.IEventHandler
	{
        void BeShot(int hurt);
    }
}
