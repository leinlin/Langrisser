using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200027E RID: 638
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRealTimePVPWinsBonusInfo")]
	[Serializable]
	public class ConfigDataRealTimePVPWinsBonusInfo : IExtensible
	{
		// Token: 0x060028EC RID: 10476 RVA: 0x000AF0BC File Offset: 0x000AD2BC
		public ConfigDataRealTimePVPWinsBonusInfo()
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

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x000AF130 File Offset: 0x000AD330
		// (set) Token: 0x060028EE RID: 10478 RVA: 0x000AF138 File Offset: 0x000AD338
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

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x000AF144 File Offset: 0x000AD344
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x000AF14C File Offset: 0x000AD34C
		[ProtoMember(3, IsRequired = true, Name = "Wins", DataFormat = DataFormat.TwosComplement)]
		public int Wins
		{
			get
			{
				return this._Wins;
			}
			set
			{
				this._Wins = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x000AF158 File Offset: 0x000AD358
		[ProtoMember(4, Name = "Bonus", DataFormat = DataFormat.Default)]
		public List<Goods> Bonus
		{
			get
			{
				return this._Bonus;
			}
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000AF160 File Offset: 0x000AD360
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000AF170 File Offset: 0x000AD370
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

		// Token: 0x060028F4 RID: 10484 RVA: 0x000AF23C File Offset: 0x000AD43C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRealTimePVPWinsBonusInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400192A RID: 6442
		private int _ID;

		// Token: 0x0400192B RID: 6443
		private int _Wins;

		// Token: 0x0400192C RID: 6444
		private readonly List<Goods> _Bonus = new List<Goods>();

		// Token: 0x0400192D RID: 6445
		private IExtension extensionObject;

		// Token: 0x0400192E RID: 6446
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400192F RID: 6447
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001930 RID: 6448
		private LuaFunction m_ctor_hotfix;
	}
}
