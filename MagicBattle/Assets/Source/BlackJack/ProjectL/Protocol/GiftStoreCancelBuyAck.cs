using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000749 RID: 1865
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GiftStoreCancelBuyAck")]
	[Serializable]
	public class GiftStoreCancelBuyAck : IExtensible
	{
		// Token: 0x060061CC RID: 25036 RVA: 0x001B8704 File Offset: 0x001B6904
		public GiftStoreCancelBuyAck()
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

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x060061CD RID: 25037 RVA: 0x001B876C File Offset: 0x001B696C
		// (set) Token: 0x060061CE RID: 25038 RVA: 0x001B8774 File Offset: 0x001B6974
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

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060061CF RID: 25039 RVA: 0x001B8780 File Offset: 0x001B6980
		// (set) Token: 0x060061D0 RID: 25040 RVA: 0x001B8788 File Offset: 0x001B6988
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

		// Token: 0x060061D1 RID: 25041 RVA: 0x001B8794 File Offset: 0x001B6994
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x001B87A4 File Offset: 0x001B69A4
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

		// Token: 0x060061D3 RID: 25043 RVA: 0x001B8870 File Offset: 0x001B6A70
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreCancelBuyAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004940 RID: 18752
		private int _Result;

		// Token: 0x04004941 RID: 18753
		private int _GoodsId;

		// Token: 0x04004942 RID: 18754
		private IExtension extensionObject;

		// Token: 0x04004943 RID: 18755
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004944 RID: 18756
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004945 RID: 18757
		private LuaFunction m_ctor_hotfix;
	}
}
