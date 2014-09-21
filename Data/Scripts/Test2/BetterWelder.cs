using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sandbox.Common;
using Sandbox.Common.Components;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Definitions;
using Sandbox.Engine;
using Sandbox.Game;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;

namespace ModTestingProject
{
    [MyEntityComponentDescriptor(typeof(MyObjectBuilder_Welder))]
    public class BetterWelder : MyObjectBuilder_Welder
    {

        public override void Close()
        {
          
        }

        public override void Init(MyObjectBuilder_EntityBase objectBuilder)
        {
 
        }

        public override void MarkForClose()
        {

        }

        public override void UpdateAfterSimulation()
        {

        }

        public override void UpdateAfterSimulation10()
        {

        }

        public override void UpdateBeforeSimulation10()
        {

        }

        public override void UpdateOnceBeforeFrame()
        {

        }
    }
}
