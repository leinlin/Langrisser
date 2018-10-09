using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000728 RID: 1832
	[ProtoContract(Name = "DSRandomStoreNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSRandomStoreNtf : IExtensible
	{
		// Token: 0x060060B6 RID: 24758 RVA: 0x001B4968 File Offset: 0x001B2B68
		public DSRandomStoreNtf()
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

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x060060B7 RID: 24759 RVA: 0x001B49DC File Offset: 0x001B2BDC
		// (set) Token: 0x060060B8 RID: 24760 RVA: 0x001B49E4 File Offset: 0x001B2BE4
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

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x060060B9 RID: 24761 RVA: 0x001B49F0 File Offset: 0x001B2BF0
		[ProtoMember(2, Name = "Stores", DataFormat = DataFormat.Default)]
		public List<ProRandomStore> Stores
		{
			get
			{
				return this._Stores;
			}
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x001B49F8 File Offset: 0x001B2BF8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x001B4A08 File Offset: 0x001B2C08
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

		// Token: 0x060060BC RID: 24764 RVA: 0x001B4AD4 File Offset: 0x001B2CD4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSRandomStoreNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004869 RID: 18537
		private uint _Version;

		// Token: 0x0400486A RID: 18538
		private readonly List<ProRandomStore> _Stores = new List<ProRandomStore>();

		// Token: 0x0400486B RID: 18539
		private IExtension extensionObject;

		// Token: 0x0400486C RID: 18540
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400486D RID: 18541
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400486E RID: 18542
		private LuaFunction m_ctor_hotfix;
	}
}
