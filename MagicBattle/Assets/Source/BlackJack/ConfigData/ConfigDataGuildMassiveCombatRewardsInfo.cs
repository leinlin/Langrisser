using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200023E RID: 574
	[ProtoContract(Name = "ConfigDataGuildMassiveCombatRewardsInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataGuildMassiveCombatRewardsInfo : IExtensible
	{
		// Token: 0x06002363 RID: 9059 RVA: 0x000A5358 File Offset: 0x000A3558
		public ConfigDataGuildMassiveCombatRewardsInfo()
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

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x000A53CC File Offset: 0x000A35CC
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x000A53D4 File Offset: 0x000A35D4
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

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x000A53E0 File Offset: 0x000A35E0
		[ProtoMember(3, Name = "BonusItems", DataFormat = DataFormat.Default)]
		public List<Goods> BonusItems
		{
			get
			{
				return this._BonusItems;
			}
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x000A53E8 File Offset: 0x000A35E8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x000A53F8 File Offset: 0x000A35F8
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

		// Token: 0x06002369 RID: 9065 RVA: 0x000A54C4 File Offset: 0x000A36C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGuildMassiveCombatRewardsInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001571 RID: 5489
		private int _ID;

		// Token: 0x04001572 RID: 5490
		private readonly List<Goods> _BonusItems = new List<Goods>();

		// Token: 0x04001573 RID: 5491
		private IExtension extensionObject;

		// Token: 0x04001574 RID: 5492
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001575 RID: 5493
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001576 RID: 5494
		private LuaFunction m_ctor_hotfix;
	}
}
