using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C9 RID: 1481
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaRevengeOpponentGetReq")]
	[Serializable]
	public class ArenaRevengeOpponentGetReq : IExtensible
	{
		// Token: 0x06005367 RID: 21351 RVA: 0x0018A914 File Offset: 0x00188B14
		public ArenaRevengeOpponentGetReq()
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

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x0018A97C File Offset: 0x00188B7C
		// (set) Token: 0x06005369 RID: 21353 RVA: 0x0018A984 File Offset: 0x00188B84
		[ProtoMember(1, IsRequired = true, Name = "ArenaBattleReportInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong ArenaBattleReportInstanceId
		{
			get
			{
				return this._ArenaBattleReportInstanceId;
			}
			set
			{
				this._ArenaBattleReportInstanceId = value;
			}
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x0018A990 File Offset: 0x00188B90
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x0018A9A0 File Offset: 0x00188BA0
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

		// Token: 0x0600536C RID: 21356 RVA: 0x0018AA6C File Offset: 0x00188C6C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaRevengeOpponentGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EA9 RID: 16041
		private ulong _ArenaBattleReportInstanceId;

		// Token: 0x04003EAA RID: 16042
		private IExtension extensionObject;

		// Token: 0x04003EAB RID: 16043
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EAC RID: 16044
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EAD RID: 16045
		private LuaFunction m_ctor_hotfix;
	}
}
