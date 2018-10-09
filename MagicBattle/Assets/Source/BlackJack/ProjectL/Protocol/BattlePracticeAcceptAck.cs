using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E0 RID: 1760
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePracticeAcceptAck")]
	[Serializable]
	public class BattlePracticeAcceptAck : IExtensible
	{
		// Token: 0x06005E38 RID: 24120 RVA: 0x001AC20C File Offset: 0x001AA40C
		public BattlePracticeAcceptAck()
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

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06005E39 RID: 24121 RVA: 0x001AC274 File Offset: 0x001AA474
		// (set) Token: 0x06005E3A RID: 24122 RVA: 0x001AC27C File Offset: 0x001AA47C
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06005E3B RID: 24123 RVA: 0x001AC288 File Offset: 0x001AA488
		// (set) Token: 0x06005E3C RID: 24124 RVA: 0x001AC290 File Offset: 0x001AA490
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public BattlePracticeAcceptReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x001AC29C File Offset: 0x001AA49C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x001AC2AC File Offset: 0x001AA4AC
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

		// Token: 0x06005E3F RID: 24127 RVA: 0x001AC378 File Offset: 0x001AA578
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeAcceptAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004689 RID: 18057
		private int _Result;

		// Token: 0x0400468A RID: 18058
		private BattlePracticeAcceptReq _Req;

		// Token: 0x0400468B RID: 18059
		private IExtension extensionObject;

		// Token: 0x0400468C RID: 18060
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400468D RID: 18061
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400468E RID: 18062
		private LuaFunction m_ctor_hotfix;
	}
}
