using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006AC RID: 1708
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RedeemBundleInfo")]
	[Serializable]
	public class RedeemBundleInfo : IExtensible
	{
		// Token: 0x06005C9B RID: 23707 RVA: 0x001A6214 File Offset: 0x001A4414
		public RedeemBundleInfo()
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

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06005C9C RID: 23708 RVA: 0x001A6288 File Offset: 0x001A4488
		[ProtoMember(1, Name = "Counts", DataFormat = DataFormat.TwosComplement)]
		public List<int> Counts
		{
			get
			{
				return this._Counts;
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06005C9D RID: 23709 RVA: 0x001A6290 File Offset: 0x001A4490
		// (set) Token: 0x06005C9E RID: 23710 RVA: 0x001A6298 File Offset: 0x001A4498
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

		// Token: 0x06005C9F RID: 23711 RVA: 0x001A62A4 File Offset: 0x001A44A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x001A62B4 File Offset: 0x001A44B4
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

		// Token: 0x06005CA1 RID: 23713 RVA: 0x001A6380 File Offset: 0x001A4580
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RedeemBundleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004545 RID: 17733
		private readonly List<int> _Counts = new List<int>();

		// Token: 0x04004546 RID: 17734
		private int _Total;

		// Token: 0x04004547 RID: 17735
		private IExtension extensionObject;

		// Token: 0x04004548 RID: 17736
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004549 RID: 17737
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400454A RID: 17738
		private LuaFunction m_ctor_hotfix;
	}
}
