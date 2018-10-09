using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B1 RID: 1713
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProGuildMassiveCombatGeneralInfo")]
	[Serializable]
	public class ProGuildMassiveCombatGeneralInfo : IExtensible
	{
		// Token: 0x06005CD3 RID: 23763 RVA: 0x001A6BFC File Offset: 0x001A4DFC
		public ProGuildMassiveCombatGeneralInfo()
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

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06005CD4 RID: 23764 RVA: 0x001A6C70 File Offset: 0x001A4E70
		[ProtoMember(1, Name = "FinishedCombats", DataFormat = DataFormat.Default)]
		public List<ProGuildMassiveCombatInfo> FinishedCombats
		{
			get
			{
				return this._FinishedCombats;
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06005CD5 RID: 23765 RVA: 0x001A6C78 File Offset: 0x001A4E78
		// (set) Token: 0x06005CD6 RID: 23766 RVA: 0x001A6C80 File Offset: 0x001A4E80
		[ProtoMember(2, IsRequired = true, Name = "RecentCombat", DataFormat = DataFormat.Default)]
		public ProGuildMassiveCombatInfo RecentCombat
		{
			get
			{
				return this._RecentCombat;
			}
			set
			{
				this._RecentCombat = value;
			}
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x001A6C8C File Offset: 0x001A4E8C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x001A6C9C File Offset: 0x001A4E9C
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

		// Token: 0x06005CD9 RID: 23769 RVA: 0x001A6D68 File Offset: 0x001A4F68
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildMassiveCombatGeneralInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400456D RID: 17773
		private readonly List<ProGuildMassiveCombatInfo> _FinishedCombats = new List<ProGuildMassiveCombatInfo>();

		// Token: 0x0400456E RID: 17774
		private ProGuildMassiveCombatInfo _RecentCombat;

		// Token: 0x0400456F RID: 17775
		private IExtension extensionObject;

		// Token: 0x04004570 RID: 17776
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004571 RID: 17777
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004572 RID: 17778
		private LuaFunction m_ctor_hotfix;
	}
}
