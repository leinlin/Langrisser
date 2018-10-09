using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000320 RID: 800
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "WaypointInfoStateList")]
	[Serializable]
	public class WaypointInfoStateList : IExtensible
	{
		// Token: 0x06002F5D RID: 12125 RVA: 0x000BC854 File Offset: 0x000BAA54
		public WaypointInfoStateList()
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

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000BC8BC File Offset: 0x000BAABC
		// (set) Token: 0x06002F5F RID: 12127 RVA: 0x000BC8C4 File Offset: 0x000BAAC4
		[ProtoMember(1, IsRequired = true, Name = "ScenarioId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000BC8D0 File Offset: 0x000BAAD0
		// (set) Token: 0x06002F61 RID: 12129 RVA: 0x000BC8D8 File Offset: 0x000BAAD8
		[ProtoMember(2, IsRequired = true, Name = "StateName", DataFormat = DataFormat.Default)]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				this._StateName = value;
			}
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x000BC8E4 File Offset: 0x000BAAE4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x000BC8F4 File Offset: 0x000BAAF4
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

		// Token: 0x06002F64 RID: 12132 RVA: 0x000BC9C0 File Offset: 0x000BABC0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WaypointInfoStateList));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002447 RID: 9287
		private int _ScenarioId;

		// Token: 0x04002448 RID: 9288
		private string _StateName;

		// Token: 0x04002449 RID: 9289
		private IExtension extensionObject;

		// Token: 0x0400244A RID: 9290
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400244B RID: 9291
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400244C RID: 9292
		private LuaFunction m_ctor_hotfix;
	}
}
