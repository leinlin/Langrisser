using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C2 RID: 1986
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroConfessAck")]
	[Serializable]
	public class HeroConfessAck : IExtensible
	{
		// Token: 0x06006596 RID: 26006 RVA: 0x001C6528 File Offset: 0x001C4728
		public HeroConfessAck()
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

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06006597 RID: 26007 RVA: 0x001C6590 File Offset: 0x001C4790
		// (set) Token: 0x06006598 RID: 26008 RVA: 0x001C6598 File Offset: 0x001C4798
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

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06006599 RID: 26009 RVA: 0x001C65A4 File Offset: 0x001C47A4
		// (set) Token: 0x0600659A RID: 26010 RVA: 0x001C65AC File Offset: 0x001C47AC
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x0600659B RID: 26011 RVA: 0x001C65B8 File Offset: 0x001C47B8
		// (set) Token: 0x0600659C RID: 26012 RVA: 0x001C65C0 File Offset: 0x001C47C0
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x0600659D RID: 26013 RVA: 0x001C65CC File Offset: 0x001C47CC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x001C65DC File Offset: 0x001C47DC
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

		// Token: 0x0600659F RID: 26015 RVA: 0x001C66A8 File Offset: 0x001C48A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroConfessAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C21 RID: 19489
		private int _Result;

		// Token: 0x04004C22 RID: 19490
		private int _HeroId;

		// Token: 0x04004C23 RID: 19491
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004C24 RID: 19492
		private IExtension extensionObject;

		// Token: 0x04004C25 RID: 19493
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C26 RID: 19494
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C27 RID: 19495
		private LuaFunction m_ctor_hotfix;
	}
}
