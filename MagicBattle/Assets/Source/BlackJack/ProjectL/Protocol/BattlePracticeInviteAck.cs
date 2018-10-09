using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006DE RID: 1758
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePracticeInviteAck")]
	[Serializable]
	public class BattlePracticeInviteAck : IExtensible
	{
		// Token: 0x06005E2C RID: 24108 RVA: 0x001ABE8C File Offset: 0x001AA08C
		public BattlePracticeInviteAck()
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

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06005E2D RID: 24109 RVA: 0x001ABEF4 File Offset: 0x001AA0F4
		// (set) Token: 0x06005E2E RID: 24110 RVA: 0x001ABEFC File Offset: 0x001AA0FC
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

		// Token: 0x06005E2F RID: 24111 RVA: 0x001ABF08 File Offset: 0x001AA108
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x001ABF18 File Offset: 0x001AA118
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

		// Token: 0x06005E31 RID: 24113 RVA: 0x001ABFE4 File Offset: 0x001AA1E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeInviteAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400467F RID: 18047
		private int _Result;

		// Token: 0x04004680 RID: 18048
		private IExtension extensionObject;

		// Token: 0x04004681 RID: 18049
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004682 RID: 18050
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004683 RID: 18051
		private LuaFunction m_ctor_hotfix;
	}
}
