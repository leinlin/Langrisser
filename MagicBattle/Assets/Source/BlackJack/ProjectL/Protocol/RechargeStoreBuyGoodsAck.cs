using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000747 RID: 1863
	[ProtoContract(Name = "RechargeStoreBuyGoodsAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RechargeStoreBuyGoodsAck : IExtensible
	{
		// Token: 0x060061BE RID: 25022 RVA: 0x001B8370 File Offset: 0x001B6570
		public RechargeStoreBuyGoodsAck()
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

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x060061BF RID: 25023 RVA: 0x001B83D8 File Offset: 0x001B65D8
		// (set) Token: 0x060061C0 RID: 25024 RVA: 0x001B83E0 File Offset: 0x001B65E0
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x060061C1 RID: 25025 RVA: 0x001B83EC File Offset: 0x001B65EC
		// (set) Token: 0x060061C2 RID: 25026 RVA: 0x001B83F4 File Offset: 0x001B65F4
		[ProtoMember(2, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060061C3 RID: 25027 RVA: 0x001B8400 File Offset: 0x001B6600
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x001B8410 File Offset: 0x001B6610
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

		// Token: 0x060061C5 RID: 25029 RVA: 0x001B84DC File Offset: 0x001B66DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RechargeStoreBuyGoodsAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004935 RID: 18741
		private int _Result;

		// Token: 0x04004936 RID: 18742
		private int _GoodsId;

		// Token: 0x04004937 RID: 18743
		private IExtension extensionObject;

		// Token: 0x04004938 RID: 18744
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004939 RID: 18745
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400493A RID: 18746
		private LuaFunction m_ctor_hotfix;
	}
}
