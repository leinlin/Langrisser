using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000210 RID: 528
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataBattleRandomArmyInfo")]
	[Serializable]
	public class ConfigDataBattleRandomArmyInfo : IExtensible
	{
		// Token: 0x06001ECD RID: 7885 RVA: 0x0009D838 File Offset: 0x0009BA38
		public ConfigDataBattleRandomArmyInfo()
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

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x0009D8AC File Offset: 0x0009BAAC
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x0009D8B4 File Offset: 0x0009BAB4
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

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x0009D8C0 File Offset: 0x0009BAC0
		[ProtoMember(3, Name = "RandomArmyActors", DataFormat = DataFormat.Default)]
		public List<RandomArmyActor> RandomArmyActors
		{
			get
			{
				return this._RandomArmyActors;
			}
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x0009D8C8 File Offset: 0x0009BAC8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0009D8D8 File Offset: 0x0009BAD8
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

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0009D9A4 File Offset: 0x0009BBA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleRandomArmyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400128A RID: 4746
		private int _ID;

		// Token: 0x0400128B RID: 4747
		private readonly List<RandomArmyActor> _RandomArmyActors = new List<RandomArmyActor>();

		// Token: 0x0400128C RID: 4748
		private IExtension extensionObject;

		// Token: 0x0400128D RID: 4749
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400128E RID: 4750
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400128F RID: 4751
		private LuaFunction m_ctor_hotfix;
	}
}
