using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D4 RID: 2004
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ExchangeHeroFragmentAck")]
	[Serializable]
	public class ExchangeHeroFragmentAck : IExtensible
	{
		// Token: 0x0600664E RID: 26190 RVA: 0x001C87A0 File Offset: 0x001C69A0
		public ExchangeHeroFragmentAck()
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

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x001C8808 File Offset: 0x001C6A08
		// (set) Token: 0x06006650 RID: 26192 RVA: 0x001C8810 File Offset: 0x001C6A10
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

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06006651 RID: 26193 RVA: 0x001C881C File Offset: 0x001C6A1C
		// (set) Token: 0x06006652 RID: 26194 RVA: 0x001C8824 File Offset: 0x001C6A24
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x06006653 RID: 26195 RVA: 0x001C8830 File Offset: 0x001C6A30
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x001C8840 File Offset: 0x001C6A40
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

		// Token: 0x06006655 RID: 26197 RVA: 0x001C890C File Offset: 0x001C6B0C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ExchangeHeroFragmentAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CA1 RID: 19617
		private int _Result;

		// Token: 0x04004CA2 RID: 19618
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004CA3 RID: 19619
		private IExtension extensionObject;

		// Token: 0x04004CA4 RID: 19620
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CA5 RID: 19621
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CA6 RID: 19622
		private LuaFunction m_ctor_hotfix;
	}
}
