using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000735 RID: 1845
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSRechargeStoreNtf")]
	[Serializable]
	public class DSRechargeStoreNtf : IExtensible
	{
		// Token: 0x06006130 RID: 24880 RVA: 0x001B6264 File Offset: 0x001B4464
		public DSRechargeStoreNtf()
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

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06006131 RID: 24881 RVA: 0x001B62D8 File Offset: 0x001B44D8
		// (set) Token: 0x06006132 RID: 24882 RVA: 0x001B62E0 File Offset: 0x001B44E0
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

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06006133 RID: 24883 RVA: 0x001B62EC File Offset: 0x001B44EC
		[ProtoMember(2, Name = "BoughtGoodsList", DataFormat = DataFormat.TwosComplement)]
		public List<int> BoughtGoodsList
		{
			get
			{
				return this._BoughtGoodsList;
			}
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x001B62F4 File Offset: 0x001B44F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x001B6304 File Offset: 0x001B4504
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

		// Token: 0x06006136 RID: 24886 RVA: 0x001B63D0 File Offset: 0x001B45D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSRechargeStoreNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048C7 RID: 18631
		private uint _Version;

		// Token: 0x040048C8 RID: 18632
		private readonly List<int> _BoughtGoodsList = new List<int>();

		// Token: 0x040048C9 RID: 18633
		private IExtension extensionObject;

		// Token: 0x040048CA RID: 18634
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048CB RID: 18635
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048CC RID: 18636
		private LuaFunction m_ctor_hotfix;
	}
}
