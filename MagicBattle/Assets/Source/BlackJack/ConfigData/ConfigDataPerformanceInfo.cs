using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000267 RID: 615
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataPerformanceInfo")]
	[Serializable]
	public class ConfigDataPerformanceInfo : IExtensible
	{
		// Token: 0x06002779 RID: 10105 RVA: 0x000ABE70 File Offset: 0x000AA070
		public ConfigDataPerformanceInfo()
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

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000ABEE4 File Offset: 0x000AA0E4
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x000ABEEC File Offset: 0x000AA0EC
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

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x000ABEF8 File Offset: 0x000AA0F8
		[ProtoMember(3, Name = "HeroPerformances_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> HeroPerformances_ID
		{
			get
			{
				return this._HeroPerformances_ID;
			}
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000ABF00 File Offset: 0x000AA100
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000ABF10 File Offset: 0x000AA110
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

		// Token: 0x0600277F RID: 10111 RVA: 0x000ABFDC File Offset: 0x000AA1DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataPerformanceInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400182D RID: 6189
		private int _ID;

		// Token: 0x0400182E RID: 6190
		private readonly List<int> _HeroPerformances_ID = new List<int>();

		// Token: 0x0400182F RID: 6191
		private IExtension extensionObject;

		// Token: 0x04001830 RID: 6192
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001831 RID: 6193
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001832 RID: 6194
		private LuaFunction m_ctor_hotfix;
	}
}
