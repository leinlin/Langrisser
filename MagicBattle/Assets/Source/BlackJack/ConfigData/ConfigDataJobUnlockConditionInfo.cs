using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200025C RID: 604
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataJobUnlockConditionInfo")]
	[Serializable]
	public class ConfigDataJobUnlockConditionInfo : IExtensible
	{
		// Token: 0x0600268A RID: 9866 RVA: 0x000AA40C File Offset: 0x000A860C
		public ConfigDataJobUnlockConditionInfo()
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

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x000AA480 File Offset: 0x000A8680
		// (set) Token: 0x0600268C RID: 9868 RVA: 0x000AA488 File Offset: 0x000A8688
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

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600268D RID: 9869 RVA: 0x000AA494 File Offset: 0x000A8694
		// (set) Token: 0x0600268E RID: 9870 RVA: 0x000AA49C File Offset: 0x000A869C
		[ProtoMember(3, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x000AA4A8 File Offset: 0x000A86A8
		// (set) Token: 0x06002690 RID: 9872 RVA: 0x000AA4B0 File Offset: 0x000A86B0
		[ProtoMember(4, IsRequired = true, Name = "AchievementID", DataFormat = DataFormat.TwosComplement)]
		public int AchievementID
		{
			get
			{
				return this._AchievementID;
			}
			set
			{
				this._AchievementID = value;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002691 RID: 9873 RVA: 0x000AA4BC File Offset: 0x000A86BC
		[ProtoMember(5, Name = "ItemCost", DataFormat = DataFormat.Default)]
		public List<Goods> ItemCost
		{
			get
			{
				return this._ItemCost;
			}
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000AA4C4 File Offset: 0x000A86C4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000AA4D4 File Offset: 0x000A86D4
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

		// Token: 0x06002694 RID: 9876 RVA: 0x000AA5A0 File Offset: 0x000A87A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataJobUnlockConditionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001791 RID: 6033
		private int _ID;

		// Token: 0x04001792 RID: 6034
		private string _Desc;

		// Token: 0x04001793 RID: 6035
		private int _AchievementID;

		// Token: 0x04001794 RID: 6036
		private readonly List<Goods> _ItemCost = new List<Goods>();

		// Token: 0x04001795 RID: 6037
		private IExtension extensionObject;

		// Token: 0x04001796 RID: 6038
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001797 RID: 6039
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001798 RID: 6040
		private LuaFunction m_ctor_hotfix;
	}
}
