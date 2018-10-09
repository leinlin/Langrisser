using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000208 RID: 520
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataBattleAchievementRelatedInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataBattleAchievementRelatedInfo : IExtensible
	{
		// Token: 0x06001DEC RID: 7660 RVA: 0x0009C084 File Offset: 0x0009A284
		public ConfigDataBattleAchievementRelatedInfo()
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

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x0009C0EC File Offset: 0x0009A2EC
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x0009C0F4 File Offset: 0x0009A2F4
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

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x0009C100 File Offset: 0x0009A300
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x0009C108 File Offset: 0x0009A308
		[ProtoMember(3, IsRequired = true, Name = "Achievement_ID", DataFormat = DataFormat.TwosComplement)]
		public int Achievement_ID
		{
			get
			{
				return this._Achievement_ID;
			}
			set
			{
				this._Achievement_ID = value;
			}
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0009C114 File Offset: 0x0009A314
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0009C124 File Offset: 0x0009A324
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

		// Token: 0x06001DF3 RID: 7667 RVA: 0x0009C1F0 File Offset: 0x0009A3F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleAchievementRelatedInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040011E8 RID: 4584
		private int _ID;

		// Token: 0x040011E9 RID: 4585
		private int _Achievement_ID;

		// Token: 0x040011EA RID: 4586
		private IExtension extensionObject;

		// Token: 0x040011EB RID: 4587
		public ConfigDataBattleAchievementInfo m_achievementInfo;

		// Token: 0x040011EC RID: 4588
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040011ED RID: 4589
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040011EE RID: 4590
		private LuaFunction m_ctor_hotfix;
	}
}
