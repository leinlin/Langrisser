using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200067B RID: 1659
	[ProtoContract(Name = "ProHeroAssistantTask")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProHeroAssistantTask : IExtensible
	{
		// Token: 0x06005A60 RID: 23136 RVA: 0x001A0064 File Offset: 0x0019E264
		public ProHeroAssistantTask()
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

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06005A61 RID: 23137 RVA: 0x001A00D8 File Offset: 0x0019E2D8
		// (set) Token: 0x06005A62 RID: 23138 RVA: 0x001A00E0 File Offset: 0x0019E2E0
		[ProtoMember(1, IsRequired = true, Name = "ConfigId", DataFormat = DataFormat.TwosComplement)]
		public int ConfigId
		{
			get
			{
				return this._ConfigId;
			}
			set
			{
				this._ConfigId = value;
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06005A63 RID: 23139 RVA: 0x001A00EC File Offset: 0x0019E2EC
		[ProtoMember(2, Name = "AssignedHeroIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> AssignedHeroIds
		{
			get
			{
				return this._AssignedHeroIds;
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06005A64 RID: 23140 RVA: 0x001A00F4 File Offset: 0x0019E2F4
		// (set) Token: 0x06005A65 RID: 23141 RVA: 0x001A00FC File Offset: 0x0019E2FC
		[ProtoMember(3, IsRequired = true, Name = "StartTime", DataFormat = DataFormat.TwosComplement)]
		public long StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				this._StartTime = value;
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06005A66 RID: 23142 RVA: 0x001A0108 File Offset: 0x0019E308
		// (set) Token: 0x06005A67 RID: 23143 RVA: 0x001A0110 File Offset: 0x0019E310
		[ProtoMember(4, IsRequired = true, Name = "EndTime", DataFormat = DataFormat.TwosComplement)]
		public long EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				this._EndTime = value;
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06005A68 RID: 23144 RVA: 0x001A011C File Offset: 0x0019E31C
		// (set) Token: 0x06005A69 RID: 23145 RVA: 0x001A0124 File Offset: 0x0019E324
		[ProtoMember(5, IsRequired = true, Name = "Slot", DataFormat = DataFormat.TwosComplement)]
		public int Slot
		{
			get
			{
				return this._Slot;
			}
			set
			{
				this._Slot = value;
			}
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x001A0130 File Offset: 0x0019E330
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x001A0140 File Offset: 0x0019E340
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

		// Token: 0x06005A6C RID: 23148 RVA: 0x001A020C File Offset: 0x0019E40C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHeroAssistantTask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043B6 RID: 17334
		private int _ConfigId;

		// Token: 0x040043B7 RID: 17335
		private readonly List<int> _AssignedHeroIds = new List<int>();

		// Token: 0x040043B8 RID: 17336
		private long _StartTime;

		// Token: 0x040043B9 RID: 17337
		private long _EndTime;

		// Token: 0x040043BA RID: 17338
		private int _Slot;

		// Token: 0x040043BB RID: 17339
		private IExtension extensionObject;

		// Token: 0x040043BC RID: 17340
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043BD RID: 17341
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043BE RID: 17342
		private LuaFunction m_ctor_hotfix;
	}
}
