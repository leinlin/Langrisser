using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005DD RID: 1501
	[ProtoContract(Name = "BagItemDecomposeAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BagItemDecomposeAck : IExtensible
	{
		// Token: 0x06005415 RID: 21525 RVA: 0x0018CE6C File Offset: 0x0018B06C
		public BagItemDecomposeAck()
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

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x0018CEE0 File Offset: 0x0018B0E0
		// (set) Token: 0x06005417 RID: 21527 RVA: 0x0018CEE8 File Offset: 0x0018B0E8
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

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x0018CEF4 File Offset: 0x0018B0F4
		[ProtoMember(2, Name = "Goods", DataFormat = DataFormat.Default)]
		public List<ProGoods> Goods
		{
			get
			{
				return this._Goods;
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06005419 RID: 21529 RVA: 0x0018CEFC File Offset: 0x0018B0FC
		// (set) Token: 0x0600541A RID: 21530 RVA: 0x0018CF04 File Offset: 0x0018B104
		[ProtoMember(3, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x0018CF10 File Offset: 0x0018B110
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x0018CF20 File Offset: 0x0018B120
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

		// Token: 0x0600541D RID: 21533 RVA: 0x0018CFEC File Offset: 0x0018B1EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BagItemDecomposeAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F2B RID: 16171
		private int _Result;

		// Token: 0x04003F2C RID: 16172
		private readonly List<ProGoods> _Goods = new List<ProGoods>();

		// Token: 0x04003F2D RID: 16173
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04003F2E RID: 16174
		private IExtension extensionObject;

		// Token: 0x04003F2F RID: 16175
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F30 RID: 16176
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F31 RID: 16177
		private LuaFunction m_ctor_hotfix;
	}
}
