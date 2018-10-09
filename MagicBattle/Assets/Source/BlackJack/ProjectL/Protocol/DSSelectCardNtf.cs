using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200071F RID: 1823
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSSelectCardNtf")]
	[Serializable]
	public class DSSelectCardNtf : IExtensible
	{
		// Token: 0x0600606A RID: 24682 RVA: 0x001B3838 File Offset: 0x001B1A38
		public DSSelectCardNtf()
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

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x0600606B RID: 24683 RVA: 0x001B38AC File Offset: 0x001B1AAC
		// (set) Token: 0x0600606C RID: 24684 RVA: 0x001B38B4 File Offset: 0x001B1AB4
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

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x0600606D RID: 24685 RVA: 0x001B38C0 File Offset: 0x001B1AC0
		[ProtoMember(2, Name = "CardPools", DataFormat = DataFormat.Default)]
		public List<ProCardPool> CardPools
		{
			get
			{
				return this._CardPools;
			}
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x001B38C8 File Offset: 0x001B1AC8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x001B38D8 File Offset: 0x001B1AD8
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

		// Token: 0x06006070 RID: 24688 RVA: 0x001B39A4 File Offset: 0x001B1BA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSSelectCardNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004829 RID: 18473
		private uint _Version;

		// Token: 0x0400482A RID: 18474
		private readonly List<ProCardPool> _CardPools = new List<ProCardPool>();

		// Token: 0x0400482B RID: 18475
		private IExtension extensionObject;

		// Token: 0x0400482C RID: 18476
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400482D RID: 18477
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400482E RID: 18478
		private LuaFunction m_ctor_hotfix;
	}
}
