using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000264 RID: 612
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataNoviceRewardInfo")]
	[Serializable]
	public class ConfigDataNoviceRewardInfo : IExtensible
	{
		// Token: 0x0600274E RID: 10062 RVA: 0x000AB818 File Offset: 0x000A9A18
		public ConfigDataNoviceRewardInfo()
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

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x000AB88C File Offset: 0x000A9A8C
		// (set) Token: 0x06002750 RID: 10064 RVA: 0x000AB894 File Offset: 0x000A9A94
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

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x000AB8A0 File Offset: 0x000A9AA0
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x000AB8A8 File Offset: 0x000A9AA8
		[ProtoMember(3, IsRequired = true, Name = "NovicePoints", DataFormat = DataFormat.TwosComplement)]
		public int NovicePoints
		{
			get
			{
				return this._NovicePoints;
			}
			set
			{
				this._NovicePoints = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x000AB8B4 File Offset: 0x000A9AB4
		[ProtoMember(4, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000AB8BC File Offset: 0x000A9ABC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000AB8CC File Offset: 0x000A9ACC
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

		// Token: 0x06002756 RID: 10070 RVA: 0x000AB998 File Offset: 0x000A9B98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataNoviceRewardInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001810 RID: 6160
		private int _ID;

		// Token: 0x04001811 RID: 6161
		private int _NovicePoints;

		// Token: 0x04001812 RID: 6162
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x04001813 RID: 6163
		private IExtension extensionObject;

		// Token: 0x04001814 RID: 6164
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001815 RID: 6165
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001816 RID: 6166
		private LuaFunction m_ctor_hotfix;
	}
}
