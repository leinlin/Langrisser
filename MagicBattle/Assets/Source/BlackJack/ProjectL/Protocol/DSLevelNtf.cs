using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200071A RID: 1818
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSLevelNtf")]
	[Serializable]
	public class DSLevelNtf : IExtensible
	{
		// Token: 0x06006034 RID: 24628 RVA: 0x001B2E58 File Offset: 0x001B1058
		public DSLevelNtf()
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

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06006035 RID: 24629 RVA: 0x001B2ED4 File Offset: 0x001B10D4
		// (set) Token: 0x06006036 RID: 24630 RVA: 0x001B2EDC File Offset: 0x001B10DC
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06006037 RID: 24631 RVA: 0x001B2EE8 File Offset: 0x001B10E8
		// (set) Token: 0x06006038 RID: 24632 RVA: 0x001B2EF0 File Offset: 0x001B10F0
		[ProtoMember(2, IsRequired = true, Name = "CurrentWayPointId", DataFormat = DataFormat.TwosComplement)]
		public int CurrentWayPointId
		{
			get
			{
				return this._CurrentWayPointId;
			}
			set
			{
				this._CurrentWayPointId = value;
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06006039 RID: 24633 RVA: 0x001B2EFC File Offset: 0x001B10FC
		// (set) Token: 0x0600603A RID: 24634 RVA: 0x001B2F04 File Offset: 0x001B1104
		[ProtoMember(3, IsRequired = true, Name = "ScenarioId", DataFormat = DataFormat.TwosComplement)]
		public int ScenarioId
		{
			get
			{
				return this._ScenarioId;
			}
			set
			{
				this._ScenarioId = value;
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x0600603B RID: 24635 RVA: 0x001B2F10 File Offset: 0x001B1110
		[ProtoMember(4, Name = "ArrivedWayPointIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> ArrivedWayPointIds
		{
			get
			{
				return this._ArrivedWayPointIds;
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x0600603C RID: 24636 RVA: 0x001B2F18 File Offset: 0x001B1118
		[ProtoMember(5, Name = "RandomEvents", DataFormat = DataFormat.Default)]
		public List<ProRandomEvent> RandomEvents
		{
			get
			{
				return this._RandomEvents;
			}
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x001B2F20 File Offset: 0x001B1120
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x001B2F30 File Offset: 0x001B1130
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x001B2FFC File Offset: 0x001B11FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSLevelNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004801 RID: 18433
		private uint _Version;

		// Token: 0x04004802 RID: 18434
		private int _CurrentWayPointId;

		// Token: 0x04004803 RID: 18435
		private int _ScenarioId;

		// Token: 0x04004804 RID: 18436
		private readonly List<int> _ArrivedWayPointIds = new List<int>();

		// Token: 0x04004805 RID: 18437
		private readonly List<ProRandomEvent> _RandomEvents = new List<ProRandomEvent>();

		// Token: 0x04004806 RID: 18438
		private IExtension extensionObject;

		// Token: 0x04004807 RID: 18439
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004808 RID: 18440
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004809 RID: 18441
		private LuaFunction m_ctor_hotfix;
	}
}
