﻿using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using Pinou.EntitySystem;

namespace Pinou.Networking
{
    public class EntityEquipmentNetData : EntityEquipmentData
    {
        #region Component Core
        public override EntityComponent ConstructComponent(Entity master, EntityReferences references)
        {
            return ConstructComponent<EntityEquipmentNet, EntityEquipmentNetData>(master, references, this);
        }
        #endregion

        public class EntityEquipmentNet : EntityEquipment, INetworkEntityData
        {
            #region OnConstruct
            /// <summary>
            /// Need base
            /// </summary>
            protected override void OnConstruct()
            {
                base.OnConstruct();
                _data = (EntityEquipmentNetData)base.Data;
            }

            private EntityEquipmentNetData _data = null;
            public new EntityEquipmentNetData Data => _data;
            #endregion

            #region INetworkEntityData
            public new EntityNet Master => master as EntityNet;
            public new EntityReferencesNet References => base.References as EntityReferencesNet;
            public new IControllerNet Controller => base.Controller as IControllerNet;
            public new EntityStatsNetData.EntityStatsNet Stats => base.Stats as EntityStatsNetData.EntityStatsNet;
            public new EntityEquipmentNetData.EntityEquipmentNet Equipment => base.Equipment as EntityEquipmentNetData.EntityEquipmentNet;
            public new EntityBeingNetData.EntityBeingNet Being => base.Being as EntityBeingNetData.EntityBeingNet;
            public new EntityAbilitiesNetData.EntityAbilitiesNet Abilities => base.Abilities as EntityAbilitiesNetData.EntityAbilitiesNet;
            public new EntityInteractionsNetData.EntityInteractionsNet Interactions => base.Interactions as EntityInteractionsNetData.EntityInteractionsNet;
            public new EntityMovementsNetData.EntityMovementsNet Movements => base.Movements as EntityMovementsNetData.EntityMovementsNet;
            public new EntityAnimationsNetData.EntityAnimationsNet Animations => base.Animations as EntityAnimationsNetData.EntityAnimationsNet;
            public new EntityVisualNetData.EntityVisualNet Visual => base.Visual as EntityVisualNetData.EntityVisualNet;
            public new EntityLootNetData.EntityLootNet Loot => base.Loot as EntityLootNetData.EntityLootNet;
            #endregion
        }
    }
}