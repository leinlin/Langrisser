using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006AB RID: 1707
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RedeemCrystalInfo")]
	[Serializable]
	public class RedeemCrystalInfo : IExtensible
	{
		// Token: 0x06005C93 RID: 23699 RVA: 0x001A6040 File Offset: 0x001A4240
		public RedeemCrystalInfo()
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

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06005C94 RID: 23700 RVA: 0x001A60A8 File Offset: 0x001A42A8
		// (set) Token: 0x06005C95 RID: 23701 RVA: 0x001A60B0 File Offset: 0x001A42B0
		[ProtoMember(1, IsRequired = true, Name = "RechargeCount", DataFormat = DataFormat.TwosComplement)]
		public int RechargeCount
		{
			get
			{
				return this._RechargeCount;
			}
			set
			{
				this._RechargeCount = value;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06005C96 RID: 23702 RVA: 0x001A60BC File Offset: 0x001A42BC
		// (set) Token: 0x06005C97 RID: 23703 RVA: 0x001A60C4 File Offset: 0x001A42C4
		[ProtoMember(2, IsRequired = true, Name = "Total", DataFormat = DataFormat.TwosComplement)]
		public int Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				this._Total = value;
			}
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x001A60D0 File Offset: 0x001A42D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x001A60E0 File Offset: 0x001A42E0
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

		// Token: 0x06005C9A RID: 23706 RVA: 0x001A61AC File Offset: 0x001A43AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RedeemCrystalInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400453F RID: 17727
		private int _RechargeCount;

		// Token: 0x04004540 RID: 17728
		private int _Total;

		// Token: 0x04004541 RID: 17729
		private IExtension extensionObject;

		// Token: 0x04004542 RID: 17730
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004543 RID: 17731
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004544 RID: 17732
		private LuaFunction m_ctor_hotfix;
	}
}
