/*
--------------------------------------------------
| Copyright © 2008 Mr-Alan. All rights reserved. |
| Website: www.0x69h.com                         |
| Mail: mr.alan.china@gmail.com                  |
| QQ: 835988221                                  |
--------------------------------------------------
*/

using System.Collections;
using BlackFire;
using BlackFire.Unity;
using BlackFire.Unity.Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Alan
{
    public sealed class AppDemo:MonoBehaviour
    {
        private void Start()
        {
            
        }
    }


    public sealed class ProcessMain : ProcessBase
    {
        protected override void OnProcessInit()
        {

        }


        private IEnumerator _InitYield()
        {
            
            yield return null;
            App.Resource.LoadSceneAsync(new SceneInfo("App.Tmp", LoadSceneMode.Single), e =>
            {
                ChangeProcess<ProcessTmp>();
            });
            
        }


        protected override void OnProcessEnter()
        {
            BlackFire.Iterator.Start("Main",_InitYield());
        }

        protected override void OnProcessUpdate()
        {
            Log.Info("Main");
        }

        protected override void OnProcessExit()
        {
            BlackFire.Iterator.Cancel("Main");
        }

        protected override void OnProcessDestroy()
        {
            
        }

        public override string Name
        {
            get { return "Main"; }
        }
    }

    public sealed class ProcessTmp : ProcessBase
    {
        protected override void OnProcessInit()
        {
            
        }

        private IEnumerator _InitYield()
        {
            
            yield return new WaitForSeconds(5f);
            App.Resource.LoadSceneAsync(new SceneInfo("App.Demo", LoadSceneMode.Single), e =>
            {
                ChangeProcess<ProcessMain>();
            });
        }
        
        protected override void OnProcessEnter()
        {
            BlackFire.Iterator.Start("Tmp",_InitYield());
        }

        protected override void OnProcessUpdate()
        {
            Log.Info("Tmp");
        }

        protected override void OnProcessExit()
        {
            BlackFire.Iterator.Cancel("Tmp");
        }

        protected override void OnProcessDestroy()
        {
            
        }

        public override string Name
        {
            get { return "Tmp"; }
        }
    }
    
}