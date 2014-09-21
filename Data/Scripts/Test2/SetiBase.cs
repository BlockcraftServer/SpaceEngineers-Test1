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



namespace SETItest
{
    [MyEntityComponentDescriptor(typeof(MyObjectBuilder_SensorBlock))]
    public class SetiBase : MyGameLogicComponent
    {
        IMySensorBlock Sensor;

        public override void Close()
        {

            Sensor.StateChanged += sensor_StateChanged;

        }

        public override void Init(MyObjectBuilder_EntityBase objectBuilder)
        {
            Sensor = Entity as IMySensorBlock;
            Sensor.StateChanged += sensor_StateChanged;

        }

        void sensor_StateChanged(bool obj)
        {

            MyObjectBuilder_FloatingObject floatingObjectBuilder = new MyObjectBuilder_FloatingObject();
            floatingObjectBuilder.Item = new MyObjectBuilder_InventoryItem()
            {
                Amount = 300,
                Content = new MyObjectBuilder_Ore() { SubtypeName = "Stone" }
            };
            floatingObjectBuilder.PersistentFlags = MyPersistentEntityFlags2.InScene;
            floatingObjectBuilder.PositionAndOrientation = new MyPositionAndOrientation()
            {
                Position = Sensor.WorldMatrix.Translation + Sensor.WorldMatrix.Forward * 1.5f,
                Forward = Sensor.WorldMatrix.Forward,
                Up = Sensor.WorldMatrix.Up
            };
            var floatingObject = Sandbox.ModAPI.MyAPIGateway.Entities.CreateFromObjectBuilderAndAdd(floatingObjectBuilder);



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
