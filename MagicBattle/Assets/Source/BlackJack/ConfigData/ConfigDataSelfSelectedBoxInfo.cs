using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000288 RID: 648
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSelfSelectedBoxInfo")]
	[Serializable]
	public class ConfigDataSelfSelectedBoxInfo : IExtensible
	{
		// Token: 0x06002A15 RID: 10773 RVA: 0x000B0C20 File Offset: 0x000AEE20
		public ConfigDataSelfSelectedBoxInfo()
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

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x000B0C94 File Offset: 0x000AEE94
		// (set) Token: 0x06002A17 RID: 10775 RVA: 0x000B0C9C File Offset: 0x000AEE9C
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

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x000B0CA8 File Offset: 0x000AEEA8
		[ProtoMember(3, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x000B0CB0 File Offset: 0x000AEEB0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000B0CC0 File Offset: 0x000AEEC0
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

		// Token: 0x06002A1B RID: 10779 RVA: 0x000B0D8C File Offset: 0x000AEF8C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSelfSelectedBoxInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040019EB RID: 6635
		private int _ID;

		// Token: 0x040019EC RID: 6636
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x040019ED RID: 6637
		private IExtension extensionObject;

		// Token: 0x040019EE RID: 6638
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040019EF RID: 6639
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040019F0 RID: 6640
		private LuaFunction m_ctor_hotfix;
	}
}
