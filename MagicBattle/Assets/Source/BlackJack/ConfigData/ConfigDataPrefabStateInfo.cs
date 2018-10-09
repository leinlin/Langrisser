using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000269 RID: 617
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataPrefabStateInfo")]
	[Serializable]
	public class ConfigDataPrefabStateInfo : IExtensible
	{
		// Token: 0x0600278E RID: 10126 RVA: 0x000AC254 File Offset: 0x000AA454
		public ConfigDataPrefabStateInfo()
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

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000AC2BC File Offset: 0x000AA4BC
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x000AC2C4 File Offset: 0x000AA4C4
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000AC2D0 File Offset: 0x000AA4D0
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x000AC2D8 File Offset: 0x000AA4D8
		[ProtoMember(3, IsRequired = true, Name = "Prefab", DataFormat = DataFormat.Default)]
		public string Prefab
		{
			get
			{
				return this._Prefab;
			}
			set
			{
				this._Prefab = value;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x000AC2E4 File Offset: 0x000AA4E4
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x000AC2EC File Offset: 0x000AA4EC
		[ProtoMember(4, IsRequired = true, Name = "State", DataFormat = DataFormat.Default)]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				this._State = value;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x000AC300 File Offset: 0x000AA500
		[ProtoMember(5, IsRequired = true, Name = "IsLoop", DataFormat = DataFormat.Default)]
		public bool IsLoop
		{
			get
			{
				return this._IsLoop;
			}
			set
			{
				this._IsLoop = value;
			}
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000AC30C File Offset: 0x000AA50C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000AC31C File Offset: 0x000AA51C
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

		// Token: 0x06002799 RID: 10137 RVA: 0x000AC3E8 File Offset: 0x000AA5E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataPrefabStateInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400183C RID: 6204
		private int _ID;

		// Token: 0x0400183D RID: 6205
		private string _Prefab;

		// Token: 0x0400183E RID: 6206
		private string _State;

		// Token: 0x0400183F RID: 6207
		private bool _IsLoop;

		// Token: 0x04001840 RID: 6208
		private IExtension extensionObject;

		// Token: 0x04001841 RID: 6209
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001842 RID: 6210
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001843 RID: 6211
		private LuaFunction m_ctor_hotfix;
	}
}
