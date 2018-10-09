using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005BA RID: 1466
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaOpponentRevengeReq")]
	[Serializable]
	public class ArenaOpponentRevengeReq : IExtensible
	{
		// Token: 0x060052ED RID: 21229 RVA: 0x00188D6C File Offset: 0x00186F6C
		public ArenaOpponentRevengeReq()
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

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x060052EE RID: 21230 RVA: 0x00188DD4 File Offset: 0x00186FD4
		// (set) Token: 0x060052EF RID: 21231 RVA: 0x00188DDC File Offset: 0x00186FDC
		[ProtoMember(1, IsRequired = true, Name = "BattleReportInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong BattleReportInstanceId
		{
			get
			{
				return this._BattleReportInstanceId;
			}
			set
			{
				this._BattleReportInstanceId = value;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x060052F0 RID: 21232 RVA: 0x00188DE8 File Offset: 0x00186FE8
		// (set) Token: 0x060052F1 RID: 21233 RVA: 0x00188DF0 File Offset: 0x00186FF0
		[ProtoMember(2, IsRequired = true, Name = "AutoBattle", DataFormat = DataFormat.Default)]
		public bool AutoBattle
		{
			get
			{
				return this._AutoBattle;
			}
			set
			{
				this._AutoBattle = value;
			}
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00188DFC File Offset: 0x00186FFC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00188E0C File Offset: 0x0018700C
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

		// Token: 0x060052F4 RID: 21236 RVA: 0x00188ED8 File Offset: 0x001870D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaOpponentRevengeReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E4C RID: 15948
		private ulong _BattleReportInstanceId;

		// Token: 0x04003E4D RID: 15949
		private bool _AutoBattle;

		// Token: 0x04003E4E RID: 15950
		private IExtension extensionObject;

		// Token: 0x04003E4F RID: 15951
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E50 RID: 15952
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E51 RID: 15953
		private LuaFunction m_ctor_hotfix;
	}
}
