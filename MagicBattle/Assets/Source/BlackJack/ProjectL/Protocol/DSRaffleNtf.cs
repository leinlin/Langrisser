using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000720 RID: 1824
	[ProtoContract(Name = "DSRaffleNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSRaffleNtf : IExtensible
	{
		// Token: 0x06006071 RID: 24689 RVA: 0x001B3A0C File Offset: 0x001B1C0C
		public DSRaffleNtf()
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

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06006072 RID: 24690 RVA: 0x001B3A80 File Offset: 0x001B1C80
		// (set) Token: 0x06006073 RID: 24691 RVA: 0x001B3A88 File Offset: 0x001B1C88
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

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06006074 RID: 24692 RVA: 0x001B3A94 File Offset: 0x001B1C94
		[ProtoMember(2, Name = "RafflePools", DataFormat = DataFormat.Default)]
		public List<ProRafflePool> RafflePools
		{
			get
			{
				return this._RafflePools;
			}
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x001B3A9C File Offset: 0x001B1C9C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x001B3AAC File Offset: 0x001B1CAC
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

		// Token: 0x06006077 RID: 24695 RVA: 0x001B3B78 File Offset: 0x001B1D78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSRaffleNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400482F RID: 18479
		private uint _Version;

		// Token: 0x04004830 RID: 18480
		private readonly List<ProRafflePool> _RafflePools = new List<ProRafflePool>();

		// Token: 0x04004831 RID: 18481
		private IExtension extensionObject;

		// Token: 0x04004832 RID: 18482
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004833 RID: 18483
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004834 RID: 18484
		private LuaFunction m_ctor_hotfix;
	}
}
