using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000741 RID: 1857
	[ProtoContract(Name = "GiftStoreAppleSubscribeAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GiftStoreAppleSubscribeAck : IExtensible
	{
		// Token: 0x0600618D RID: 24973 RVA: 0x001B7864 File Offset: 0x001B5A64
		public GiftStoreAppleSubscribeAck()
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

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x0600618E RID: 24974 RVA: 0x001B78CC File Offset: 0x001B5ACC
		// (set) Token: 0x0600618F RID: 24975 RVA: 0x001B78D4 File Offset: 0x001B5AD4
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

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06006190 RID: 24976 RVA: 0x001B78E0 File Offset: 0x001B5AE0
		// (set) Token: 0x06006191 RID: 24977 RVA: 0x001B78E8 File Offset: 0x001B5AE8
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

		// Token: 0x06006192 RID: 24978 RVA: 0x001B78F4 File Offset: 0x001B5AF4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x001B7904 File Offset: 0x001B5B04
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

		// Token: 0x06006194 RID: 24980 RVA: 0x001B79D0 File Offset: 0x001B5BD0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreAppleSubscribeAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004910 RID: 18704
		private int _Result;

		// Token: 0x04004911 RID: 18705
		private int _GoodsId;

		// Token: 0x04004912 RID: 18706
		private IExtension extensionObject;

		// Token: 0x04004913 RID: 18707
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004914 RID: 18708
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004915 RID: 18709
		private LuaFunction m_ctor_hotfix;
	}
}
