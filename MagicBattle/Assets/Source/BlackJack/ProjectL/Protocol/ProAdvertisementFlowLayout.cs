using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200069F RID: 1695
	[ProtoContract(Name = "ProAdvertisementFlowLayout")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProAdvertisementFlowLayout : IExtensible
	{
		// Token: 0x06005BF7 RID: 23543 RVA: 0x001A47C0 File Offset: 0x001A29C0
		public ProAdvertisementFlowLayout()
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

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06005BF8 RID: 23544 RVA: 0x001A4828 File Offset: 0x001A2A28
		// (set) Token: 0x06005BF9 RID: 23545 RVA: 0x001A4830 File Offset: 0x001A2A30
		[ProtoMember(1, IsRequired = true, Name = "ActivityId", DataFormat = DataFormat.TwosComplement)]
		public int ActivityId
		{
			get
			{
				return this._ActivityId;
			}
			set
			{
				this._ActivityId = value;
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06005BFA RID: 23546 RVA: 0x001A483C File Offset: 0x001A2A3C
		// (set) Token: 0x06005BFB RID: 23547 RVA: 0x001A4844 File Offset: 0x001A2A44
		[ProtoMember(2, IsRequired = true, Name = "IsLarge", DataFormat = DataFormat.Default)]
		public bool IsLarge
		{
			get
			{
				return this._IsLarge;
			}
			set
			{
				this._IsLarge = value;
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06005BFC RID: 23548 RVA: 0x001A4850 File Offset: 0x001A2A50
		// (set) Token: 0x06005BFD RID: 23549 RVA: 0x001A4858 File Offset: 0x001A2A58
		[ProtoMember(3, IsRequired = true, Name = "SortId", DataFormat = DataFormat.TwosComplement)]
		public int SortId
		{
			get
			{
				return this._SortId;
			}
			set
			{
				this._SortId = value;
			}
		}

		// Token: 0x06005BFE RID: 23550 RVA: 0x001A4864 File Offset: 0x001A2A64
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x001A4874 File Offset: 0x001A2A74
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

		// Token: 0x06005C00 RID: 23552 RVA: 0x001A4940 File Offset: 0x001A2B40
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProAdvertisementFlowLayout));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044D6 RID: 17622
		private int _ActivityId;

		// Token: 0x040044D7 RID: 17623
		private bool _IsLarge;

		// Token: 0x040044D8 RID: 17624
		private int _SortId;

		// Token: 0x040044D9 RID: 17625
		private IExtension extensionObject;

		// Token: 0x040044DA RID: 17626
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044DB RID: 17627
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044DC RID: 17628
		private LuaFunction m_ctor_hotfix;
	}
}
