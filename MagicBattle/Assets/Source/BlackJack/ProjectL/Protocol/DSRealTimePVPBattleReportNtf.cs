using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000739 RID: 1849
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSRealTimePVPBattleReportNtf")]
	[Serializable]
	public class DSRealTimePVPBattleReportNtf : IExtensible
	{
		// Token: 0x0600614D RID: 24909 RVA: 0x001B69A0 File Offset: 0x001B4BA0
		public DSRealTimePVPBattleReportNtf()
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

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x0600614E RID: 24910 RVA: 0x001B6A08 File Offset: 0x001B4C08
		// (set) Token: 0x0600614F RID: 24911 RVA: 0x001B6A10 File Offset: 0x001B4C10
		[ProtoMember(1, IsRequired = true, Name = "Report", DataFormat = DataFormat.Default)]
		public ProRealTimePVPBattleReport Report
		{
			get
			{
				return this._Report;
			}
			set
			{
				this._Report = value;
			}
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x001B6A1C File Offset: 0x001B4C1C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x001B6A2C File Offset: 0x001B4C2C
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

		// Token: 0x06006152 RID: 24914 RVA: 0x001B6AF8 File Offset: 0x001B4CF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSRealTimePVPBattleReportNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048DE RID: 18654
		private ProRealTimePVPBattleReport _Report;

		// Token: 0x040048DF RID: 18655
		private IExtension extensionObject;

		// Token: 0x040048E0 RID: 18656
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048E1 RID: 18657
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048E2 RID: 18658
		private LuaFunction m_ctor_hotfix;
	}
}
