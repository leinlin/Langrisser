using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008EC RID: 2284
	[HotFix]
	public class TrainingGroundCompoment : TrainingGroundCompomentCommon
	{
		// Token: 0x060077C1 RID: 30657 RVA: 0x0020A958 File Offset: 0x00208B58
		public TrainingGroundCompoment()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x0020A9C0 File Offset: 0x00208BC0
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x0020AA3C File Offset: 0x00208C3C
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x0020AAA4 File Offset: 0x00208CA4
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeInit();
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x0020AB0C File Offset: 0x00208D0C
		public void DeSerialize(DSTrainingGroundNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSTrainingGroundNtf_hotfix != null)
			{
				this.m_DeSerializeDSTrainingGroundNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_trainingGroundDS.ClearInitedData();
			this.m_trainingGroundDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
			this.m_trainingGroundDS.TrainingGround.ConfigDataLoader = base.m_configDataLoader;
			this.m_trainingGroundDS.UpdateInstantiatedData(ntf);
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x0020ABC4 File Offset: 0x00208DC4
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_trainingGroundDS.ClientVersion;
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x060077C7 RID: 30663 RVA: 0x0020AC3C File Offset: 0x00208E3C
		// (set) Token: 0x060077C8 RID: 30664 RVA: 0x0020AC5C File Offset: 0x00208E5C
		[DoNotToLua]
		public new TrainingGroundCompoment.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TrainingGroundCompoment.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x0020AC68 File Offset: 0x00208E68
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x0020AC70 File Offset: 0x00208E70
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x0020AC78 File Offset: 0x00208E78
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x0020AC80 File Offset: 0x00208E80
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x0020AC88 File Offset: 0x00208E88
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x0020AC94 File Offset: 0x00208E94
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x0020AC9C File Offset: 0x00208E9C
		private int __callBase_GetTechMaxLevel(int TechId)
		{
			return base.GetTechMaxLevel(TechId);
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x0020ACA8 File Offset: 0x00208EA8
		private bool __callBase_IsTechLocked(int TechId)
		{
			return base.IsTechLocked(TechId);
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x0020ACB4 File Offset: 0x00208EB4
		private bool __callBase_CanLevelup(int TechId, int DeltaLevel)
		{
			return base.CanLevelup(TechId, DeltaLevel);
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x0020ACC0 File Offset: 0x00208EC0
		private TrainingTechResourceRequirements __callBase_GetResourceRequirementsByLevel(int TechId, int Level)
		{
			return base.GetResourceRequirementsByLevel(TechId, Level);
		}

		// Token: 0x060077D3 RID: 30675 RVA: 0x0020ACCC File Offset: 0x00208ECC
		private TrainingTechResourceRequirements __callBase_GetTechLevelupResourceRequirements(int TechId, int DeltaLevel)
		{
			return base.GetTechLevelupResourceRequirements(TechId, DeltaLevel);
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x0020ACD8 File Offset: 0x00208ED8
		private int __callBase_CheckTechLevelup(int TechId, int DeltaLevel)
		{
			return base.CheckTechLevelup(TechId, DeltaLevel);
		}

		// Token: 0x060077D5 RID: 30677 RVA: 0x0020ACE4 File Offset: 0x00208EE4
		private int __callBase_TechLevelup(int TechId, int DeltaLevel)
		{
			return base.TechLevelup(TechId, DeltaLevel);
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x0020ACF0 File Offset: 0x00208EF0
		private void __callBase_AddTechLevel(int TechId, int DeltaLevel, bool NoCheckAndCost)
		{
			base.AddTechLevel(TechId, DeltaLevel, NoCheckAndCost);
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x0020ACFC File Offset: 0x00208EFC
		private void __callBase_ApplyTrainingTechToHero(Hero hero, TrainingTech tech)
		{
			base.ApplyTrainingTechToHero(hero, tech);
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x0020AD08 File Offset: 0x00208F08
		private void __callBase_ApplyTrainingTechToHero(Hero hero)
		{
			base.ApplyTrainingTechToHero(hero);
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x0020AD14 File Offset: 0x00208F14
		private void __callBase_OutPutTeachnologyTreeOperateLog(int courseId, int techId, int currentLvl, List<Goods> itemGot, List<Goods> itemCost)
		{
			base.OutPutTeachnologyTreeOperateLog(courseId, techId, currentLvl, itemGot, itemCost);
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x0020AD24 File Offset: 0x00208F24
		private List<TrainingTech> __callBase_GetAvailableTechs()
		{
			return base.GetAvailableTechs();
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x0020AD2C File Offset: 0x00208F2C
		private IEnumerable<TrainingTechInfo> __callBase_IterateAvailableTechInfos()
		{
			return base.IterateAvailableTechInfos();
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x0020AD34 File Offset: 0x00208F34
		private IEnumerable<TrainingTech> __callBase_IterateAvailableTechs()
		{
			return base.IterateAvailableTechs();
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x0020AD3C File Offset: 0x00208F3C
		private int __callBase_GetTechLevel(int TechId)
		{
			return base.GetTechLevel(TechId);
		}

		// Token: 0x060077DE RID: 30686 RVA: 0x0020AD48 File Offset: 0x00208F48
		private TrainingTech __callBase_GetTech(int TechId)
		{
			return base.GetTech(TechId);
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x0020AD54 File Offset: 0x00208F54
		private TrainingRoom __callBase_GetRoom(int RoomId)
		{
			return base.GetRoom(RoomId);
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x0020AD60 File Offset: 0x00208F60
		private int __callBase_GetSoldierSkillLevelBySoldierId(int SoldierId)
		{
			return base.GetSoldierSkillLevelBySoldierId(SoldierId);
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x0020AD6C File Offset: 0x00208F6C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSTrainingGroundNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x0020AEB4 File Offset: 0x002090B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TrainingGroundCompoment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400566E RID: 22126
		[DoNotToLua]
		private TrainingGroundCompoment.LuaExportHelper luaExportHelper;

		// Token: 0x0400566F RID: 22127
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005670 RID: 22128
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005671 RID: 22129
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005672 RID: 22130
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005673 RID: 22131
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005674 RID: 22132
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005675 RID: 22133
		private LuaFunction m_DeSerializeDSTrainingGroundNtf_hotfix;

		// Token: 0x04005676 RID: 22134
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x020008ED RID: 2285
		public new class LuaExportHelper
		{
			// Token: 0x060077E3 RID: 30691 RVA: 0x0020AF1C File Offset: 0x0020911C
			public LuaExportHelper(TrainingGroundCompoment owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060077E4 RID: 30692 RVA: 0x0020AF2C File Offset: 0x0020912C
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x060077E5 RID: 30693 RVA: 0x0020AF3C File Offset: 0x0020913C
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x060077E6 RID: 30694 RVA: 0x0020AF4C File Offset: 0x0020914C
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x060077E7 RID: 30695 RVA: 0x0020AF5C File Offset: 0x0020915C
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x060077E8 RID: 30696 RVA: 0x0020AF6C File Offset: 0x0020916C
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x060077E9 RID: 30697 RVA: 0x0020AF7C File Offset: 0x0020917C
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x060077EA RID: 30698 RVA: 0x0020AF8C File Offset: 0x0020918C
			public int __callBase_GetTechMaxLevel(int TechId)
			{
				return this.m_owner.__callBase_GetTechMaxLevel(TechId);
			}

			// Token: 0x060077EB RID: 30699 RVA: 0x0020AF9C File Offset: 0x0020919C
			public bool __callBase_IsTechLocked(int TechId)
			{
				return this.m_owner.__callBase_IsTechLocked(TechId);
			}

			// Token: 0x060077EC RID: 30700 RVA: 0x0020AFAC File Offset: 0x002091AC
			public bool __callBase_CanLevelup(int TechId, int DeltaLevel)
			{
				return this.m_owner.__callBase_CanLevelup(TechId, DeltaLevel);
			}

			// Token: 0x060077ED RID: 30701 RVA: 0x0020AFBC File Offset: 0x002091BC
			public TrainingTechResourceRequirements __callBase_GetResourceRequirementsByLevel(int TechId, int Level)
			{
				return this.m_owner.__callBase_GetResourceRequirementsByLevel(TechId, Level);
			}

			// Token: 0x060077EE RID: 30702 RVA: 0x0020AFCC File Offset: 0x002091CC
			public TrainingTechResourceRequirements __callBase_GetTechLevelupResourceRequirements(int TechId, int DeltaLevel)
			{
				return this.m_owner.__callBase_GetTechLevelupResourceRequirements(TechId, DeltaLevel);
			}

			// Token: 0x060077EF RID: 30703 RVA: 0x0020AFDC File Offset: 0x002091DC
			public int __callBase_CheckTechLevelup(int TechId, int DeltaLevel)
			{
				return this.m_owner.__callBase_CheckTechLevelup(TechId, DeltaLevel);
			}

			// Token: 0x060077F0 RID: 30704 RVA: 0x0020AFEC File Offset: 0x002091EC
			public int __callBase_TechLevelup(int TechId, int DeltaLevel)
			{
				return this.m_owner.__callBase_TechLevelup(TechId, DeltaLevel);
			}

			// Token: 0x060077F1 RID: 30705 RVA: 0x0020AFFC File Offset: 0x002091FC
			public void __callBase_AddTechLevel(int TechId, int DeltaLevel, bool NoCheckAndCost)
			{
				this.m_owner.__callBase_AddTechLevel(TechId, DeltaLevel, NoCheckAndCost);
			}

			// Token: 0x060077F2 RID: 30706 RVA: 0x0020B00C File Offset: 0x0020920C
			public void __callBase_ApplyTrainingTechToHero(Hero hero, TrainingTech tech)
			{
				this.m_owner.__callBase_ApplyTrainingTechToHero(hero, tech);
			}

			// Token: 0x060077F3 RID: 30707 RVA: 0x0020B01C File Offset: 0x0020921C
			public void __callBase_ApplyTrainingTechToHero(Hero hero)
			{
				this.m_owner.__callBase_ApplyTrainingTechToHero(hero);
			}

			// Token: 0x060077F4 RID: 30708 RVA: 0x0020B02C File Offset: 0x0020922C
			public void __callBase_OutPutTeachnologyTreeOperateLog(int courseId, int techId, int currentLvl, List<Goods> itemGot, List<Goods> itemCost)
			{
				this.m_owner.__callBase_OutPutTeachnologyTreeOperateLog(courseId, techId, currentLvl, itemGot, itemCost);
			}

			// Token: 0x060077F5 RID: 30709 RVA: 0x0020B040 File Offset: 0x00209240
			public List<TrainingTech> __callBase_GetAvailableTechs()
			{
				return this.m_owner.__callBase_GetAvailableTechs();
			}

			// Token: 0x060077F6 RID: 30710 RVA: 0x0020B050 File Offset: 0x00209250
			public IEnumerable<TrainingTechInfo> __callBase_IterateAvailableTechInfos()
			{
				return this.m_owner.__callBase_IterateAvailableTechInfos();
			}

			// Token: 0x060077F7 RID: 30711 RVA: 0x0020B060 File Offset: 0x00209260
			public IEnumerable<TrainingTech> __callBase_IterateAvailableTechs()
			{
				return this.m_owner.__callBase_IterateAvailableTechs();
			}

			// Token: 0x060077F8 RID: 30712 RVA: 0x0020B070 File Offset: 0x00209270
			public int __callBase_GetTechLevel(int TechId)
			{
				return this.m_owner.__callBase_GetTechLevel(TechId);
			}

			// Token: 0x060077F9 RID: 30713 RVA: 0x0020B080 File Offset: 0x00209280
			public TrainingTech __callBase_GetTech(int TechId)
			{
				return this.m_owner.__callBase_GetTech(TechId);
			}

			// Token: 0x060077FA RID: 30714 RVA: 0x0020B090 File Offset: 0x00209290
			public TrainingRoom __callBase_GetRoom(int RoomId)
			{
				return this.m_owner.__callBase_GetRoom(RoomId);
			}

			// Token: 0x060077FB RID: 30715 RVA: 0x0020B0A0 File Offset: 0x002092A0
			public int __callBase_GetSoldierSkillLevelBySoldierId(int SoldierId)
			{
				return this.m_owner.__callBase_GetSoldierSkillLevelBySoldierId(SoldierId);
			}

			// Token: 0x04005677 RID: 22135
			private TrainingGroundCompoment m_owner;
		}
	}
}
