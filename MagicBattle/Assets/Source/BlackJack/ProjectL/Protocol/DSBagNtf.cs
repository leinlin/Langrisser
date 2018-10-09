using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000718 RID: 1816
	[ProtoContract(Name = "DSBagNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSBagNtf : IExtensible
	{
		// Token: 0x06006028 RID: 24616 RVA: 0x001B2AC4 File Offset: 0x001B0CC4
		public DSBagNtf()
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

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06006029 RID: 24617 RVA: 0x001B2B38 File Offset: 0x001B0D38
		// (set) Token: 0x0600602A RID: 24618 RVA: 0x001B2B40 File Offset: 0x001B0D40
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

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x0600602B RID: 24619 RVA: 0x001B2B4C File Offset: 0x001B0D4C
		[ProtoMember(2, Name = "Bag", DataFormat = DataFormat.Default)]
		public List<ProGoods> Bag
		{
			get
			{
				return this._Bag;
			}
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x001B2B54 File Offset: 0x001B0D54
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x001B2B64 File Offset: 0x001B0D64
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

		// Token: 0x0600602E RID: 24622 RVA: 0x001B2C30 File Offset: 0x001B0E30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSBagNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047F6 RID: 18422
		private uint _Version;

		// Token: 0x040047F7 RID: 18423
		private readonly List<ProGoods> _Bag = new List<ProGoods>();

		// Token: 0x040047F8 RID: 18424
		private IExtension extensionObject;

		// Token: 0x040047F9 RID: 18425
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047FA RID: 18426
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047FB RID: 18427
		private LuaFunction m_ctor_hotfix;
	}
}
