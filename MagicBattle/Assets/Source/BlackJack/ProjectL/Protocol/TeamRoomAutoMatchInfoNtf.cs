using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000844 RID: 2116
	[ProtoContract(Name = "TeamRoomAutoMatchInfoNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomAutoMatchInfoNtf : IExtensible
	{
		// Token: 0x060069DD RID: 27101 RVA: 0x001DCA00 File Offset: 0x001DAC00
		public TeamRoomAutoMatchInfoNtf()
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

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x060069DE RID: 27102 RVA: 0x001DCA68 File Offset: 0x001DAC68
		// (set) Token: 0x060069DF RID: 27103 RVA: 0x001DCA70 File Offset: 0x001DAC70
		[ProtoMember(1, IsRequired = true, Name = "FrontOfYouWaitingNums", DataFormat = DataFormat.TwosComplement)]
		public int FrontOfYouWaitingNums
		{
			get
			{
				return this._FrontOfYouWaitingNums;
			}
			set
			{
				this._FrontOfYouWaitingNums = value;
			}
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x001DCA7C File Offset: 0x001DAC7C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x001DCA8C File Offset: 0x001DAC8C
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

		// Token: 0x060069E2 RID: 27106 RVA: 0x001DCB58 File Offset: 0x001DAD58
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomAutoMatchInfoNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005196 RID: 20886
		private int _FrontOfYouWaitingNums;

		// Token: 0x04005197 RID: 20887
		private IExtension extensionObject;

		// Token: 0x04005198 RID: 20888
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005199 RID: 20889
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400519A RID: 20890
		private LuaFunction m_ctor_hotfix;
	}
}
