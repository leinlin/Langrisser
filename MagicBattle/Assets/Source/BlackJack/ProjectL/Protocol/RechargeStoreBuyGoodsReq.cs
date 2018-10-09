using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000746 RID: 1862
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RechargeStoreBuyGoodsReq")]
	[Serializable]
	public class RechargeStoreBuyGoodsReq : IExtensible
	{
		// Token: 0x060061B8 RID: 25016 RVA: 0x001B81B0 File Offset: 0x001B63B0
		public RechargeStoreBuyGoodsReq()
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

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x060061B9 RID: 25017 RVA: 0x001B8218 File Offset: 0x001B6418
		// (set) Token: 0x060061BA RID: 25018 RVA: 0x001B8220 File Offset: 0x001B6420
		[ProtoMember(1, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
		public int GoodsId
		{
			get
			{
				return this._GoodsId;
			}
			set
			{
				this._GoodsId = value;
			}
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x001B822C File Offset: 0x001B642C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x001B823C File Offset: 0x001B643C
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

		// Token: 0x060061BD RID: 25021 RVA: 0x001B8308 File Offset: 0x001B6508
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RechargeStoreBuyGoodsReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004930 RID: 18736
		private int _GoodsId;

		// Token: 0x04004931 RID: 18737
		private IExtension extensionObject;

		// Token: 0x04004932 RID: 18738
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004933 RID: 18739
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004934 RID: 18740
		private LuaFunction m_ctor_hotfix;
	}
}
