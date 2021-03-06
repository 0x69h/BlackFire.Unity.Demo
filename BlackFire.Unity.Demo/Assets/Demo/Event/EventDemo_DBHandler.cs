﻿//----------------------------------------------------
//Copyright © 2008-2018 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using BlackFire;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Alan 
{


	public sealed class EventDemo_DBHandler : MonoBehaviour 
	{
        private void Start()
        {
            BlackFire.Event.On(EventTopic.BossDropOfBlood, this,(sender,args)=> {

                var cargs = args as BossDropOfBloodEventArgs;
                Log.Info(string.Format("数据库写入Boss减血{0}记录。  Sender : {1}   Args : {2}", cargs.Blood ,sender, cargs.ToString()));

            });
        }

        private void OnDestroy()
        {
            BlackFire.Event.Off(EventTopic.BossDropOfBlood, this);
        }
    }
}
