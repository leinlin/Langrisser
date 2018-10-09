using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C3 RID: 1475
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaBattleFinishedReq")]
	[Serializable]
	public class ArenaBattleFinishedReq : IExtensible
	{
		// Token: 0x06005337 RID: 21303 RVA: 0x00189E08 File Offset: 0x00188008
		public ArenaBattleFinishedReq()
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

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x00189E70 File Offset: 0x00188070
		// (set) Token: 0x06005339 RID: 21305 RVA: 0x00189E78 File Offset: 0x00188078
		[ProtoMember(1, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public ProBattleReport BattleReport
		{
			get
			{
				return this._BattleReport;
			}
			set
			{
				this._BattleReport = value;
			}
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x00189E84 File Offset: 0x00188084
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x00189E94 File Offset: 0x00188094
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

		// Token: 0x0600533C RID: 21308 RVA: 0x00189F60 File Offset: 0x00188160
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E84 RID: 16004
		private ProBattleReport _BattleReport;

		// Token: 0x04003E85 RID: 16005
		private IExtension extensionObject;

		// Token: 0x04003E86 RID: 16006
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E87 RID: 16007
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E88 RID: 16008
		private LuaFunction m_ctor_hotfix;
	}
}
