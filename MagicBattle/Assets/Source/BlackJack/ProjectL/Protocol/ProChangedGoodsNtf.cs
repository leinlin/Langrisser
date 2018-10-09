using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000646 RID: 1606
	[ProtoContract(Name = "ProChangedGoodsNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProChangedGoodsNtf : IExtensible
	{
		// Token: 0x060057D6 RID: 22486 RVA: 0x001994F4 File Offset: 0x001976F4
		public ProChangedGoodsNtf()
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

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x060057D7 RID: 22487 RVA: 0x00199568 File Offset: 0x00197768
		[ProtoMember(1, Name = "changed", DataFormat = DataFormat.Default)]
		public List<ProGoods> Changed
		{
			get
			{
				return this._changed;
			}
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x00199570 File Offset: 0x00197770
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x00199580 File Offset: 0x00197780
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

		// Token: 0x060057DA RID: 22490 RVA: 0x0019964C File Offset: 0x0019784C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChangedGoodsNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041F3 RID: 16883
		private readonly List<ProGoods> _changed = new List<ProGoods>();

		// Token: 0x040041F4 RID: 16884
		private IExtension extensionObject;

		// Token: 0x040041F5 RID: 16885
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041F6 RID: 16886
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041F7 RID: 16887
		private LuaFunction m_ctor_hotfix;
	}
}
