using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C5 RID: 1477
	[ProtoContract(Name = "ArenaBattleReportPlayBackDataGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaBattleReportPlayBackDataGetReq : IExtensible
	{
		// Token: 0x0600534A RID: 21322 RVA: 0x0018A1D8 File Offset: 0x001883D8
		public ArenaBattleReportPlayBackDataGetReq()
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

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x0600534B RID: 21323 RVA: 0x0018A240 File Offset: 0x00188440
		// (set) Token: 0x0600534C RID: 21324 RVA: 0x0018A248 File Offset: 0x00188448
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

		// Token: 0x0600534D RID: 21325 RVA: 0x0018A254 File Offset: 0x00188454
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x0018A264 File Offset: 0x00188464
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

		// Token: 0x0600534F RID: 21327 RVA: 0x0018A330 File Offset: 0x00188530
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaBattleReportPlayBackDataGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E92 RID: 16018
		private ulong _ArenaBattleReportInstanceId;

		// Token: 0x04003E93 RID: 16019
		private IExtension extensionObject;

		// Token: 0x04003E94 RID: 16020
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E95 RID: 16021
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E96 RID: 16022
		private LuaFunction m_ctor_hotfix;
	}
}
