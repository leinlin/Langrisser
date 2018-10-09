using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200080E RID: 2062
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPMatchupNtf")]
	[Serializable]
	public class RealTimePVPMatchupNtf : IExtensible
	{
		// Token: 0x06006839 RID: 26681 RVA: 0x001D6740 File Offset: 0x001D4940
		public RealTimePVPMatchupNtf()
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

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x0600683A RID: 26682 RVA: 0x001D67A8 File Offset: 0x001D49A8
		// (set) Token: 0x0600683B RID: 26683 RVA: 0x001D67B0 File Offset: 0x001D49B0
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

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x0600683C RID: 26684 RVA: 0x001D67BC File Offset: 0x001D49BC
		// (set) Token: 0x0600683D RID: 26685 RVA: 0x001D67C4 File Offset: 0x001D49C4
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Opponent", DataFormat = DataFormat.Default)]
		public ProRealTimePVPUserInfo Opponent
		{
			get
			{
				return this._Opponent;
			}
			set
			{
				this._Opponent = value;
			}
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x001D67D0 File Offset: 0x001D49D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x001D67E0 File Offset: 0x001D49E0
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

		// Token: 0x06006840 RID: 26688 RVA: 0x001D68AC File Offset: 0x001D4AAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPMatchupNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005051 RID: 20561
		private int _Result;

		// Token: 0x04005052 RID: 20562
		private ProRealTimePVPUserInfo _Opponent;

		// Token: 0x04005053 RID: 20563
		private IExtension extensionObject;

		// Token: 0x04005054 RID: 20564
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005055 RID: 20565
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005056 RID: 20566
		private LuaFunction m_ctor_hotfix;
	}
}
