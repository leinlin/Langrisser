using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200071E RID: 1822
	[ProtoContract(Name = "DSChatNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSChatNtf : IExtensible
	{
		// Token: 0x06006062 RID: 24674 RVA: 0x001B3664 File Offset: 0x001B1864
		public DSChatNtf()
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

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06006063 RID: 24675 RVA: 0x001B36CC File Offset: 0x001B18CC
		// (set) Token: 0x06006064 RID: 24676 RVA: 0x001B36D4 File Offset: 0x001B18D4
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06006065 RID: 24677 RVA: 0x001B36E0 File Offset: 0x001B18E0
		// (set) Token: 0x06006066 RID: 24678 RVA: 0x001B36E8 File Offset: 0x001B18E8
		[ProtoMember(2, IsRequired = true, Name = "BannedTime", DataFormat = DataFormat.TwosComplement)]
		public long BannedTime
		{
			get
			{
				return this._BannedTime;
			}
			set
			{
				this._BannedTime = value;
			}
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x001B36F4 File Offset: 0x001B18F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x001B3704 File Offset: 0x001B1904
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

		// Token: 0x06006069 RID: 24681 RVA: 0x001B37D0 File Offset: 0x001B19D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSChatNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004823 RID: 18467
		private uint _Version;

		// Token: 0x04004824 RID: 18468
		private long _BannedTime;

		// Token: 0x04004825 RID: 18469
		private IExtension extensionObject;

		// Token: 0x04004826 RID: 18470
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004827 RID: 18471
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004828 RID: 18472
		private LuaFunction m_ctor_hotfix;
	}
}
