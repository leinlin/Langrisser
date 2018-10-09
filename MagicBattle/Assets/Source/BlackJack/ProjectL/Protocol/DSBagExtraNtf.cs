using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000719 RID: 1817
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSBagExtraNtf")]
	[Serializable]
	public class DSBagExtraNtf : IExtensible
	{
		// Token: 0x0600602F RID: 24623 RVA: 0x001B2C98 File Offset: 0x001B0E98
		public DSBagExtraNtf()
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

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06006030 RID: 24624 RVA: 0x001B2D0C File Offset: 0x001B0F0C
		[ProtoMember(1, Name = "Bag", DataFormat = DataFormat.Default)]
		public List<ProGoods> Bag
		{
			get
			{
				return this._Bag;
			}
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x001B2D14 File Offset: 0x001B0F14
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x001B2D24 File Offset: 0x001B0F24
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

		// Token: 0x06006033 RID: 24627 RVA: 0x001B2DF0 File Offset: 0x001B0FF0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSBagExtraNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047FC RID: 18428
		private readonly List<ProGoods> _Bag = new List<ProGoods>();

		// Token: 0x040047FD RID: 18429
		private IExtension extensionObject;

		// Token: 0x040047FE RID: 18430
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047FF RID: 18431
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004800 RID: 18432
		private LuaFunction m_ctor_hotfix;
	}
}
