using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000738 RID: 1848
	[ProtoContract(Name = "DSRealTimePVPPromotionBattleReportNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSRealTimePVPPromotionBattleReportNtf : IExtensible
	{
		// Token: 0x06006147 RID: 24903 RVA: 0x001B67E0 File Offset: 0x001B49E0
		public DSRealTimePVPPromotionBattleReportNtf()
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

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06006148 RID: 24904 RVA: 0x001B6848 File Offset: 0x001B4A48
		// (set) Token: 0x06006149 RID: 24905 RVA: 0x001B6850 File Offset: 0x001B4A50
		[ProtoMember(1, IsRequired = true, Name = "PromotionReport", DataFormat = DataFormat.Default)]
		public ProRealTimePVPBattleReport PromotionReport
		{
			get
			{
				return this._PromotionReport;
			}
			set
			{
				this._PromotionReport = value;
			}
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x001B685C File Offset: 0x001B4A5C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x001B686C File Offset: 0x001B4A6C
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

		// Token: 0x0600614C RID: 24908 RVA: 0x001B6938 File Offset: 0x001B4B38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSRealTimePVPPromotionBattleReportNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048D9 RID: 18649
		private ProRealTimePVPBattleReport _PromotionReport;

		// Token: 0x040048DA RID: 18650
		private IExtension extensionObject;

		// Token: 0x040048DB RID: 18651
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048DC RID: 18652
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048DD RID: 18653
		private LuaFunction m_ctor_hotfix;
	}
}
