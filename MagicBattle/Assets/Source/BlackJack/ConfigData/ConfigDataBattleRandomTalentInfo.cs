using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000211 RID: 529
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataBattleRandomTalentInfo")]
	[Serializable]
	public class ConfigDataBattleRandomTalentInfo : IExtensible
	{
		// Token: 0x06001ED4 RID: 7892 RVA: 0x0009DA0C File Offset: 0x0009BC0C
		public ConfigDataBattleRandomTalentInfo()
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

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x0009DA80 File Offset: 0x0009BC80
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x0009DA88 File Offset: 0x0009BC88
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

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0009DA94 File Offset: 0x0009BC94
		[ProtoMember(3, Name = "RandomTalents", DataFormat = DataFormat.Default)]
		public List<RandomTalent> RandomTalents
		{
			get
			{
				return this._RandomTalents;
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0009DA9C File Offset: 0x0009BC9C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0009DAAC File Offset: 0x0009BCAC
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

		// Token: 0x06001EDA RID: 7898 RVA: 0x0009DB78 File Offset: 0x0009BD78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleRandomTalentInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001290 RID: 4752
		private int _ID;

		// Token: 0x04001291 RID: 4753
		private readonly List<RandomTalent> _RandomTalents = new List<RandomTalent>();

		// Token: 0x04001292 RID: 4754
		private IExtension extensionObject;

		// Token: 0x04001293 RID: 4755
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001294 RID: 4756
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001295 RID: 4757
		private LuaFunction m_ctor_hotfix;
	}
}
