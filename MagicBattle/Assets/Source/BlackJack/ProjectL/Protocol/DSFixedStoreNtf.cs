using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000727 RID: 1831
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSFixedStoreNtf")]
	[Serializable]
	public class DSFixedStoreNtf : IExtensible
	{
		// Token: 0x060060AF RID: 24751 RVA: 0x001B4794 File Offset: 0x001B2994
		public DSFixedStoreNtf()
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

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x060060B0 RID: 24752 RVA: 0x001B4808 File Offset: 0x001B2A08
		// (set) Token: 0x060060B1 RID: 24753 RVA: 0x001B4810 File Offset: 0x001B2A10
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

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x060060B2 RID: 24754 RVA: 0x001B481C File Offset: 0x001B2A1C
		[ProtoMember(2, Name = "Stores", DataFormat = DataFormat.Default)]
		public List<ProFixedStore> Stores
		{
			get
			{
				return this._Stores;
			}
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x001B4824 File Offset: 0x001B2A24
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x001B4834 File Offset: 0x001B2A34
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

		// Token: 0x060060B5 RID: 24757 RVA: 0x001B4900 File Offset: 0x001B2B00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSFixedStoreNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004863 RID: 18531
		private uint _Version;

		// Token: 0x04004864 RID: 18532
		private readonly List<ProFixedStore> _Stores = new List<ProFixedStore>();

		// Token: 0x04004865 RID: 18533
		private IExtension extensionObject;

		// Token: 0x04004866 RID: 18534
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004867 RID: 18535
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004868 RID: 18536
		private LuaFunction m_ctor_hotfix;
	}
}
