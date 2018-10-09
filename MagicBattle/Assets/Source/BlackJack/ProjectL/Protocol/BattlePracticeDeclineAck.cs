using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E2 RID: 1762
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePracticeDeclineAck")]
	[Serializable]
	public class BattlePracticeDeclineAck : IExtensible
	{
		// Token: 0x06005E46 RID: 24134 RVA: 0x001AC5A0 File Offset: 0x001AA7A0
		public BattlePracticeDeclineAck()
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

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06005E47 RID: 24135 RVA: 0x001AC608 File Offset: 0x001AA808
		// (set) Token: 0x06005E48 RID: 24136 RVA: 0x001AC610 File Offset: 0x001AA810
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

		// Token: 0x06005E49 RID: 24137 RVA: 0x001AC61C File Offset: 0x001AA81C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x001AC62C File Offset: 0x001AA82C
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

		// Token: 0x06005E4B RID: 24139 RVA: 0x001AC6F8 File Offset: 0x001AA8F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeDeclineAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004694 RID: 18068
		private int _Result;

		// Token: 0x04004695 RID: 18069
		private IExtension extensionObject;

		// Token: 0x04004696 RID: 18070
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004697 RID: 18071
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004698 RID: 18072
		private LuaFunction m_ctor_hotfix;
	}
}
