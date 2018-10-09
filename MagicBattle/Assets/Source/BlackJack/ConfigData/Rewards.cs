using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000307 RID: 775
	[ProtoContract(Name = "Rewards")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class Rewards : IExtensible
	{
		// Token: 0x06002E69 RID: 11881 RVA: 0x000B98E8 File Offset: 0x000B7AE8
		public Rewards()
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

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x000B9950 File Offset: 0x000B7B50
		// (set) Token: 0x06002E6B RID: 11883 RVA: 0x000B9958 File Offset: 0x000B7B58
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x000B9964 File Offset: 0x000B7B64
		// (set) Token: 0x06002E6D RID: 11885 RVA: 0x000B996C File Offset: 0x000B7B6C
		[ProtoMember(2, IsRequired = true, Name = "Percent", DataFormat = DataFormat.TwosComplement)]
		public int Percent
		{
			get
			{
				return this._Percent;
			}
			set
			{
				this._Percent = value;
			}
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000B9978 File Offset: 0x000B7B78
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000B9988 File Offset: 0x000B7B88
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

		// Token: 0x06002E70 RID: 11888 RVA: 0x000B9A54 File Offset: 0x000B7C54
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(Rewards));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400239B RID: 9115
		private int _Id;

		// Token: 0x0400239C RID: 9116
		private int _Percent;

		// Token: 0x0400239D RID: 9117
		private IExtension extensionObject;

		// Token: 0x0400239E RID: 9118
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400239F RID: 9119
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023A0 RID: 9120
		private LuaFunction m_ctor_hotfix;
	}
}
