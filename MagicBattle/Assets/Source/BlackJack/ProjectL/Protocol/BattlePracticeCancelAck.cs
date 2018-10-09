using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E5 RID: 1765
	[ProtoContract(Name = "BattlePracticeCancelAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattlePracticeCancelAck : IExtensible
	{
		// Token: 0x06005E56 RID: 24150 RVA: 0x001ACACC File Offset: 0x001AACCC
		public BattlePracticeCancelAck()
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

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06005E57 RID: 24151 RVA: 0x001ACB34 File Offset: 0x001AAD34
		// (set) Token: 0x06005E58 RID: 24152 RVA: 0x001ACB3C File Offset: 0x001AAD3C
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

		// Token: 0x06005E59 RID: 24153 RVA: 0x001ACB48 File Offset: 0x001AAD48
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x001ACB58 File Offset: 0x001AAD58
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

		// Token: 0x06005E5B RID: 24155 RVA: 0x001ACC24 File Offset: 0x001AAE24
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeCancelAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046A2 RID: 18082
		private int _Result;

		// Token: 0x040046A3 RID: 18083
		private IExtension extensionObject;

		// Token: 0x040046A4 RID: 18084
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046A5 RID: 18085
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046A6 RID: 18086
		private LuaFunction m_ctor_hotfix;
	}
}
